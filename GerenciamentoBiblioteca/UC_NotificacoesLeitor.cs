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
            this.Load += UC_NotificacoesLeitor_Load;
        }

        private void UC_NotificacoesLeitor_Load(object sender, EventArgs e)
        {
            flowNotificacoes.FlowDirection = FlowDirection.TopDown;
            flowNotificacoes.WrapContents = false;

            CarregarNotificacoesLeitor();
        }

        private void CarregarNotificacoesLeitor()
        {
            flowNotificacoes.Controls.Clear();

            var notificacoes = BuscarTodosEmprestimosPorUsuario(Sessao.Id);

            if (notificacoes.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Nenhuma notificação!";
                lbl.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
                lbl.ForeColor = Color.Gray;
                lbl.AutoSize = true;
                flowNotificacoes.Controls.Add(lbl);
            }
            else
            {
                foreach (var notif in notificacoes)
                {
                    AdicionarPainelNotificacao(notif, flowNotificacoes);
                }
            }
        }
        public List<Emprestimo> BuscarTodosEmprestimosPorUsuario(int idLeitor)
        {
            var lista = new List<Emprestimo>();

            string query = @"
        SELECT 
            e.id, 
            u.nome AS nome_usuario, 
            l.titulo AS titulo_livro, 
            e.data_emprestimo, 
            e.data_devolucao, 
            e.data_devolvido, 
            e.status
        FROM emprestimos e
        JOIN livros l ON l.id = e.id_livro
        JOIN usuarios u ON u.id = e.id_usuario
        WHERE e.id_usuario = @idLeitor
        ORDER BY e.data_emprestimo DESC;
    ";

            using (var conexao = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
            {
                conexao.Open();
                using (var cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@idLeitor", idLeitor);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var emprestimo = new Emprestimo
                            {
                                Id = reader.GetInt32("id"),
                                NomeUsuario = reader.GetString("nome_usuario"),
                                TituloLivro = reader.GetString("titulo_livro"),
                                DataEmprestimo = reader.GetDateTime("data_emprestimo"),
                                DataDevolucao = reader.IsDBNull(reader.GetOrdinal("data_devolucao"))
                                    ? (DateTime?)null : reader.GetDateTime("data_devolucao"),
                                DataDevolvido = reader.IsDBNull(reader.GetOrdinal("data_devolvido"))
                                    ? (DateTime?)null : reader.GetDateTime("data_devolvido"),
                                Status = reader.IsDBNull(reader.GetOrdinal("status"))
                                    ? null : reader.GetString("status")
                            };
                            lista.Add(emprestimo);
                        }
                    }
                }
            }
            return lista;
        }
        
        private void AdicionarPainelNotificacao(Emprestimo notif, FlowLayoutPanel painel)
        {
            Panel panel = new Panel();
            panel.Width = 350;   // Ajuste conforme o layout
            panel.Height = 75;
            panel.Margin = new Padding(8);
            panel.BorderStyle = BorderStyle.FixedSingle;

            // Defina a cor de fundo do painel conforme o status do empréstimo
            if (notif.DataDevolvido.HasValue)
            {
                panel.BackColor = Color.LightGreen; // Devolvido: verde
            }
            else if (notif.DataDevolucao.HasValue && notif.DataDevolucao.Value >= DateTime.Now)
            {
                panel.BackColor = Color.LightYellow; // Em andamento: amarelo
            }
            else if (notif.DataDevolucao.HasValue && notif.DataDevolucao.Value < DateTime.Now)
            {
                panel.BackColor = Color.LightCoral; // Em atraso: vermelho (opcional)
            }
            else
            {
                panel.BackColor = Color.WhiteSmoke; // Outros casos
            }

            // Adicione as informações do empréstimo
            Label lblInfo = new Label();
            lblInfo.Text = $"Livro: {notif.TituloLivro}\nData empréstimo: {notif.DataEmprestimo:dd/MM/yyyy}\n" +
                           $"Devolver até: {notif.DataDevolucao?.ToString("dd/MM/yyyy") ?? "-"}\n" +
                           $"Status: {(notif.DataDevolvido.HasValue ? "Devolvido" : (notif.DataDevolucao.HasValue && notif.DataDevolucao.Value < DateTime.Now ? "Atrasado" : "Em andamento"))}";
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;

            panel.Controls.Add(lblInfo);
            painel.Controls.Add(panel);
        
        }
    }
}

