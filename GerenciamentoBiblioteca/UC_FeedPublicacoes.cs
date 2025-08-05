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
    public partial class UC_FeedPublicacoes : UserControl
    {
        public UC_FeedPublicacoes()
        {
            InitializeComponent();
            CarregarComentarios();
        }
        private void CarregarComentarios()
        {
            flowComentarios.Controls.Clear();

            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = @"SELECT u.nome AS Leitor, 
                                        l.titulo AS Livro, 
                                        p.estrelas, 
                                        p.comentario, 
                                        p.data_publicacao 
                                 FROM publicacoes p
                                 JOIN usuarios u ON p.id_usuario = u.id
                                 JOIN livros l ON p.id_livro = l.id
                                 ORDER BY p.data_publicacao DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AdicionarComentarioNoPainel(
                            leitor: reader.GetString("Leitor"),
                            livro: reader.GetString("Livro"),
                            estrelas: reader.GetInt32("estrelas"),
                            comentario: reader.GetString("comentario"),
                            data: reader.GetDateTime("data_publicacao")
                        );
                    }
                }
            }
        }

        private void AdicionarComentarioNoPainel(string leitor, string livro, int estrelas, string comentario, DateTime data)
        {
            Panel panel = new Panel
            {
                Width = flowComentarios.Width - 25,
                Height = 120,
                BackColor = Color.WhiteSmoke,
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblTitulo = new Label
            {
                Text = $"{leitor} avaliou \"{livro}\" - {estrelas} ★",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                Width = panel.Width - 10,
                Height = 25,
                Location = new Point(5, 5)
            };

            Label lblData = new Label
            {
                Text = data.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(5, 30),
                AutoSize = true
            };

            Label lblComentario = new Label
            {
                Text = comentario,
                Font = new Font("Segoe UI", 9),
                Location = new Point(5, 50),
                Width = panel.Width - 10,
                Height = 60,
                AutoEllipsis = true
            };

            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(lblData);
            panel.Controls.Add(lblComentario);

            flowComentarios.Controls.Add(panel);
        }

        private void buttonFazerComentario_Click(object sender, EventArgs e)
        {
            using (FormPublicar form = new FormPublicar())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CarregarComentarios(); 
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_InicioLeitor UC_InicioLeitor = new UC_InicioLeitor();

            FormPrincipalLeitor form = this.FindForm() as FormPrincipalLeitor;
            if (form != null)
            {
                form.CarregarTela(UC_InicioLeitor);
            }
        }
    }
}


