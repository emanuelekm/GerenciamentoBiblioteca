﻿using System;
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
    public partial class FormPrincipalAdmin : Form
    {
        public FormPrincipalAdmin()
        {
            InitializeComponent();

            labelBemVindo.Text = $"Bem-vindo(a), {Sessao.TipoUsuario}!\n{Sessao.Nome}";

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CarregarTela(new UC_InicioAdmin());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["FormLogin"].Show();
        }

        public void CarregarTela(UserControl tela)
        {
            panelTelaInterna.Controls.Clear();     
            tela.Dock = DockStyle.Fill;         
            panelTelaInterna.Controls.Add(tela);  
        }

        private void linkLabelInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_InicioAdmin());
        }

        private void linkLabelAlterarCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_AlterarCadastro());
        }

        private void linkLabelNotificacoes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_NotificacoesAdmin());
        }

    }
}
