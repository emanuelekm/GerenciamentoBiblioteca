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

    public partial class UC_NotificacoesAdmin : UserControl
    {
        private MySqlConnection conexao;

        public UC_NotificacoesAdmin()
        {
            InitializeComponent();

            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            this.Load += UC_NotificacoesAdmin_Load;

            panelLixeira.Hide();
        }

        private void UC_NotificacoesAdmin_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            flowLayoutPanelLixeira.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelLixeira.WrapContents = false;

            CarregarTodasNotificacoes();
        }
        private void CarregarTodasNotificacoes()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanelLixeira.Controls.Clear();

            var notificacoesAtivas = BuscarNotificacoes(false);
            var notificacoesExcluidas = BuscarNotificacoes(true);

            if (notificacoesAtivas.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Nenhuma notificação!";
                lbl.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl);
            }
            else
            {
                foreach (var notif in notificacoesAtivas)
                {
                    AdicionarPainelNotificacao(notif, flowLayoutPanel1, true, false);
                }
            }

            if (notificacoesExcluidas.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Nenhuma notificação excluída!";
                lbl.AutoSize = true;
                flowLayoutPanelLixeira.Controls.Add(lbl);
            }
            else
            {
                foreach (var notif in notificacoesExcluidas)
                {
                    AdicionarPainelNotificacao(notif, flowLayoutPanelLixeira, false, true);
                }
            }
        }

        /// <summary>
        /// Adiciona um painel de notificação ao FlowLayoutPanel de destino.
        /// Se mostrarLixeira for true, o painel terá o ícone da lixeira; senão, não terá.
        /// Se mostrarRestaurar for true, mostra o botão de restaurar.
        /// </summary>
        private void AdicionarPainelNotificacao(Emprestimo notif, FlowLayoutPanel destino, bool mostrarLixeira, bool mostrarRestaurar)
        {
            Panel panel = new Panel();
            panel.Width = 500;
            panel.Height = 70;
            panel.Margin = new Padding(6);

            Label lblUsuario = new Label();
            lblUsuario.Text = $"Usuário: {notif.NomeUsuario}";
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(7, 8);
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular);

            Label lblLivro = new Label();
            lblLivro.Text = $"Livro: {notif.TituloLivro}";
            lblLivro.AutoSize = true;
            lblLivro.Location = new Point(7, 32);
            lblLivro.Font = new Font("Segoe UI", 11F, FontStyle.Regular);

            Label lblData = new Label();
            if (notif.Status == "DevolvidoNoPrazo")
                lblData.Text = $"Devolvido em: {notif.DataDevolvido?.ToString("dd/MM/yyyy")}";
            else
                lblData.Text = $"Devolução prevista: {notif.DataDevolucao:dd/MM/yyyy}";
            lblData.AutoSize = true;
            lblData.Location = new Point(180, 32);
            lblData.Font = new Font("Segoe UI", 11F, FontStyle.Regular);

            // customização visual por status
            if (notif.Status == "Atrasado")
            {
                panel.BackColor = Color.FromArgb(255, 220, 220); // vermelho claro
                lblUsuario.ForeColor = Color.Red;
                lblUsuario.Font = new Font(lblUsuario.Font, FontStyle.Bold);
            }
            else if (notif.Status == "DevolvidoNoPrazo")
            {
                panel.BackColor = Color.FromArgb(220, 255, 220); // verde claro
                lblUsuario.ForeColor = Color.DarkGreen;
                lblUsuario.Font = new Font(lblUsuario.Font, FontStyle.Italic);
            }
            else if (notif.Status == "EmAndamento")
            {
                panel.BackColor = Color.FromArgb(255, 255, 200); // amarelo claro
                lblUsuario.ForeColor = Color.DarkGoldenrod;
                lblUsuario.Font = new Font(lblUsuario.Font, FontStyle.Regular | FontStyle.Bold);
            }

            panel.Controls.Add(lblUsuario);
            panel.Controls.Add(lblLivro);
            panel.Controls.Add(lblData);

            if (mostrarLixeira)
            {
                PictureBox picLixeira = new PictureBox();
                picLixeira.Image = Properties.Resources.lixeira;
                picLixeira.SizeMode = PictureBoxSizeMode.Zoom;
                picLixeira.Width = 24;
                picLixeira.Height = 24;
                picLixeira.Location = new Point(panel.Width - 30, 8);
                picLixeira.Cursor = Cursors.Hand;

                picLixeira.Click += (s, ev) =>
                {
                    var resultado = MessageBox.Show(
                        "Deseja realmente excluir esta notificação?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (resultado == DialogResult.Yes)
                    {
                        // Marca como excluída no banco
                        MarcarNotificacaoComoExcluida(notif.Id, true);

                        // Atualiza a tela
                        CarregarTodasNotificacoes();
                    }
                };

                panel.Controls.Add(picLixeira);
            }

            if (mostrarRestaurar)
            {
                Button btnRestaurar = new Button();
                btnRestaurar.Text = "Restaurar";
                btnRestaurar.Width = 85;
                btnRestaurar.Height = 30;
                btnRestaurar.Location = new Point(panel.Width - btnRestaurar.Width - 10, panel.Height - btnRestaurar.Height - 10);
                btnRestaurar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnRestaurar.BackColor = Color.White;
                btnRestaurar.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                btnRestaurar.Click += (s, ev) =>
                {
                    MarcarNotificacaoComoExcluida(notif.Id, false);
                    CarregarTodasNotificacoes();
                };
                panel.Controls.Add(btnRestaurar);
            }

            destino.Controls.Add(panel);
        }

        /// <summary>
        /// Marca/desmarca a notificação como excluída no banco de dados.
        /// </summary>
        private void MarcarNotificacaoComoExcluida(int idEmprestimo, bool excluir)
        {
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            string query = "UPDATE emprestimos SET notificacao_excluida = @excluida WHERE id = @id";
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@excluida", excluir ? 1 : 0);
                cmd.Parameters.AddWithValue("@id", idEmprestimo);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Busca as notificações ativas ou excluídas.
        /// </summary>
        private List<Emprestimo> BuscarNotificacoes(bool apenasExcluidas)
        {
            var lista = new List<Emprestimo>();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            string condicaoExcluida = apenasExcluidas ? "1" : "0";

            // Notificações de atraso
            string queryAtraso = $@"
                SELECT e.id, u.Nome, l.Titulo, e.data_devolucao, NULL as data_devolvido
                FROM usuarios u
                JOIN emprestimos e ON u.Id = e.id_usuario
                JOIN livros l ON e.id_livro = l.id
                WHERE e.data_devolvido IS NULL AND e.data_devolucao < CURDATE() AND IFNULL(e.notificacao_excluida, 0) = {condicaoExcluida}";

            // Notificações devolvidas no prazo
            string queryDevolvido = $@"
                SELECT e.id, u.Nome, l.Titulo, e.data_devolucao, e.data_devolvido
                FROM usuarios u
                JOIN emprestimos e ON u.Id = e.id_usuario
                JOIN livros l ON e.id_livro = l.id
                WHERE e.data_devolvido IS NOT NULL AND e.data_devolvido <= e.data_devolucao AND IFNULL(e.notificacao_excluida, 0) = {condicaoExcluida}";

            // Notificações em andamento e no prazo
            string queryAndamento = $@"
                SELECT e.id, u.Nome, l.Titulo, e.data_devolucao, NULL as data_devolvido
                FROM usuarios u
                JOIN emprestimos e ON u.Id = e.id_usuario
                JOIN livros l ON e.id_livro = l.id
                WHERE e.data_devolvido IS NULL AND e.data_devolucao >= CURDATE() AND IFNULL(e.notificacao_excluida, 0) = {condicaoExcluida}";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                // Atrasados
                using (MySqlCommand cmd = new MySqlCommand(queryAtraso, conexao))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Emprestimo
                        {
                            Id = reader.GetInt32("id"),
                            NomeUsuario = reader.GetString("Nome"),
                            TituloLivro = reader.GetString("Titulo"),
                            DataDevolucao = reader.GetDateTime("data_devolucao"),
                            Status = "Atrasado"
                        });
                    }
                }

                // Devolvidos no prazo
                using (MySqlCommand cmd = new MySqlCommand(queryDevolvido, conexao))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Emprestimo
                        {
                            Id = reader.GetInt32("id"),
                            NomeUsuario = reader.GetString("Nome"),
                            TituloLivro = reader.GetString("Titulo"),
                            DataDevolucao = reader.GetDateTime("data_devolucao"),
                            DataDevolvido = reader.GetDateTime("data_devolvido"),
                            Status = "DevolvidoNoPrazo"
                        });
                    }
                }

                // Em andamento no prazo
                using (MySqlCommand cmd = new MySqlCommand(queryAndamento, conexao))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Emprestimo
                        {
                            Id = reader.GetInt32("id"),
                            NomeUsuario = reader.GetString("Nome"),
                            TituloLivro = reader.GetString("Titulo"),
                            DataDevolucao = reader.GetDateTime("data_devolucao"),
                            Status = "EmAndamento"
                        });
                    }
                }
            }
            return lista;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelLixeira.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelLixeira.Hide();
        }
    }

}


