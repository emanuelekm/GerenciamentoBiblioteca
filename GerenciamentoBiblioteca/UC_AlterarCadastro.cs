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
    public partial class UC_AlterarCadastro : UserControl
    {
        public UC_AlterarCadastro()
        {
            InitializeComponent();
        }

        private void UCAlterarCadastroAdmin_Load(object sender, EventArgs e)
        {
            //labelNome.Text = Sessao.Nome;
            //labelEmail.Text = Sessao.Email;
            //labelTelefone.Text = Sessao.Telefone;
            labelTipo.Text = Sessao.TipoUsuario;
            //labelDataNascimento.Text = Sessao.DataNascimento.ToShortDateString();

            txtNome.Text = Sessao.Nome;
            txtEmail.Text = Sessao.Email;
            txtTelefone.Text = Sessao.Telefone;
            dtpData.Value = Sessao.DataNascimento;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string novoNome = txtNome.Text.Trim();
            string novoEmail = txtEmail.Text.Trim();
            string novoTelefone = txtTelefone.Text.Trim();
            DateTime novaDataNascimento = dtpData.Value;

            using (MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd=;database=gerenciamentobiblioteca"))
            {
                try
                {
                    conexao.Open();
                    string sql = "UPDATE usuarios SET nome=@nome, email=@email, telefone=@telefone, data_nascimento=@dataNascimento WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", novoNome);
                        cmd.Parameters.AddWithValue("@email", novoEmail);
                        cmd.Parameters.AddWithValue("@telefone", novoTelefone);
                        cmd.Parameters.AddWithValue("@dataNascimento", novaDataNascimento);
                        cmd.Parameters.AddWithValue("@id", Sessao.Id);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualiza os dados na Sessao
                            Sessao.Nome = novoNome;
                            Sessao.Email = novoEmail;
                            Sessao.Telefone = novoTelefone;
                            Sessao.DataNascimento = novaDataNascimento;
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma alteração feita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
