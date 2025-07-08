using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoBiblioteca
{
    public partial class UC_RelatoriosTabela : UserControl
    {
        //private MySqlConnection conexao;
        private Timer timerAtualizacao;
        private readonly string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";

        public UC_RelatoriosTabela()
        {
            InitializeComponent();

            InicializarTimer();
            CarregarEmprestimosNoDataGridView();

            this.buttonTabelaPDF.Click += new System.EventHandler(this.buttonTabelaPDF_Click);

            dataGridViewEmprestimo.RowPrePaint += dataGridViewEmprestimo_RowPrePaint;
            dataGridViewEmprestimo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewEmprestimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SetEmprestimosData(DataTable dt)
        {
            dataGridViewEmprestimo.DataSource = dt;
        }

        private void dataGridViewEmprestimo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            var row = dgv.Rows[e.RowIndex];
            var statusCell = row.Cells["Status"];
            var status = statusCell.Value?.ToString();

            statusCell.Style.BackColor = dgv.DefaultCellStyle.BackColor;

            if (status == "Em atraso")
                statusCell.Style.BackColor = Color.Orange;
            else if (status == "Devolvido com atraso")
                statusCell.Style.BackColor = Color.Red;
            else if (status == "Em andamento")
                statusCell.Style.BackColor = Color.Yellow;
            else if (status == "Devolvido" || status == "Efetuados")
                statusCell.Style.BackColor = Color.FromArgb(144, 238, 144);
        }

        private void InicializarTimer()
        {
            timerAtualizacao = new Timer
            {
                Interval = 5000
            };
            timerAtualizacao.Tick += (s, e) => CarregarEmprestimosNoDataGridView();
            timerAtualizacao.Start();
        }

        private void CarregarEmprestimosNoDataGridView()
        {
            try
            {
                var lista = ObterTodosEmprestimos();
                dataGridViewEmprestimo.DataSource = null;
                dataGridViewEmprestimo.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empréstimos: " + ex.Message);
            }
        }

        private List<Emprestimo> ObterTodosEmprestimos()
        {
            List<Emprestimo> lista = new List<Emprestimo>();
            string query = @"SELECT e.id, u.nome AS NomeUsuario, l.titulo AS TituloLivro,
                            e.data_emprestimo, e.data_devolucao, e.data_devolvido, e.status
                     FROM emprestimos e
                     INNER JOIN usuarios u ON e.id_usuario = u.id
                     INNER JOIN livros l ON e.id_livro = l.id";

            using (var conn = new MySqlConnection(conexaoString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime? dataDevolucao = reader.IsDBNull(reader.GetOrdinal("data_devolucao"))
                            ? (DateTime?)null : reader.GetDateTime("data_devolucao");
                        DateTime? dataDevolvido = reader.IsDBNull(reader.GetOrdinal("data_devolvido"))
                            ? (DateTime?)null : reader.GetDateTime("data_devolvido");

                        string status;
                        if (dataDevolvido != null && dataDevolucao != null)
                        {
                            if (dataDevolvido > dataDevolucao)
                                status = "Devolvido com atraso";
                            else
                                status = "Devolvido";
                        }
                        else if (dataDevolucao != null && DateTime.Now > dataDevolucao)
                        {
                            status = "Em atraso";
                        }
                        else
                        {
                            status = "Em andamento";
                        }

                        var emp = new Emprestimo
                        {
                            Id = reader.GetInt32("id"),
                            NomeUsuario = reader.GetString("NomeUsuario"),
                            TituloLivro = reader.GetString("TituloLivro"),
                            DataEmprestimo = reader.GetDateTime("data_emprestimo"),
                            DataDevolucao = dataDevolucao,
                            DataDevolvido = dataDevolvido,
                            Status = status
                        };
                        lista.Add(emp);
                    }
                }
            }
            return lista;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_Relatorios ucRelatorios = new UC_Relatorios();

            FormPrincipalAdmin form = this.FindForm() as FormPrincipalAdmin;
            if (form != null)
            {
                form.CarregarTela(ucRelatorios);
            }
        }


        private void buttonTabelaPDF_Click(object sender, EventArgs e)
        {
            buttonTabelaPDF.Enabled = false;
            timerAtualizacao?.Stop();

            string caminhoArquivo = null;

            // Salvar o caminho do arquivo na thread UI
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                sfd.FileName = "TabelaEmprestimo_Relatorio.pdf";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    buttonTabelaPDF.Enabled = true;
                    timerAtualizacao?.Start();
                    return;
                }

                caminhoArquivo = sfd.FileName;
            }

            // Copiar dados do DataGridView para uma DataTable para uso thread-safe
            DataTable dados = new DataTable();

            // Criar colunas
            foreach (DataGridViewColumn coluna in dataGridViewEmprestimo.Columns)
                dados.Columns.Add(coluna.HeaderText);

            // Copiar linhas
            foreach (DataGridViewRow row in dataGridViewEmprestimo.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = dados.NewRow();
                    for (int i = 0; i < dataGridViewEmprestimo.Columns.Count; i++)
                    {
                        dr[i] = row.Cells[i].Value?.ToString() ?? "";
                    }
                    dados.Rows.Add(dr);
                }
            }

            // Rodar exportação em background passando a DataTable
            Task.Run(() =>
            {
                bool sucesso = ExportarDataTableParaPDF(dados, caminhoArquivo);

                // Voltar para UI e mostrar mensagem / reativar botão e timer
                this.Invoke((Action)(() =>
                {
                    if (sucesso)
                        MessageBox.Show("PDF exportado com sucesso!");
                    else
                        MessageBox.Show("Erro ao exportar PDF.");

                    buttonTabelaPDF.Enabled = true;
                    timerAtualizacao?.Start();
                }));
            });
        }

        private bool ExportarDataTableParaPDF(DataTable dados, string caminhoArquivo)
        {
            try
            {
                if (dados == null || dados.Rows.Count == 0)
                    return false;

                using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    var doc = new Document(PageSize.A4.Rotate(), 40, 40, 40, 40);
                    var writer = PdfWriter.GetInstance(doc, stream);
                    writer.PageEvent = new PDFEvento(); // Rodapé com numeração
                    doc.Open();

                    Paragraph titulo = new Paragraph("Sistema de Gerenciamento de Biblioteca",
                        FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    doc.Add(new Paragraph("Relatório de Empréstimos",
                        FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD)));

                    doc.Add(new Paragraph("Gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                        FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.ITALIC)));
                    doc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(dados.Columns.Count);
                    table.WidthPercentage = 100;

                    // Cabeçalhos
                    foreach (DataColumn coluna in dados.Columns)
                    {
                        table.AddCell(new Phrase(coluna.ColumnName, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                    }

                    // Linhas
                    foreach (DataRow row in dados.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            table.AddCell(new Phrase(item?.ToString() ?? "", FontFactory.GetFont("Arial", 10)));
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ExportarDataGridViewParaPDFThreadSafe()
        {
            string caminhoArquivo = null;
            if (InvokeRequired)
            {
                Invoke(new Action(ExportarDataGridViewParaPDFThreadSafe));
                return;
            }

            ExportarDataGridViewParaPDF(dataGridViewEmprestimo, caminhoArquivo);
        }

        private void ExportarDataGridViewParaPDF(DataGridView dgv, string caminhoArquivo)
        {
            try
            {
                if (dgv == null || dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Não há dados para exportar.");
                    return;
                }

                using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    var doc = new Document(PageSize.A4.Rotate(), 40, 40, 40, 40);
                    var writer = PdfWriter.GetInstance(doc, stream);
                    writer.PageEvent = new PDFEvento(); // Rodapé com numeração
                    doc.Open();

                    Paragraph titulo = new Paragraph("Sistema de Gerenciamento de Biblioteca",
                        FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    doc.Add(new Paragraph("Relatório de Empréstimos",
                        FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD)));

                    doc.Add(new Paragraph("Gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                        FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.ITALIC)));
                    doc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(dgv.ColumnCount);
                    table.WidthPercentage = 100;

                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                    }

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string value = cell.Value?.ToString() ?? "";
                                table.AddCell(new Phrase(value, FontFactory.GetFont("Arial", 10)));
                            }
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("PDF exportado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar PDF: " + ex.Message);
            }
        }
    }
}
