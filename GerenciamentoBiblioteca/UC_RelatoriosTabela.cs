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
using System.Windows.Forms.DataVisualization.Charting;

namespace GerenciamentoBiblioteca
{
    public partial class UC_RelatoriosTabela : UserControl
    {
        private MySqlConnection conexao;
        private Timer timerAtualizacao;
        //private readonly string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";

        public UC_RelatoriosTabela()
        {
            InitializeComponent();

            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            InicializarTimer();
            CarregarEmprestimosNoDataGridView();

            //this.buttonTabelaPDF.Click += new System.EventHandler(this.buttonTabelaPDF_Click);

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
                Interval = 10000
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_Relatorios ucRelatorios = new UC_Relatorios();

            FormPrincipalAdmin form = this.FindForm() as FormPrincipalAdmin;
            if (form != null)
            {
                form.CarregarTela(ucRelatorios);
            }
        }
    }
}
