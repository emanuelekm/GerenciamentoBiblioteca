using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciamentoBiblioteca
{
    public partial class FormLogin : Form
    {
        private MySqlConnection conexao;

        public FormLogin()
        {
            InitializeComponent();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);

            panelRedefinirSenha.Hide();
            panelLogin.Show();
            panelCadastro.Hide();

            AtualizarRequisitosSenha("");
        }

        private void FormLogin_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CenterPanel();
        }

        private void CenterPanel()
        {
 
            panelCadastro.Left = (this.ClientSize.Width - panelCadastro.Width) / 2;
            panelCadastro.Top = (this.ClientSize.Height - panelCadastro.Height) / 2;

            panelLogin.Left = this.ClientSize.Width / 2;
            panelLogin.Width = this.ClientSize.Width / 2;
            panelLogin.Height = this.ClientSize.Height;
            panelLogin.Top = 0;

            panelCadastro.Left = this.ClientSize.Width / 2;
            panelCadastro.Width = this.ClientSize.Width / 2;
            panelCadastro.Height = this.ClientSize.Height;
            panelCadastro.Top = 0;

            panelRedefinirSenha.Left = this.ClientSize.Width / 2;
            panelRedefinirSenha.Width = this.ClientSize.Width / 2;
            panelRedefinirSenha.Height = this.ClientSize.Height;
            panelRedefinirSenha.Top = 0;

            CentralizarPainelInterno();

        }

        private void CentralizarPainelInterno()
        {
            panelInterno.Left = (panelLogin.Width - panelInterno.Width) / 2;
            panelInterno.Top = (panelLogin.Height - panelInterno.Height) / 2;

            panelInternoSenha.Left = (panelLogin.Width - panelInternoSenha.Width) / 2;
            panelInternoSenha.Top = (panelLogin.Height - panelInternoSenha.Height) / 2;

            panelInternoCadastro.Left = (panelLogin.Width - panelInternoCadastro.Width) / 2;
            panelInternoCadastro.Top = (panelLogin.Height - panelInternoCadastro.Height) / 2;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = true;
            picOlho.Image = Properties.Resources.olho_fechado;

            textBoxSenhaCadastro.UseSystemPasswordChar = true;
            picOlhoCadastro.Image = Properties.Resources.olho_fechado;

            textBoxConfirmarSenha.UseSystemPasswordChar = true;
            picOlhoConfirmar.Image = Properties.Resources.olho_fechado;

            textBoxNovaSenha.UseSystemPasswordChar = true;
            picOlhoNovaSenha.Image = Properties.Resources.olho_fechado;

            textBoxConfirmarNovaSenha.UseSystemPasswordChar = true;
            picOlhoConfirmarNovaSenha.Image = Properties.Resources.olho_fechado;

            if (ExisteAdministrador())
            {
                radioButtonAdmin.Visible = false;
                radioButtonLeitor.Checked = true;
                radioButtonLeitor.Text = "Leitor ";
            }
            else
            {
                radioButtonAdmin.Visible = true;
                radioButtonLeitor.Visible = true;
            }
        }

        //Botão de login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxUser.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                conexao.Open();
                string query = "SELECT * FROM usuarios WHERE email = @email";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaHashArmazenada = reader["senha"].ToString().Trim();
                        string tipo = reader["tipo_usuario"].ToString();
                        //string nome = reader["nome"].ToString();

                        //MessageBox.Show($"Senha digitada: {senha}\nHash armazenado:\n{senhaHashArmazenada}");

                        if (PasswordHasher.Verify(senha, senhaHashArmazenada))
                        {
                            MessageBox.Show("Login bem-sucedido!");

                            Sessao.Id = Convert.ToInt32(reader["id"]);
                            Sessao.Nome = reader["nome"].ToString();
                            Sessao.Email = reader["email"].ToString();
                            Sessao.TipoUsuario = reader["tipo_usuario"].ToString();
                            Sessao.DataNascimento = Convert.ToDateTime(reader["data_nascimento"]);
                            Sessao.Telefone = reader["telefone"].ToString();

                            Form formPrincipal;
                            if (tipo == "Administrador")
                            {
                                formPrincipal = new FormPrincipalAdmin();
                            }
                            else if (tipo == "Leitor")
                            {
                                formPrincipal = new FormPrincipalLeitor();
                            }
                            else
                            {
                                MessageBox.Show("Tipo de usuário desconhecido.");
                                return;
                            }

                            this.Hide();
                            formPrincipal.Show();
                            formPrincipal.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
                //
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        //Redefinir senha
        private void linkLabelSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelCadastro.Hide();
            panelLogin.Hide();
            panelRedefinirSenha.Show();
        }

        //Criar Cadastro
        private void linkLabelMensagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelCadastro.Show();
            panelLogin.Hide();
            panelRedefinirSenha.Hide();
        }

        //Botão cadastro
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxUsuario.Text;
            string senha = textBoxSenhaCadastro.Text;
            string confirmacao = textBoxConfirmarSenha.Text;
            DateTime data_nascimento = dtpNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string tipo_usuario = radioButtonLeitor.Checked ? "Leitor" : radioButtonAdmin.Checked ? "Administrador" : "Não selecionado";

            if (string.IsNullOrEmpty(nome) || (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmacao) || string.IsNullOrWhiteSpace(telefone) || tipo_usuario == "Não selecionado"))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senha != confirmacao)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarSenhaSegura(senha, out string erroSenha))
            {
                MessageBox.Show(erroSenha, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conexao.Open();
                string query = "INSERT INTO usuarios (nome,email,senha,data_nascimento,telefone,tipo_usuario) VALUES (@nome,@email,@senha,@data_nascimento,@telefone,@tipo_usuario)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                string senhaHasheada = PasswordHasher.Hash(senha);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senhaHasheada);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@tipo_usuario", tipo_usuario);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                panelCadastro.Hide();
                panelLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private bool ExisteAdministrador()
        {
            try
            {
                conexao.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE tipo_usuario = 'Administrador'";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                return total > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar administradores: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void LimparCampos()
        {
            textBoxUsuario.Clear();
            textBoxSenhaCadastro.Clear();
            textBoxConfirmarSenha.Clear();
        }

        //Botão redefinir senha
        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            string email = textBoxUsuarioRedefinir.Text;
            string novaSenha = textBoxNovaSenha.Text;
            string confirmarSenha = textBoxConfirmarNovaSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarSenhaSegura(novaSenha, out string erroSenha))
            {
                MessageBox.Show(erroSenha, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conexao.Open();
                string query = "UPDATE usuarios SET senha = @novaSenha WHERE email = @email";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                string senhaHasheada = PasswordHasher.Hash(novaSenha);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@novaSenha", senhaHasheada);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    panelRedefinirSenha.Hide();
                    panelLogin.Show();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao redefinir senha: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        // VALIDAÇÃO DE SENHA FORTE
        private bool ValidarSenhaSegura(string senha, out string mensagemErro)
        {
            mensagemErro = "";

            if (senha.Length < 8 || senha.Length > 15)
            {
                mensagemErro = "A senha deve ter entre 8 e 15 caracteres.";
                return false;
            }

            if (!Regex.IsMatch(senha, @"[A-Z]"))
            {
                mensagemErro = "A senha deve conter ao menos uma letra maiúscula.";
                return false;
            }

            if (!Regex.IsMatch(senha, @"[a-z]"))
            {
                mensagemErro = "A senha deve conter ao menos uma letra minúscula.";
                return false;
            }

            if (!Regex.IsMatch(senha, @"[0-9]"))
            {
                mensagemErro = "A senha deve conter ao menos um número.";
                return false;
            }

            if (!Regex.IsMatch(senha, @"[\W_]"))
            {
                mensagemErro = "A senha deve conter ao menos um caractere especial (ex: !, @, #, $, %, &, *).";
                return false;
            }

            return true;
        }

        private void textBoxSenhaCadastro_TextChanged_1(object sender, EventArgs e)
        {
            AtualizarRequisitosSenha(textBoxSenhaCadastro.Text);
        }

        private void AtualizarRequisitosSenha(string senha)
        {
            AtualizarRequisito(labelRequisitoTamanho, senha.Length >= 8 && senha.Length <= 15, "8 a 15 caracteres");
            AtualizarRequisito(labelRequisitoMaiuscula, Regex.IsMatch(senha, @"[A-Z]"), "Letra maiúscula (A-Z)");
            AtualizarRequisito(labelRequisitoMinuscula, Regex.IsMatch(senha, @"[a-z]"), "Letra minúscula (a-z)");
            AtualizarRequisito(labelRequisitoNumero, Regex.IsMatch(senha, @"[0-9]"), "Número (0-9)");
            AtualizarRequisito(labelRequisitoEspecial, Regex.IsMatch(senha, @"[\W_]"), "Caractere especial (!@#...)");
        }

        private void AtualizarRequisito(Label label, bool valido, string texto)
        {
            label.Text = valido ? $"✔ {texto}" : $"✖ {texto}";
            label.ForeColor = valido ? Color.Green : Color.Red;
        }

        //Imagem para voltar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelCadastro.Hide();
            panelLogin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelRedefinirSenha.Hide();
            panelLogin.Show();
        }
        // ícone olho (ocultar)

        bool senhaVisivel = false;

        bool senhaVisivelCadastro = false;
        bool senhaVisivelConfirmar = false;

        bool senhaNovaVisivel = false;
        bool senhaNovaVisivelConfirmar = false;

        
        private void picOlho_Click(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            textBoxSenha.UseSystemPasswordChar = !senhaVisivel;

            picOlho.Image = senhaVisivel
                ? Properties.Resources.olho_aberto
                : Properties.Resources.olho_fechado;

            textBoxSenha.Focus();
            textBoxSenha.SelectionStart = textBoxSenha.Text.Length;
        }

        private void picOlhoCadastro_Click(object sender, EventArgs e)
        {
            senhaVisivelCadastro = !senhaVisivelCadastro;

            textBoxSenhaCadastro.UseSystemPasswordChar = !senhaVisivelCadastro;

            picOlhoCadastro.Image = senhaVisivelCadastro
                ? Properties.Resources.olho_aberto
                : Properties.Resources.olho_fechado;

            textBoxSenhaCadastro.Focus();
            textBoxSenhaCadastro.SelectionStart = textBoxSenhaCadastro.Text.Length;
        }

        private void picOlhoConfirmar_Click(object sender, EventArgs e)
        {
            senhaVisivelConfirmar = !senhaVisivelConfirmar;

            textBoxConfirmarSenha.UseSystemPasswordChar = !senhaVisivelConfirmar;

            picOlhoConfirmar.Image = senhaVisivelConfirmar
                ? Properties.Resources.olho_aberto
                : Properties.Resources.olho_fechado;

            textBoxConfirmarSenha.Focus();
            textBoxConfirmarSenha.SelectionStart = textBoxConfirmarSenha.Text.Length;
        }

        private void AtualizarRequisitosSenha(string senha, Label labelTamanho, Label labelMaiuscula, Label labelMinuscula, Label labelNumero, Label labelEspecial)
        {
            AtualizarRequisito(labelTamanho, senha.Length >= 8 && senha.Length <= 15, "8 a 15 caracteres");
            AtualizarRequisito(labelMaiuscula, Regex.IsMatch(senha, @"[A-Z]"), "Letra maiúscula (A-Z)");
            AtualizarRequisito(labelMinuscula, Regex.IsMatch(senha, @"[a-z]"), "Letra minúscula (a-z)");
            AtualizarRequisito(labelNumero, Regex.IsMatch(senha, @"[0-9]"), "Número (0-9)");
            AtualizarRequisito(labelEspecial, Regex.IsMatch(senha, @"[\W_]"), "Caractere especial (!@#...)");
        }

        private void textBoxNovaSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarRequisitosSenha(
            textBoxNovaSenha.Text,
            labelRequisitoTamanhoRedefinir,
            labelRequisitoMaiusculaRedefinir,
            labelRequisitoMinusculaRedefinir,
            labelRequisitoNumeroRedefinir,
            labelRequisitoEspecialRedefinir
            );
        }
        
        private void picOlhoNovaSenha_Click(object sender, EventArgs e)
        {
            senhaNovaVisivel = !senhaNovaVisivel;

            textBoxNovaSenha.UseSystemPasswordChar = !senhaNovaVisivel;

            picOlhoNovaSenha.Image = senhaNovaVisivel
                ? Properties.Resources.olho_aberto
                : Properties.Resources.olho_fechado;

            textBoxNovaSenha.Focus();
            textBoxNovaSenha.SelectionStart = textBoxNovaSenha.Text.Length;
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            senhaNovaVisivelConfirmar = !senhaNovaVisivelConfirmar;

            textBoxConfirmarNovaSenha.UseSystemPasswordChar = !senhaNovaVisivelConfirmar;

            picOlhoConfirmarNovaSenha.Image = senhaNovaVisivelConfirmar
                ? Properties.Resources.olho_aberto
                : Properties.Resources.olho_fechado;

            textBoxConfirmarNovaSenha.Focus();
            textBoxConfirmarNovaSenha.SelectionStart = textBoxConfirmarNovaSenha.Text.Length;
        }

        
    }
}
