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
    public partial class FormPublicar : Form
    {
        private MySqlConnection conexao;
        public FormPublicar()
        {
            InitializeComponent(); 
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            CarregarLivrosDevolvidos();
        }
        private void CarregarLivrosDevolvidos()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = @"SELECT l.id, l.titulo 
                                 FROM emprestimos e 
                                 JOIN livros l ON e.id_livro = l.id 
                                 WHERE e.id_usuario = @idUsuario 
                                 AND e.status = 'Devolvido'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idUsuario", Sessao.Id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbLivros.DisplayMember = "titulo";
                cbLivros.ValueMember = "id";
                cbLivros.DataSource = dt;
            }
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (cbLivros.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            using (var conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = @"INSERT INTO publicacoes (id_usuario, id_livro, comentario, estrelas)
                                 VALUES (@idUsuario, @idLivro, @comentario, @estrelas)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idUsuario", Sessao.Id);
                cmd.Parameters.AddWithValue("@idLivro", cbLivros.SelectedValue);
                cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                cmd.Parameters.AddWithValue("@estrelas", (int)nudEstrelas.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Comentário publicado com sucesso!");
                txtComentario.Clear();
                nudEstrelas.Value = 1;
            }
        }
    }
}
