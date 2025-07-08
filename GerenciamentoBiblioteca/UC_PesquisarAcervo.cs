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
            this.Load += UC_PesquisarAcervo_Load;

        }

        public class AcervoBiblioteca
        {
            public List<Livro> BuscarLivros(string tituloOuAutor, string genero = "", string status = "", int? ano = null)
            {
                List<Livro> livros = new List<Livro>();

                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;"))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT id, titulo, autor, ano, genero, numero_paginas, qtd_exemplares, status, estado " +
                                       "FROM livros WHERE (titulo LIKE @search OR autor LIKE @search)";

                        if (!string.IsNullOrEmpty(genero))
                            query += " AND genero = @genero";

                        if (!string.IsNullOrEmpty(status))
                            query += " AND status = @status";

                        if (ano.HasValue)
                            query += " AND ano = @ano";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + tituloOuAutor + "%");

                            if (!string.IsNullOrEmpty(genero))
                                cmd.Parameters.AddWithValue("@genero", genero);

                            if (!string.IsNullOrEmpty(status))
                                cmd.Parameters.AddWithValue("@status", status);

                            if (ano.HasValue)
                                cmd.Parameters.AddWithValue("@ano", ano.Value);

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
            RealizarPesquisa();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RealizarPesquisa();

            //textBoxPesquisar.Clear();
            //comboBoxGenero.SelectedIndex = -1;
            //comboBoxStatus.SelectedIndex = -1;
            //textBoxAno.Clear();
        }

        private void RealizarPesquisa()
        {
            string termo = textBoxPesquisar.Text.Trim();
            string genero = comboBoxGenero.SelectedItem?.ToString() ?? "";
            string status = comboBoxStatus.SelectedItem?.ToString() ?? "";
            //int? ano = string.IsNullOrEmpty(textBoxAno.Text.Trim()) ? (int?)null : int.Parse(textBoxAno.Text);

            AcervoBiblioteca db = new AcervoBiblioteca();
            List<Livro> livrosFiltrados = db.BuscarLivros(termo, genero, status);

            dataGridViewPesquisar.DataSource = livrosFiltrados;
            dataGridViewPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewPesquisar.Columns.Contains("Id"))
            {
                dataGridViewPesquisar.Columns["Id"].Visible = false;
            }
        }

        private void UC_PesquisarAcervo_Load(object sender, EventArgs e)
        {
            CarregarLivros();

            comboBoxGenero.Items.AddRange(new string[] { "Aventura",
                "Autoajuda",
                "Biografia / Autobiografia",
                "Ciência",
                "Distopia / Utopia",
                "Drama",
                "Educação / Didáticos",
                "Fantasia",
                "Ficção científica",
                "Filosofia",
                "História",
                "Histórico",
                "Mistério / Suspense",
                "Negócios / Finanças",
                "Religião / Espiritualidade",
                "Romance",
                "Saúde / Bem-estar",
                "Terror / Horror",
                "Thriller",
                "Viagem / Turismo" 
            });

            //comboBoxStatus.Items.AddRange(new string[] { "Bom", "Regular", "Ruim" });

            comboBoxGenero.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
        }
    }
}
