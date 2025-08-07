using System;
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
    public partial class FormPrincipalLeitor : Form
    {
        public FormPrincipalLeitor()
        {
            InitializeComponent();

            labelBemVindo.Text = $"Bem-vindo, {Sessao.TipoUsuario}!\n{Sessao.Nome}";
        }

        private void FormPrincipalLeitor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CarregarTela(new UC_InicioLeitor());
        }

        public void CarregarTela(UserControl tela)
        {
            panelTelaInternaLeitor.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            panelTelaInternaLeitor.Controls.Add(tela);
        }

        private void linkLabelInicioLeitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_InicioLeitor());
        }

        private void linkLabelAlterarCadastroLeitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_AlterarCadastro());
        }

        private void linkLabelNotificacoesLeitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_NotificacoesLeitor());
        }

        private void linkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resultado = MessageBox.Show(
                "Tem certeza que deseja sair do sistema?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Hide();

                Sessao.Id = 0;

                FormLogin loginForm = new FormLogin();
                loginForm.Show();

                loginForm.FormClosed += (s, args) => this.Close();
            }
                
        }

        public void CarregarHomePorTipoUsuario()
        {
            panelTelaInternaLeitor.Controls.Clear();

            if (Sessao.TipoUsuario == "Leitor")
                panelTelaInternaLeitor.Controls.Add(new UC_InicioLeitor());
            else if (Sessao.TipoUsuario == "Administrador")
                panelTelaInternaLeitor.Controls.Add(new UC_InicioAdmin());
        }

        private void linkLabelConfigLeitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_Config());
        }
    }
}
