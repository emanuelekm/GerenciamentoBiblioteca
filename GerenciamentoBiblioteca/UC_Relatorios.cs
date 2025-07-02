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
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;

namespace GerenciamentoBiblioteca
{
    public partial class UC_Relatorios : UserControl
    {
        private MySqlConnection conexao;
        private Timer timerAtualizacao;
        //private DataGridView dataGridViewRelatorio;
        public UC_Relatorios()
        {
            InitializeComponent();

            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            InicializarTimer();

            CarregarEmprestimosNoDataGridView();
            AtualizarGraficoPizza();
            AtualizarGraficoEstadoLivro();

            dataGridViewEmprestimo.RowPrePaint += dataGridViewEmprestimo_RowPrePaint;
            dataGridViewEmprestimo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewEmprestimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                AtualizarGrafico(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empréstimos: " + ex.Message);
            }
        }

        private void AtualizarGrafico(List<Emprestimo> emprestimos)
        {
            var chart = chartEmprestimo;
            chart.Series.Clear();

            if (chart == null) return;

            chart.Series.Clear();
            var series = new Series
            {
                Name = "Empréstimos",
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false
            };

            int efetuados = emprestimos.Count;
            int andamento = emprestimos.Count(e => e.Status == "Em andamento");
            int atraso = emprestimos.Count(e => e.Status == "Em atraso");

            series.Points.AddXY("Efetuados", efetuados);
            series.Points.AddXY("Emprestado", andamento);
            series.Points.AddXY("Em Atraso", atraso);

            series.Points[0].Color = Color.FromArgb(144, 238, 144);  // Verde suave
            series.Points[1].Color = Color.FromArgb(255, 255, 192);  // Amarelo suave
            series.Points[2].Color = Color.FromArgb(255, 182, 193);  // Vermelho suave
            
            chartEmprestimo.Legends[0].Docking = Docking.Bottom;

            chart.Series.Add(series);
        }

        private List<Emprestimo> ObterTodosEmprestimos()
        {
            List<Emprestimo> lista = new List<Emprestimo>();
            string query = @"SELECT e.id, u.nome AS NomeUsuario, l.titulo AS TituloLivro,
                            e.data_emprestimo, e.data_devolucao, e.data_devolvido, e.status
                     FROM emprestimos e
                     INNER JOIN usuarios u ON e.id_usuario = u.id
                     INNER JOIN livros l ON e.id_livro = l.id";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var emp = new Emprestimo
                        {
                            Id = reader.GetInt32("id"),
                            NomeUsuario = reader.GetString("NomeUsuario"),
                            TituloLivro = reader.GetString("TituloLivro"),
                            DataEmprestimo = reader.GetDateTime("data_emprestimo"),
                            DataDevolucao = reader.IsDBNull(reader.GetOrdinal("data_devolucao"))
                                ? (DateTime?)null : reader.GetDateTime("data_devolucao"),
                            DataDevolvido = reader.IsDBNull(reader.GetOrdinal("data_devolvido"))
                                ? (DateTime?)null : reader.GetDateTime("data_devolvido"),
                            Status = reader.GetString("status"),
                        };
                        lista.Add(emp);
                    }
                }
                conexao.Close();
            }
            return lista;
        }

        private void dataGridViewEmprestimo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            var row = dgv.Rows[e.RowIndex];
            var status = row.Cells["Status"].Value?.ToString();

            if (status == "Emprestado")
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192); // Amarelo suave
            else if (status == "Em atraso")
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193); // Vermelho suave
            else if (status == "Devolvido" || status == "Efetuados")
                row.DefaultCellStyle.BackColor = Color.FromArgb(144, 238, 144); // Verde suave
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            sfd.FileName = "RelatorioEmprestimos.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportarParaPDF(dataGridViewEmprestimo, sfd.FileName);
            }*/

            ExportarParaPDF(dataGridViewEmprestimo, chartLivroDisponibilidade);
        }

        private void ExportarParaPDF(DataGridView dgv, Chart chart)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            sfd.FileName = "Relatorio.pdf";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                // Adiciona o gráfico de pizza como imagem
                using (MemoryStream ms = new MemoryStream())
                {
                    chart.SaveImage(ms, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImg = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    chartImg.ScaleToFit(400f, 300f);
                    chartImg.Alignment = Element.ALIGN_CENTER;
                    doc.Add(chartImg);
                }

                doc.Add(new Paragraph("\n"));

                // Tabela do DataGridView
                PdfPTable tabela = new PdfPTable(dgv.Columns.Count);

                // Cabeçalhos
                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    tabela.AddCell(cell);
                }

                // Dados
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            tabela.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                }
                doc.Add(tabela);

                doc.Close();
                writer.Close();
                stream.Close();
            }
            MessageBox.Show("PDF exportado com sucesso!");
        }
        private void AtualizarGraficoPizza()
        {
            var (disponiveis, indisponiveis) = ObterQuantidadesLivros();
            chartLivroDisponibilidade.Series.Clear();

            Series serie = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };
            serie.Points.AddXY("Disponíveis", disponiveis);
            serie.Points.AddXY("Indisponíveis", indisponiveis);

            // Cores suaves
            serie.Points[0].Color = Color.FromArgb(144, 238, 144); // Verde claro
            serie.Points[1].Color = Color.FromArgb(255, 182, 193); // Vermelho claro

            chartLivroDisponibilidade.Legends[0].Docking = Docking.Bottom;

            chartLivroDisponibilidade.Series.Add(serie);
            chartLivroDisponibilidade.Titles.Clear();
            chartLivroDisponibilidade.Titles.Add("Disponibilidade de Livros");
        }

        // Método para buscar do banco
        private (int disponiveis, int indisponiveis) ObterQuantidadesLivros()
        {
            int disponiveis = 0, indisponiveis = 0;
            string query = "SELECT status, COUNT(*) as quantidade FROM livros GROUP BY status";
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader.GetString("status");
                        int quantidade = reader.GetInt32("quantidade");
                        if (status == "Disponível")
                            disponiveis = quantidade;
                        else
                            indisponiveis += quantidade;
                    }
                }
                conexao.Close();
            }
            return (disponiveis, indisponiveis);
        }
        private Dictionary<string, int> ObterLivrosPorEstado()
        {
            var resultado = new Dictionary<string, int> { { "Bom", 0 }, { "Regular", 0 }, { "Ruim", 0 } };
            string query = @"SELECT estado, COUNT(*) as total FROM livros GROUP BY estado";
            var cmd = new MySqlCommand(query, conexao);

            conexao.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string estado = reader["estado"].ToString();
                int total = Convert.ToInt32(reader["total"]);
                if (resultado.ContainsKey(estado))
                    resultado[estado] = total;
            }
            conexao.Close();
            return resultado;
        }
        private void AtualizarGraficoEstadoLivro()
        {
            var dados = ObterLivrosPorEstado();
            var chart = chartEstadoLivro;
            chart.Series.Clear();

            var series = new Series
            {
                Name = "Estados",
                ChartType = SeriesChartType.Bar,
                IsVisibleInLegend = false
            };

            series.Points.AddXY("Bom", dados["Bom"]);
            series.Points.AddXY("Regular", dados["Regular"]);
            series.Points.AddXY("Ruim", dados["Ruim"]);

            series.Points[0].Color = Color.LightGreen;
            series.Points[1].Color = Color.Yellow;
            series.Points[2].Color = Color.LightCoral;

            chart.Series.Add(series);

            chartEstadoLivro.Legends[0].Docking = Docking.Bottom;
        }
    }

    }
