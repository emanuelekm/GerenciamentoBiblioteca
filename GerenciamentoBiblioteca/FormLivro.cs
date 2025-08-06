using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace GerenciamentoBiblioteca
{
    public partial class FormLivro : Form
    {
        private MySqlConnection conexao;
        private Livro livroParaEditar = null;


        public FormLivro(MySqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;

            comboBoxStatusNovoLivro.Items.AddRange(new string[] { "Disponível", "Indisponível" });
            comboBoxEstadoNovoLivro.Items.AddRange(new string[] { "Bom", "Regular", "Ruim" });
            comboBoxGeneroNovoLivro.Items.AddRange(new string[]
            {
                "Aventura",
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
                "Infantil",
                "Mistério / Suspense",
                "Negócios / Finanças",
                "Religião / Espiritualidade",
                "Romance",
                "Saúde / Bem-estar",
                "Terror / Horror",
                "Thriller",
                "Viagem / Turismo"
            });


        }

        public FormLivro(MySqlConnection conexao, Livro livro) : this(conexao)
        {
            this.livroParaEditar = livro;

            textBoxTituloNovoLivro.Text = livro.Titulo;
            textBoxAutorNovoLivro.Text = livro.Autor;
            comboBoxGeneroNovoLivro.Text = livro.Genero;
            textBoxAnoNovoLivro.Text = livro.Ano.ToString();
            textBoxNpgNovoLivro.Text = livro.N_pagina.ToString();
            textBoxQtdNovoLivro.Text = livro.Qtd_exemplares.ToString();
            comboBoxStatusNovoLivro.Text = livro.Status;
            comboBoxEstadoNovoLivro.Text = livro.Estado;
        }
        private bool LivroJaExiste(string titulo, string autor, int ano, int? idIgnorar = null)
        {
            string query = "SELECT COUNT(*) FROM livros WHERE titulo = @titulo AND autor = @autor AND ano = @ano";

            if (idIgnorar.HasValue)
            {
                query += " AND id != @id";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@titulo", titulo.Trim());
                cmd.Parameters.AddWithValue("@autor", autor.Trim());
                cmd.Parameters.AddWithValue("@ano", ano);

                if (idIgnorar.HasValue)
                {
                    cmd.Parameters.AddWithValue("@id", idIgnorar.Value);
                }

                try
                {
                    conexao.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar duplicidade: " + ex.Message);
                    return true;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }



        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
            string titulo = textBoxTituloNovoLivro.Text.Trim();
            string autor = textBoxAutorNovoLivro.Text.Trim();
            string genero = comboBoxGeneroNovoLivro.Text.Trim();
            string status = comboBoxStatusNovoLivro.Text.Trim();
            string estado = comboBoxEstadoNovoLivro.Text.Trim();

            int ano, numeroPaginas, qtdExemplares;

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(genero)
                || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(estado)
                || !int.TryParse(textBoxAnoNovoLivro.Text.Trim(), out ano)
                || !int.TryParse(textBoxNpgNovoLivro.Text.Trim(), out numeroPaginas)
                || !int.TryParse(textBoxQtdNovoLivro.Text.Trim(), out qtdExemplares))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            int? idLivro = livroParaEditar?.Id;

            //MessageBox.Show($"ID para ignorar: {idLivro}");

            bool duplicado = LivroJaExiste(titulo, autor, ano, idLivro);

            //MessageBox.Show("Resultado da verificação: " + (duplicado ? "DUPLICADO" : "OK"));

            if (duplicado)
            {
                MessageBox.Show("Este livro já está cadastrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (livroParaEditar == null)
            {
                string query = @"INSERT INTO livros 
                            (titulo, autor, ano, genero, numero_paginas, qtd_exemplares, status, estado)
                            VALUES 
                            (@titulo, @autor, @ano, @genero, @numero_paginas, @qtd_exemplares, @status, @estado)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@ano", ano);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@numero_paginas", numeroPaginas);
                    cmd.Parameters.AddWithValue("@qtd_exemplares", qtdExemplares);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Livro cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                string query = @"UPDATE livros SET 
                                titulo = @titulo,
                                autor = @autor,
                                ano = @ano,
                                genero = @genero,
                                numero_paginas = @numero_paginas,
                                qtd_exemplares = @qtd_exemplares,
                                status = @status,
                                estado = @estado
                            WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@ano", ano);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@numero_paginas", numeroPaginas);
                    cmd.Parameters.AddWithValue("@qtd_exemplares", qtdExemplares);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", livroParaEditar.Id);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Livro atualizado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar livro: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
        }
    }
}
