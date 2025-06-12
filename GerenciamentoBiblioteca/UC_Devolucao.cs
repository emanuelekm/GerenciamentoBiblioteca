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
        }

        private void UC_Devolucao_Load(object sender, EventArgs e)
        {
            CarregarEmprestimosEmAndamento();
            dataGridViewDevolucoes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewDevolucoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarEmprestimosEmAndamento()
        {
            string query = @"SELECT 
                                e.id, 
                                u.nome AS NomeUsuario, 
                                l.titulo AS TituloLivro,
                                e.data_emprestimo AS DataEmprestimo, 
                                e.data_devolucao AS DataDevolucao,
                                e.status AS Status
                            FROM emprestimos e
                            INNER JOIN usuarios u ON e.id_usuario = u.id
                            INNER JOIN livros l ON e.id_livro = l.id
                            WHERE e.status = 'Em andamento'";

            DataTable tabela = new DataTable();

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(tabela);
                }
                conexao.Close();
            }

            dataGridViewDevolucoes.DataSource = tabela;

            dataGridViewDevolucoes.Columns["id"].Visible = false;

            // Ajustes visuais
            dataGridViewDevolucoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDevolucoes.CellFormatting += dataGridViewDevolucoes_CellFormatting;
        }

        private void dataGridViewDevolucoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewDevolucoes.Columns[e.ColumnIndex].Name == "DataDevolucao")
            {
                DateTime dataDevolucao = Convert.ToDateTime(dataGridViewDevolucoes.Rows[e.RowIndex].Cells["DataDevolucao"].Value);
                string status = dataGridViewDevolucoes.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (status == "Em andamento" && dataDevolucao < DateTime.Today)
                {
                    dataGridViewDevolucoes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dataGridViewDevolucoes.Rows[e.RowIndex].Cells["Status"].Value = "Em atraso";
                }
            }
        }



        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevolucoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um empréstimo para devolver.");
                return;
            }

            int idEmprestimo = Convert.ToInt32(dataGridViewDevolucoes.SelectedRows[0].Cells["id"].Value);
            // arrumar isso daqui
            string updateQuery = "UPDATE emprestimos SET status = 'Devolvido', data_devolvido = CURDATE() WHERE id = @id";
            using (var cmd = new MySqlCommand(updateQuery, conexao))
            {
                cmd.Parameters.AddWithValue("@id", idEmprestimo);
                cmd.Parameters.AddWithValue("@dataHoje", DateTime.Today);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Livro devolvido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao devolver o livro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                    CarregarEmprestimosEmAndamento(); // Atualiza o DataGridView após a devolução
                }
            }
        }
        
    }

}
