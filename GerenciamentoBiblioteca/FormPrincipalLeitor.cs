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
        }
    }
}
