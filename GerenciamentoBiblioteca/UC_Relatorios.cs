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

            //InicializarDataGridView();
            InicializarTimer();
            CarregarEmprestimosNoDataGridView();
        }
        /*private void InicializarDataGridView()
        {
            dataGridViewRelatorio = new DataGridView();
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = true,
                AllowUserToAddRows = false,
            };
            this.Controls.Add(dataGridViewRelatorio);
        }*/

        private void InicializarTimer()
        {
            timerAtualizacao = new Timer
            {
                Interval = 5000 // 5 segundos
            };
            timerAtualizacao.Tick += (s, e) => CarregarEmprestimosNoDataGridView();
            timerAtualizacao.Start();
        }
        private void CarregarEmprestimosNoDataGridView()
        {
            try
            {
                var lista = ObterTodosEmprestimos();
                // Supondo que você já tenha adicionado pelo designer
                // um DataGridView chamado dataGridViewEmprestimo
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
            // Supondo que você já tenha adicionado pelo designer
            // um Chart chamado chartEmprestimos
            var chart = chartEmprestimo;
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
    }
}
