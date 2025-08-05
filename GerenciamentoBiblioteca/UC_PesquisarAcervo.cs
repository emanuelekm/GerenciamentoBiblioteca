using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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

namespace GerenciamentoBiblioteca
{
    public partial class UC_PesquisarAcervo : UserControl
    {
        private MySqlConnection conexao;
        public UC_PesquisarAcervo()
        {
            InitializeComponent();
            string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            conexao = new MySqlConnection(conexaoString);

            this.Load += UC_PesquisarAcervo_Load;

        }

        public class AcervoBiblioteca
        {
            public List<Livro> BuscarLivros(string tituloOuAutor, string genero = "", string status = "", string estado = "")
            {
                List<Livro> livros = new List<Livro>();

                string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
                //conexao = new MySqlConnection(conexaoString);
                using (MySqlConnection conn = new MySqlConnection(conexaoString))
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

                        //if (ano.HasValue)
                            //query += " AND ano = @ano";

                        if (!string.IsNullOrEmpty(estado))
                            query += " AND estado = @estado";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + tituloOuAutor + "%");

                            if (!string.IsNullOrEmpty(genero))
                                cmd.Parameters.AddWithValue("@genero", genero);

                            if (!string.IsNullOrEmpty(status))
                                cmd.Parameters.AddWithValue("@status", status);

                            //if (ano.HasValue)
                                //cmd.Parameters.AddWithValue("@ano", ano.Value);

                            if (!string.IsNullOrEmpty(estado))
                                cmd.Parameters.AddWithValue("@estado", estado);

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
            string titulo = textBoxPesquisar.Text.Trim();
            //string autor = txtAutor.Text.Trim();
            string genero = comboBoxGenero.SelectedItem?.ToString();
            string estado = comboBoxEstado.SelectedItem?.ToString();
            string status = comboBoxStatus.SelectedItem?.ToString();

            string conexaoString = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            conexao = new MySqlConnection(conexaoString);
            using (MySqlConnection conn = new MySqlConnection(conexaoString))
            {
                conn.Open();
                StringBuilder query = new StringBuilder("SELECT * FROM livros WHERE 1=1");

                // Adiciona filtros dinamicamente
                if (!string.IsNullOrEmpty(titulo))
                    query.Append(" AND titulo LIKE @titulo");

                if (!string.IsNullOrEmpty(genero))
                    query.Append(" AND genero = @genero");

                if (!string.IsNullOrEmpty(estado))
                    query.Append(" AND estado = @estado");

                if (!string.IsNullOrEmpty(status))
                    query.Append(" AND status = @status");

                using (MySqlCommand cmd = new MySqlCommand(query.ToString(), conn))
                {
                    // Adiciona parâmetros
                    if (!string.IsNullOrEmpty(titulo))
                        cmd.Parameters.AddWithValue("@titulo", $"%{titulo}%");

                    if (!string.IsNullOrEmpty(genero))
                        cmd.Parameters.AddWithValue("@genero", genero);

                    if (!string.IsNullOrEmpty(estado))
                        cmd.Parameters.AddWithValue("@estado", estado);

                    if (!string.IsNullOrEmpty(status))
                        cmd.Parameters.AddWithValue("@status", status);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewPesquisar.DataSource = dt;
                }
            }
        }

        private void RealizarPesquisa()
        {
            string termo = textBoxPesquisar.Text.Trim();
            string genero = comboBoxGenero.SelectedItem?.ToString() ?? "";
            string estado = comboBoxEstado.SelectedItem?.ToString() ?? "";
            string status = comboBoxStatus.SelectedItem?.ToString() ?? "";
            // int? ano = string.IsNullOrEmpty(textBoxAno.Text.Trim()) ? (int?)null : int.Parse(textBoxAno.Text);

            AcervoBiblioteca db = new AcervoBiblioteca();

            List<Livro> livrosFiltrados = db.BuscarLivros(termo, genero, status, estado);

            dataGridViewPesquisar.DataSource = livrosFiltrados;
            dataGridViewPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewPesquisar.Columns.Contains("Id"))
            {
                dataGridViewPesquisar.Columns["Id"].Visible = false;
            }
        }

        private void UC_PesquisarAcervo_Load(object sender, EventArgs e)
        { 
            comboBoxGenero.Items.Clear();
            comboBoxEstado.Items.Clear();
            comboBoxStatus.Items.Clear();

            comboBoxGenero.Items.AddRange(new string[] { "Aventura",
                "Autoajuda",
                "Biografia / Autobiografia",
                "Ciência",
                "Distopia / Utopia",
                "Drama",
                "Educação / Didáticos",
                "Fantasia",
                "Ficção",
                "Ficção científica",
                "Filosofia",
                "História",
                "Histórico",
                "Infantil",
                "Mistério / Suspense",
                "Negócios / Finanças",
                "Religião / Espiritualidade",
                "Romance",
                "Saúde / Bem-estar",
                "Satírico",
                "Terror / Horror",
                "Thriller",
                "Viagem / Turismo" 
            });

            if (comboBoxEstado.Items.Count == 0)
            {
                comboBoxEstado.Items.AddRange(new string[] { "Bom", "Regular", "Ruim" });
            }

            if (comboBoxStatus.Items.Count == 0)
            {
                comboBoxStatus.Items.AddRange(new string[] { "Disponível", "Indisponível" });
            }

            comboBoxGenero.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;

            CarregarLivros();
        }

        private void buttonLimparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisar.Clear();

            comboBoxGenero.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;

            CarregarLivros();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();

            if (Sessao.TipoUsuario == "Leitor" && currentForm is FormPrincipalLeitor leitorForm)
            {
                leitorForm.panelTelaInternaLeitor.Controls.Clear();
                leitorForm.panelTelaInternaLeitor.Controls.Add(new UC_InicioLeitor());
            }
            else if (Sessao.TipoUsuario == "Administrador" && currentForm is FormPrincipalAdmin adminForm)
            {
                adminForm.panelTelaInterna.Controls.Clear();
                adminForm.panelTelaInterna.Controls.Add(new UC_InicioAdmin());
            }
        }
    }
}
