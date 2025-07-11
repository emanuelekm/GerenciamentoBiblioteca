﻿using System;
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
    public partial class FormUsuario : Form
    {
        private MySqlConnection conexao;
        private Usuario usuarioParaEditar = null;

        public FormUsuario(MySqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;

            comboBoxTipoUsuario.Items.AddRange(new string[] { "Administrador", "Leitor" });

            textBoxSenhaPadrao.Text = "Leitor@1234";
        }
        public FormUsuario(MySqlConnection conexao, Usuario usuario) : this(conexao)
        {
            this.usuarioParaEditar = usuario;

            textBoxNome.Text = usuario.Nome;
            textBoxEmail.Text = usuario.Email;
            textBoxTelefone.Text = usuario.Telefone;
            comboBoxTipoUsuario.Text = usuario.Tipo_usuario;
            dtpNascimento.Value = usuario.Data_nascimento;

            if (usuario.Senha != null)
            {
                textBoxSenhaPadrao.Text = usuario.Senha;
            }
            else
            {
                textBoxSenhaPadrao.Text = "Leitor@1234";
            }
        }

        private void buttonSalvarUsuario_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string telefone = textBoxTelefone.Text.Trim();
            string tipo = comboBoxTipoUsuario.Text.Trim();
            DateTime dataNascimento = dtpNascimento.Value;
            string senha = textBoxSenhaPadrao.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }


            if (usuarioParaEditar == null)
            {
                //string senhaPadrao = "Leitor@1234";

                string senhas = textBoxSenhaPadrao.Text.Trim();
                string senhaHash = PasswordHasher.Hash(senhas);

                string query = @"INSERT INTO usuarios 
                (nome, email, telefone, tipo_usuario, data_nascimento, senha)
                VALUES 
                (@nome, @email, @telefone, @tipo_usuario, @data_nascimento, @senha)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@tipo_usuario", tipo);
                    cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                string query;
                if (!string.IsNullOrEmpty(senha))
                {
                    query = @"UPDATE usuarios SET 
                    nome = @nome,
                    email = @email,
                    telefone = @telefone,
                    tipo_usuario = @tipo_usuario,
                    data_nascimento = @data_nascimento,
                    senha = @senha
                  WHERE id = @id";
                }
                else
                {
                    query = @"UPDATE usuarios SET 
                    nome = @nome,
                    email = @email,
                    telefone = @telefone,
                    tipo_usuario = @tipo_usuario,
                    data_nascimento = @data_nascimento
                  WHERE id = @id";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@tipo_usuario", tipo);
                    cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@id", usuarioParaEditar.Id);

                    if (!string.IsNullOrEmpty(senha))
                        cmd.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário atualizado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar usuário: " + ex.Message);
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
