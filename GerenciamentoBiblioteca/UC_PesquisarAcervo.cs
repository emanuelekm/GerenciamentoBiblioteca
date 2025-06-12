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
    public partial class UC_PesquisarAcervo : UserControl
    {
        private MySqlConnection conexao;
        public UC_PesquisarAcervo()
        {
            InitializeComponent();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);
            this.Load += UserControlPesquisarAcervoAdmin_Load;

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


        private void UserControlPesquisarAcervoAdmin_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            try
            {
                AcervoBiblioteca db = new AcervoBiblioteca();
                List<Livro> livros = db.BuscarLivros("");

                dataGridViewPesquisar.DataSource = livros;

                dataGridViewPesquisar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridViewPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewPesquisar.Columns.Contains("Id"))
                {
                    dataGridViewPesquisar.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }

        private void textBoxPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            string searchTerm = textBoxPesquisar.Text.ToLower();

            AcervoBiblioteca db = new AcervoBiblioteca();
            List<Livro> livrosFiltrados = db.BuscarLivros(searchTerm);

            dataGridViewPesquisar.DataSource = livrosFiltrados;

            dataGridViewPesquisar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewPesquisar.Columns.Contains("Id"))
            {
                dataGridViewPesquisar.Columns["Id"].Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxPesquisar.Text.Trim().ToLower();

            AcervoBiblioteca db = new AcervoBiblioteca();
            List<Livro> livrosFiltrados = db.BuscarLivros(searchTerm);

            if (livrosFiltrados.Count == 0)
            {
                MessageBox.Show("Nenhum exemplar encontrado com o termo informado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPesquisar.Clear();
            }
            else
            {
                dataGridViewPesquisar.DataSource = livrosFiltrados;
                dataGridViewPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridViewPesquisar.Columns.Contains("Id"))
                {
                    dataGridViewPesquisar.Columns["Id"].Visible = false;
                }
            }
        }
    }
}
