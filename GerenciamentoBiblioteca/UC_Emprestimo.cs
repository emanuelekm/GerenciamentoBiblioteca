using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static GerenciamentoBiblioteca.UC_ControleDeUsuarios;

namespace GerenciamentoBiblioteca
{
    public partial class UC_Emprestimo : UserControl
    {
        private MySqlConnection conexao;
        public UC_Emprestimo()
        {
            InitializeComponent();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            this.Load += UCEmprestimo_Load;
        }

        private void UCEmprestimo_Load(object sender, EventArgs e)
        {
            var adaptUsuario = new MySqlDataAdapter("SELECT id, nome FROM usuarios WHERE tipo_usuario = 'Leitor'", conexao);
            var tabelaUsuarios = new DataTable();
            adaptUsuario.Fill(tabelaUsuarios);
            comboBoxLeitor.DataSource = tabelaUsuarios;
            comboBoxLeitor.DisplayMember = "nome";
            comboBoxLeitor.ValueMember = "id";
            comboBoxLeitor.SelectedIndex = -1;

            var adaptLivros = new MySqlDataAdapter("SELECT id, titulo FROM livros WHERE status = 'Disponível'", conexao);
            var tabelaLivros = new DataTable();
            adaptLivros.Fill(tabelaLivros);
            comboBoxLivro.DataSource = tabelaLivros;
            comboBoxLivro.DisplayMember = "titulo";
            comboBoxLivro.ValueMember = "id";
            comboBoxLivro.SelectedIndex = -1;

            dtpEmprestimo.Value = DateTime.Today;
            dtpDevolucao.Value = DateTime.Today.AddDays(15);

            CarregarEmprestimosNoDataGridView();
        }

        private void buttonConfirmarEmprestimo_Click(object sender, EventArgs e)
        {
            int idUsuario = (int)comboBoxLeitor.SelectedValue;
            int idLivro = (int)comboBoxLivro.SelectedValue;
            DateTime dataEmprestimo = dtpEmprestimo.Value;
            DateTime dataPrevistaDevolucao = dtpDevolucao.Value;

            // 1. Verificar quantidade disponível
            int qtdExemplares = 0;
            string queryQtd = "SELECT qtd_exemplares FROM livros WHERE id = @id_livro";
            using (MySqlCommand cmdQtd = new MySqlCommand(queryQtd, conexao))
            {
                cmdQtd.Parameters.AddWithValue("@id_livro", idLivro);
                conexao.Open();
                qtdExemplares = Convert.ToInt32(cmdQtd.ExecuteScalar());
                conexao.Close();
            }

            if (qtdExemplares < 1)
            {
                MessageBox.Show("Este livro não possui exemplares disponíveis para empréstimo.");
                return;
            }

            // 2. Fazer o empréstimo
            string query = @"INSERT INTO emprestimos 
                (id_usuario, id_livro, data_emprestimo, data_devolucao, status)
                VALUES 
                (@id_usuario, @id_livro, @data_emprestimo, @data_devolucao, 'Em andamento')";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@id_livro", idLivro);
                cmd.Parameters.AddWithValue("@data_emprestimo", dataEmprestimo.Date);
                cmd.Parameters.AddWithValue("@data_devolucao", dataPrevistaDevolucao.Date);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar empréstimo: " + ex.Message);
                    conexao.Close();
                    return;
                }
                finally
                {
                    conexao.Close();
                }
            }

            // 3. Atualizar quantidade de exemplares
            string updateQtd = "UPDATE livros SET qtd_exemplares = qtd_exemplares - 1 WHERE id = @id_livro";
            using (MySqlCommand cmdUpdate = new MySqlCommand(updateQtd, conexao))
            {
                cmdUpdate.Parameters.AddWithValue("@id_livro", idLivro);
                conexao.Open();
                cmdUpdate.ExecuteNonQuery();
                conexao.Close();
            }

            // 4. Se zerou, atualizar status para 'Indisponível'
            int novaQtd = 0;
            using (MySqlCommand cmdCheck = new MySqlCommand(queryQtd, conexao))
            {
                cmdCheck.Parameters.AddWithValue("@id_livro", idLivro);
                conexao.Open();
                novaQtd = Convert.ToInt32(cmdCheck.ExecuteScalar());
                conexao.Close();
            }
            if (novaQtd == 0)
            {
                string updateStatus = "UPDATE livros SET status = 'Indisponível' WHERE id = @id_livro";
                using (MySqlCommand cmdStatus = new MySqlCommand(updateStatus, conexao))
                {
                    cmdStatus.Parameters.AddWithValue("@id_livro", idLivro);
                    conexao.Open();
                    cmdStatus.ExecuteNonQuery();
                    conexao.Close();
                }
            }

            MessageBox.Show("Empréstimo realizado com sucesso!");

            CarregarEmprestimosNoDataGridView();
            AtualizarResumoEmprestimo();
        }

        private void AtualizarResumoEmprestimo()
        {
            /*string livro = comboBoxLivro.Text;
            string leitor = comboBoxLeitor.Text;
            string dataEmprestimo = dtpEmprestimo.Value.ToShortDateString();
            string dataDevolucao = dtpDevolucao.Value.ToShortDateString();

            labelResumo.Text = $"Livro: {livro}\n" +
                                         $"Leitor: {leitor}\n" +
                                         $"Empréstimo: {dataEmprestimo}\n" +
                                         $"Devolução prevista: {dataDevolucao}";*/
        }

        private void dtpEmprestimo_ValueChanged(object sender, EventArgs e)
        {
            dtpDevolucao.Value = dtpEmprestimo.Value.AddDays(15);
            //AtualizarResumoEmprestimo();
        }

        private List<Emprestimo> ObterTodosEmprestimos()
        {
            List<Emprestimo> lista = new List<Emprestimo>();

            string query = @"SELECT e.id, u.nome AS NomeUsuario, l.titulo AS TituloLivro,
                            e.data_emprestimo, e.data_devolucao, e.data_devolvido,e.status
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
                            Status = reader.GetString("status"),
                            DataDevolucao = reader.IsDBNull(reader.GetOrdinal("data_devolucao"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime("data_devolucao"),
                            DataDevolvido = reader.IsDBNull(reader.GetOrdinal("data_devolvido"))
                                            ? (DateTime?)null
                                            : reader.GetDateTime("data_devolvido"),
                        };
                        lista.Add(emp);
                    }
                }
                conexao.Close();
            }

            return lista;
        }
        private void CarregarEmprestimosNoDataGridView()
        {
            List<Emprestimo> emprestimos = ObterTodosEmprestimos();

            dataGridViewEmprestimo.DataSource = null;
            dataGridViewEmprestimo.DataSource = emprestimos;

            if (dataGridViewEmprestimo.Columns.Contains("NotificacaoExcluida"))
            {
                dataGridViewEmprestimo.Columns["NotificacaoExcluida"].Visible = false;
            }

            dataGridViewEmprestimo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewEmprestimo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            comboBoxLeitor.SelectedIndex = -1;
            comboBoxLivro.SelectedIndex = -1;
            dtpEmprestimo.Value = DateTime.Today;
            dtpDevolucao.Value = DateTime.Today.AddDays(15);
            //labelResumo.Text = "";
            this.ActiveControl = null;
        }
    }
}
