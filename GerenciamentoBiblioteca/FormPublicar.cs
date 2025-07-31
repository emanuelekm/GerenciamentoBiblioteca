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
        private int estrelasSelecionadas = 5;
        public FormPublicar()
        {
            InitializeComponent(); 
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            CarregarLivrosDevolvidos();
            GerarEstrelas();
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

                cbLivro.DisplayMember = "titulo";
                cbLivro.ValueMember = "id";
                cbLivro.DataSource = dt;
            }
        }

        private void GerarEstrelas()
        {
            flowEstrela.Controls.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Label estrela = new Label
                {
                    Text = "★",
                    Font = new Font("Segoe UI", 16),
                    AutoSize = true,
                    Tag = i,
                    Cursor = Cursors.Hand,
                    ForeColor = i <= estrelasSelecionadas ? Color.Gold : Color.Gray
                };
                estrela.Click += Estrela_Click;
                flowEstrela.Controls.Add(estrela);
            }
        }

        private void Estrela_Click(object sender, EventArgs e)
        {
            if (sender is Label estrela)
            {
                estrelasSelecionadas = (int)estrela.Tag;
                GerarEstrelas();
            }
        }

        private void buttonPublicar_Click(object sender, EventArgs e)
        {
            if (cbLivro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = @"INSERT INTO publicacoes (id_usuario, id_livro, comentario, estrelas) 
                                 VALUES (@idUsuario, @idLivro, @comentario, @estrelas)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idUsuario", Sessao.Id);
                cmd.Parameters.AddWithValue("@idLivro", cbLivro.SelectedValue);
                cmd.Parameters.AddWithValue("@comentario", txtComentarios.Text.Trim());
                cmd.Parameters.AddWithValue("@estrelas", estrelasSelecionadas);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Publicação realzada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
