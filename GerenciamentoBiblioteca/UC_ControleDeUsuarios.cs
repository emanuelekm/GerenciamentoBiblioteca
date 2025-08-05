using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GerenciamentoBiblioteca
{
    public partial class UC_ControleDeUsuarios : UserControl
    {
        private MySqlConnection conexao;
        public UC_ControleDeUsuarios()
        {
            InitializeComponent();
            string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            conexao = new MySqlConnection(conexaoString);
            this.Load += UCControleDeUsuarios_Load;
        }

        public class TabelaUsuarios
        {
            public List<Usuario> BuscarUsuarios(string searchTerm)
            {
                List<Usuario> usuarios = new List<Usuario>();

                string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
                // conexao = new MySqlConnection(conexaoString);
                using (MySqlConnection conn = new MySqlConnection(conexaoString))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT id, nome, email, data_nascimento, telefone, tipo_usuario " +
                                       "FROM usuarios WHERE nome LIKE @searchTerm OR email LIKE @searchTerm";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    usuarios.Add(new Usuario
                                    {
                                        Id = reader.GetInt32("id"),
                                        Nome = reader.GetString("nome"),
                                        Email = reader.GetString("email"),
                                        Data_nascimento = reader.GetDateTime("data_nascimento"),
                                        Telefone = reader.GetString("telefone"),
                                        Tipo_usuario = reader.GetString("tipo_usuario"),
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }

                return usuarios;
            }
        }

        private void CarregarUsuarios()
        {
            try
            {
                TabelaUsuarios db = new TabelaUsuarios();
                List<Usuario> usuarios = db.BuscarUsuarios("");

                dataGridViewUsuarios.DataSource = usuarios;

                dataGridViewUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewUsuarios.Columns.Contains("Senha"))
                {
                    dataGridViewUsuarios.Columns["Senha"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
        }

        private void UCControleDeUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormUsuario formNovoUsuario = new FormUsuario(conexao);

            if (formNovoUsuario.ShowDialog() == DialogResult.OK)
            {
                CarregarUsuarios();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewUsuarios.SelectedRows[0];

                Usuario usuario = new Usuario
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Nome = row.Cells["Nome"].Value.ToString(),
                    Email = row.Cells["Email"].Value.ToString(),
                    Data_nascimento = Convert.ToDateTime(row.Cells["Data_nascimento"].Value),
                    Telefone = row.Cells["Telefone"].Value.ToString(),
                    Tipo_usuario = row.Cells["Tipo_usuario"].Value.ToString(),
                };

                FormUsuario form = new FormUsuario(conexao, usuario);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CarregarUsuarios();
                }  
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja remover este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    int idUsuario = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);

                    string query = "DELETE FROM usuarios WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", idUsuario);

                        try
                        {
                            conexao.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário removido com sucesso.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao remover usuário: " + ex.Message);
                        }
                        finally
                        {
                            conexao.Close();
                            CarregarUsuarios(); 
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para remover.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_InicioAdmin uC_InicioAdmin = new UC_InicioAdmin();

            FormPrincipalAdmin form = this.FindForm() as FormPrincipalAdmin;
            if (form != null)
            {
                form.CarregarTela(uC_InicioAdmin);
            }
        }
    }
    
}
