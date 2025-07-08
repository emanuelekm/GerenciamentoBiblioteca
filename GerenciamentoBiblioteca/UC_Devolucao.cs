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

namespace GerenciamentoBiblioteca
{
    public partial class UC_Devolucao : UserControl
    {
        private MySqlConnection conexao;
        public UC_Devolucao()
        {
            InitializeComponent();

            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            this.Load += UC_Devolucao_Load;
            dataGridViewDevolucoes.RowPrePaint += dataGridViewDevolucoes_RowPrePaint;
            dataGridViewDevolucoes.CellFormatting += dataGridViewDevolucoes_CellFormatting;
        }

        private void UC_Devolucao_Load(object sender, EventArgs e)
        {
            CarregarEmprestimosEmAndamento();
            dataGridViewDevolucoes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewDevolucoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarEmprestimosEmAndamento()
        {
            List<Emprestimo> lista = new List<Emprestimo>();

            string query = @"SELECT e.id, u.nome AS NomeUsuario, l.titulo AS TituloLivro,
                           e.data_emprestimo, e.data_devolucao, e.data_devolvido, e.status
                           FROM emprestimos e
                           INNER JOIN usuarios u ON e.id_usuario = u.id
                           INNER JOIN livros l ON e.id_livro = l.id
                          WHERE e.status IN ('Em andamento', 'Devolvido', 'Devolvido com atraso');";

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Emprestimo emp = new Emprestimo
                        {
                            Id = reader.GetInt32("id"),
                            NomeUsuario = reader.GetString("NomeUsuario"),
                            TituloLivro = reader.GetString("TituloLivro"),
                            DataEmprestimo = reader.GetDateTime("data_emprestimo"),
                            DataDevolucao = reader.GetDateTime("data_devolucao"),
                            DataDevolvido = reader.IsDBNull(reader.GetOrdinal("data_devolvido"))
                            ? (DateTime?)null
                            : reader.GetDateTime("data_devolvido"),
                            Status = reader.GetString("status")
                        };
                        lista.Add(emp);
                    }
                }
                conexao.Close();
            }

            dataGridViewDevolucoes.DataSource = null;
            dataGridViewDevolucoes.DataSource = lista;
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevolucoes.SelectedRows.Count > 0)
            {
                int idEmprestimo = Convert.ToInt32(dataGridViewDevolucoes.SelectedRows[0].Cells["id"].Value);

                DateTime dataHoje = DateTime.Today;
                DateTime dataPrevistaDevolucao = Convert.ToDateTime(dataGridViewDevolucoes.SelectedRows[0].Cells["DataDevolucao"].Value);
                string novoStatus = dataHoje > dataPrevistaDevolucao ? "Devolvido com atraso" : "Devolvido";

                string updateQuery = "UPDATE emprestimos SET status = @status, data_devolvido = @dataHoje WHERE id = @id";
                int idLivro = 0;

                // 1. Descobrir o id_livro deste empréstimo
                string queryIdLivro = "SELECT id_livro FROM emprestimos WHERE id = @idEmprestimo";
                using (var cmdLivro = new MySqlCommand(queryIdLivro, conexao))
                {
                    cmdLivro.Parameters.AddWithValue("@idEmprestimo", idEmprestimo);
                    conexao.Open();
                    idLivro = Convert.ToInt32(cmdLivro.ExecuteScalar());
                    conexao.Close();
                }

                // 2. Atualizar status e data_devolvido do empréstimo
                using (var cmd = new MySqlCommand(updateQuery, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idEmprestimo);
                    cmd.Parameters.AddWithValue("@dataHoje", dataHoje);
                    cmd.Parameters.AddWithValue("@status", novoStatus);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();

                        // 3. Atualizar quantidade de exemplares do livro
                        string updateQtd = "UPDATE livros SET qtd_exemplares = qtd_exemplares + 1 WHERE id = @id_livro";
                        using (var cmdUpdate = new MySqlCommand(updateQtd, conexao))
                        {
                            cmdUpdate.Parameters.AddWithValue("@id_livro", idLivro);
                            conexao.Open();
                            cmdUpdate.ExecuteNonQuery();
                            conexao.Close();
                        }

                        // 4. Consultar nova quantidade e garantir status Disponível, se necessário
                        int novaQtd = 0;
                        string queryQtd = "SELECT qtd_exemplares FROM livros WHERE id = @id_livro";
                        using (var cmdQtd = new MySqlCommand(queryQtd, conexao))
                        {
                            cmdQtd.Parameters.AddWithValue("@id_livro", idLivro);
                            conexao.Open();
                            novaQtd = Convert.ToInt32(cmdQtd.ExecuteScalar());
                            conexao.Close();
                        }
                        if (novaQtd > 0)
                        {
                            string updateStatus = "UPDATE livros SET status = 'Disponível' WHERE id = @id_livro";
                            using (var cmdStatus = new MySqlCommand(updateStatus, conexao))
                            {
                                cmdStatus.Parameters.AddWithValue("@id_livro", idLivro);
                                conexao.Open();
                                cmdStatus.ExecuteNonQuery();
                                conexao.Close();
                            }
                        }

                        MessageBox.Show("Livro devolvido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        conexao.Close();
                    }
                }
                CarregarEmprestimosEmAndamento();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um empréstimo para devolver.");
            }

        }

        private void dataGridViewDevolucoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dataGridViewDevolucoes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid?.Rows[e.RowIndex].DataBoundItem is Emprestimo emprestimo)
            {
                if (!emprestimo.DataDevolvido.HasValue &&
                    emprestimo.DataDevolucao.HasValue &&
                    emprestimo.DataDevolucao.Value.Date < DateTime.Now.Date)
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    
                    grid.Rows[e.RowIndex].Cells["Status"].Value = "Em atraso";
                }
                else if (emprestimo.Status == "Devolvido")
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (emprestimo.Status == "Em andamento")
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (emprestimo.Status == "Devolvido com atraso")
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grid.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    
    }
}
