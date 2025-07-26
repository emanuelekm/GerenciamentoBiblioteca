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

        /*private void linkLabelDuvidasLeitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarTela(new UC_Duvidas());
        }*/

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["FormLogin"].Show();
        }
    }
}
