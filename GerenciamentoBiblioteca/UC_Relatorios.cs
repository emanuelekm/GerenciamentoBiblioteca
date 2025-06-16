using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace GerenciamentoBiblioteca
{
    public partial class UC_Relatorios : UserControl
    {
        private MySqlConnection conexao;
        private Timer timerAtualizacao;
        private DataGridView dataGridViewRelatorio;
        public UC_Relatorios()
        {
            InitializeComponent();

            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            InicializarTimer();
            CarregarEmprestimosNoDataGridView();

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
            series.Points.AddXY("Em Andamento", andamento);
            series.Points.AddXY("Em Atraso", atraso);  

            series.Points[0].Color = Color.FromArgb(144, 238, 144);  // Verde suave
            series.Points[1].Color = Color.FromArgb(255, 255, 192);  // Amarelo suave
            series.Points[2].Color = Color.FromArgb(255, 182, 193);  // Vermelho suave

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

            if (status == "Em andamento")
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192); // Amarelo suave
            else if (status == "Em atraso")
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193); // Vermelho suave
            else if (status == "Devolvido" || status == "Efetuados")
                row.DefaultCellStyle.BackColor = Color.FromArgb(144, 238, 144); // Verde suave
        }
    }
}
