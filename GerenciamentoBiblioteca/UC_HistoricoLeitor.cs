using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoBiblioteca
{
    public partial class UC_HistoricoLeitor : UserControl
    {
        private MySqlConnection conexao;

        public UC_HistoricoLeitor()
        {
            InitializeComponent();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);
            CarregarHistorico();
            dataGridViewHistorico.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CarregarHistorico()
        {
            int idUsuarioLogado = Sessao.Id;

            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        livros.titulo AS 'Título',
                        livros.autor AS 'Autor',
                        e.data_emprestimo AS 'Data do Empréstimo',
                        e.data_devolucao AS 'Data da Devolução',
                        e.status AS 'Status'
                    FROM emprestimos e
                    INNER JOIN livros ON e.id_livro = livros.id
                    WHERE e.id_usuario = @idUsuario
                    ORDER BY e.data_emprestimo DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuarioLogado);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewHistorico.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar histórico: " + ex.Message);
                }
            }
        }

        private void dataGridViewHistorico_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
    }
}
