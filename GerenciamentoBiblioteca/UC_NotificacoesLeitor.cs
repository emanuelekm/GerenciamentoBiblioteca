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
    public partial class UC_NotificacoesLeitor : UserControl
    {
        private MySqlConnection conexao;
        public UC_NotificacoesLeitor()
        {
            InitializeComponent();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);
            CarregarNotificacoes();
        }
        private void CarregarNotificacoes()
        {
            try
            {
                flowNotificacoes.Controls.Clear();
                conexao.Open();

                string query = @"SELECT mensagem, data_hora 
                                 FROM notificacoes_leitor 
                                 WHERE id_usuario = @id 
                                 ORDER BY data_hora DESC";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", Sessao.Id);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string mensagem = reader.GetString("mensagem");
                    DateTime data = reader.GetDateTime("data_hora");

                    flowNotificacoes.Controls.Add(CriarCardNotificacao(mensagem, data));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar notificações: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private Panel CriarCardNotificacao(string mensagem, DateTime data)
        {
            Panel card = new Panel();
            card.Width = flowNotificacoes.Width - 30;
            card.Height = 70;
            card.Padding = new Padding(10);
            card.BackColor = Color.FromArgb(255, 248, 220);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(5);
            card.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            Label lblData = new Label();
            lblData.Text = data.ToString("dd/MM/yyyy HH:mm");
            lblData.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblData.ForeColor = Color.Gray;
            lblData.Dock = DockStyle.Top;

            Label lblMensagem = new Label();
            lblMensagem.Text = mensagem;
            lblMensagem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblMensagem.Dock = DockStyle.Fill;
            lblMensagem.AutoSize = false;

            card.Controls.Add(lblMensagem);
            card.Controls.Add(lblData);

            return card;
        }
    }
}

