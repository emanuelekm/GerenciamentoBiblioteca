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
using System.Configuration;

namespace GerenciamentoBiblioteca
{
    public partial class UC_Relatorios : UserControl
    {
        private MySqlConnection conexao;
        //private Timer timerAtualizacao;
        
        public UC_Relatorios()
        {
            InitializeComponent();

            string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            conexao = new MySqlConnection(conexaoString);

            AtualizarGraficoPizza();

            List<Emprestimo> listaEmprestimos = ObterTodosEmprestimos();
            AtualizarGrafico(listaEmprestimos);

            AtualizarGraficoEstadoLivro();

            List<Emprestimo> emprestimos = ObterTodosEmprestimos();
            CarregarLivrosEmAtraso(emprestimos);

            dataGridViewLivrosEmAtraso.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewLivrosEmAtraso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AtualizarGrafico(List<Emprestimo> emprestimos)
        {
            var chart = chartEmprestimo;
            if (chart == null) return;

            chart.Series.Clear();

            chartEmprestimo.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            var series = new Series
            {
                Name = "Empréstimos",
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false
            };

            int andamento = emprestimos.Count(e => e.Status == "Em andamento");
            int atraso = emprestimos.Count(e => e.Status == "Em atraso");
            int devolvidoAtraso = emprestimos.Count(e => e.Status == "Devolvido com atraso");
            int devolvido = emprestimos.Count(e => e.Status == "Devolvido");

            series.Points.AddXY("Em andamento", andamento);
            series.Points.AddXY("Em atraso", atraso);
            series.Points.AddXY("Devolvido c/ atraso", devolvidoAtraso);
            series.Points.AddXY("Devolvido", devolvido);

            //series.Points[0].Color = Color.Yellow;
            series.Points[0].Color = ColorTranslator.FromHtml("#f5f522");

            //series.Points[1].Color = Color.Orange;
            series.Points[1].Color = ColorTranslator.FromHtml("#f2b21b");

            //series.Points[2].Color = Color.Red;
            series.Points[2].Color = ColorTranslator.FromHtml("#ff5757");

            //series.Points[3].Color = Color.LightGreen;
            series.Points[3].Color = ColorTranslator.FromHtml("#0cc0df");

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
                conexao.Close();
            }
            return lista;
        }

        

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            var charts = new List<Chart>
            {
            chartLivroDisponibilidade,
            chartEmprestimo,
            chartEstadoLivro
            };
            ExportarParaPDF(charts, dataGridViewLivrosEmAtraso);
        }

        private void ExportarParaPDF(List<Chart> charts, DataGridView dataGridViewLivrosEmAtraso)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            sfd.FileName = "Relatorio.pdf";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            Document doc = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30);
            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                writer.PageEvent = new RodapePDF(); // Adiciona rodapé com data e numeração
                doc.Open();

                // Cabeçalho principal
                Paragraph titulo = new Paragraph("Relatório da Biblioteca", FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph("\n"));

                string[] titulosGraficos = {
            "Disponibilidade dos Livros",
            "Status dos Empréstimos",
            "Estado dos Livros"
        };

                // Tabela com 2 colunas para os gráficos
                PdfPTable tabelaGrafico = new PdfPTable(2);
                tabelaGrafico.WidthPercentage = 100;
                tabelaGrafico.SpacingAfter = 20f;

                for (int i = 0; i < charts.Count; i++)
                {
                    PdfPTable bloco = new PdfPTable(1);
                    bloco.WidthPercentage = 100;

                    // Título do gráfico
                    PdfPCell celulaTitulo = new PdfPCell(new Phrase(titulosGraficos[i], FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                    celulaTitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                    celulaTitulo.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    celulaTitulo.PaddingBottom = 5f;
                    bloco.AddCell(celulaTitulo);

                    // Gráfico
                    using (MemoryStream ms = new MemoryStream())
                    {
                        charts[i].SaveImage(ms, ChartImageFormat.Png);
                        iTextSharp.text.Image chartImg = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        chartImg.ScaleToFit(260f, 180f);
                        chartImg.Alignment = Element.ALIGN_CENTER;

                        PdfPCell celulaImagem = new PdfPCell(chartImg, true);
                        celulaImagem.HorizontalAlignment = Element.ALIGN_CENTER;
                        celulaImagem.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        bloco.AddCell(celulaImagem);
                    }

                    PdfPCell celulaBloco = new PdfPCell(bloco);
                    celulaBloco.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    tabelaGrafico.AddCell(celulaBloco);
                }

                // Se número ímpar de gráficos, adiciona célula vazia
                if (charts.Count % 2 != 0)
                {
                    tabelaGrafico.AddCell(new PdfPCell(new Phrase("")) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                }

                doc.Add(tabelaGrafico);

                // Tabela de livros em atraso
                if (dataGridViewLivrosEmAtraso != null && dataGridViewLivrosEmAtraso.Rows.Count > 0)
                {
                    Paragraph tituloTabela = new Paragraph("Tabela: Livros em Atraso", FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD));
                    tituloTabela.Alignment = Element.ALIGN_CENTER;
                    doc.Add(tituloTabela);
                    doc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(dataGridViewLivrosEmAtraso.ColumnCount);
                    table.WidthPercentage = 100;

                    // Cabeçalhos
                    foreach (DataGridViewColumn column in dataGridViewLivrosEmAtraso.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                        headerCell.BackgroundColor = new BaseColor(230, 230, 250);
                        table.AddCell(headerCell);
                    }

                    // Linhas
                    foreach (DataGridViewRow row in dataGridViewLivrosEmAtraso.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Phrase(cell.Value?.ToString() ?? "", FontFactory.GetFont("Arial", 10)));
                            }
                        }
                    }

                    doc.Add(table);
                }

                doc.Close();
                MessageBox.Show("PDF exportado com sucesso!");
            }
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

            //serie.Points[0].Color = Color.LightGreen;
            serie.Points[0].Color = ColorTranslator.FromHtml("#0cc0df");
            //serie.Points[1].Color = Color.Red;
            serie.Points[1].Color = ColorTranslator.FromHtml("#ff5757");

            chartLivroDisponibilidade.Legends[0].Docking = Docking.Bottom;

            chartLivroDisponibilidade.Series.Add(serie);
            chartLivroDisponibilidade.Titles.Clear();
            chartLivroDisponibilidade.Titles.Add("Disponibilidade de Livros");
        }

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

            //series.Points[0].Color = Color.LightGreen;
            series.Points[0].Color = ColorTranslator.FromHtml("#0cc0df");
            
            //series.Points[1].Color = Color.Yellow;
            series.Points[1].Color = ColorTranslator.FromHtml("#f5f522");

            //series.Points[2].Color = Color.Red;
            series.Points[2].Color = ColorTranslator.FromHtml("#ff5757");

            chart.Series.Add(series);

            chartEstadoLivro.Legends[0].Docking = Docking.Bottom;
        }

        private void buttonTabelaEmprestimo_Click(object sender, EventArgs e)
        {
            UC_RelatoriosTabela ucEmprestimos = new UC_RelatoriosTabela();

            FormPrincipalAdmin form = this.FindForm() as FormPrincipalAdmin;
            if (form != null)
            {
                form.CarregarTela(ucEmprestimos);
            }
        }

        private void CarregarLivrosEmAtraso(List<Emprestimo> emprestimos)
        {
            var atrasos = emprestimos
                .Where(e => e.Status == "Em atraso")
                .Select(e => new
                {
                    IDEmprestimo = e.Id,
                    NomeUsuario = e.NomeUsuario,
                    TituloLivro = e.TituloLivro,
                    DataDevolucao = e.DataDevolucao.HasValue ? e.DataDevolucao.Value.ToString("dd/MM/yyyy") : "N/A"
                })
                .ToList();

            dataGridViewLivrosEmAtraso.DataSource = atrasos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_InicioAdmin UC_InicioAdmin = new UC_InicioAdmin();

            FormPrincipalAdmin form = this.FindForm() as FormPrincipalAdmin;
            if (form != null)
            {
                form.CarregarTela(UC_InicioAdmin);
            }
        }
    }
}
