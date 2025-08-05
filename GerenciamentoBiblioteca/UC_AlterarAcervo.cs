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
    public partial class UC_AlterarAcervo : UserControl
    {
        private MySqlConnection conexao;
        public UC_AlterarAcervo()
        {
            InitializeComponent();

            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);
            this.Load += UCAlterarAcervo_Load;
        }

        public class AcervoBiblioteca
        {
            public List<Livro> BuscarLivros(string searchTerm)
            {
                List<Livro> livros = new List<Livro>();

                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT id, titulo, autor, ano, genero, numero_paginas, qtd_exemplares, status, estado " +
                                       "FROM livros WHERE titulo LIKE @searchTerm OR autor LIKE @searchTerm";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    livros.Add(new Livro
                                    {
                                        Id = reader.GetInt32("id"),
                                        Titulo = reader.GetString("titulo"),
                                        Autor = reader.GetString("autor"),
                                        Ano = reader.GetInt32("ano"),
                                        Genero = reader.GetString("genero"),
                                        N_pagina = reader.GetInt32("numero_paginas"),
                                        Qtd_exemplares = reader.GetInt32("qtd_exemplares"),
                                        Status = reader.GetString("status"),
                                        Estado = reader.GetString("estado")
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

                return livros;
            }
        }

        private void UCAlterarAcervo_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            try
            {
                AcervoBiblioteca db = new AcervoBiblioteca();
                List<Livro> livros = db.BuscarLivros("");

                dataGridViewModificarAcervo.DataSource = livros;

                dataGridViewModificarAcervo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridViewModificarAcervo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewModificarAcervo.Columns.Contains("Id"))
                {
                    dataGridViewModificarAcervo.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }

        private void pictureBoxLupa_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxPesquisarColecao.Text.Trim().ToLower();

            AcervoBiblioteca db = new AcervoBiblioteca();
            List<Livro> livrosFiltrados = db.BuscarLivros(searchTerm);

            if (livrosFiltrados.Count == 0)
            {
                MessageBox.Show("Nenhum exemplar encontrado com o termo informado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPesquisarColecao.Clear();
            }
            else
            {
                dataGridViewModificarAcervo.DataSource = livrosFiltrados;
                dataGridViewModificarAcervo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewModificarAcervo.Columns.Contains("Id"))
                {
                    dataGridViewModificarAcervo.Columns["Id"].Visible = false;
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormLivro formNovoLivro = new FormLivro(conexao);

            if (formNovoLivro.ShowDialog() == DialogResult.OK)
            {
                CarregarLivros(); 
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewModificarAcervo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewModificarAcervo.SelectedRows[0];

                Livro livro = new Livro
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Titulo = row.Cells["Titulo"].Value.ToString(),
                    Autor = row.Cells["Autor"].Value.ToString(),
                    Ano = Convert.ToInt32(row.Cells["Ano"].Value),
                    Genero = row.Cells["Genero"].Value.ToString(),
                    N_pagina = Convert.ToInt32(row.Cells["N_pagina"].Value),
                    Qtd_exemplares = Convert.ToInt32(row.Cells["Qtd_exemplares"].Value),
                    Status = row.Cells["Status"].Value.ToString(),
                    Estado = row.Cells["Estado"].Value.ToString()
                };

                FormLivro form = new FormLivro(conexao, livro);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CarregarLivros();
                }
            }
            else
            {
                MessageBox.Show("Selecione um livro para editar.");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewModificarAcervo.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Tem certeza que deseja remover este título?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    int idLivro = Convert.ToInt32(dataGridViewModificarAcervo.SelectedRows[0].Cells["Id"].Value);

                    string query = "DELETE FROM livros WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", idLivro);

                        try
                        {
                            conexao.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Título removido com sucesso.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao remover título: " + ex.Message);
                        }
                        finally
                        {
                            conexao.Close();
                            CarregarLivros(); // Atualiza a lista
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um título para remover.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPesquisarColecao.Clear();
            CarregarLivros();
        }

        private void pictureBoxVoltar_Click(object sender, EventArgs e)
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
