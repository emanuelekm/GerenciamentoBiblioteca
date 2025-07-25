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
    public partial class UC_InicioLeitor : UserControl
    {
        public UC_InicioLeitor()
        {
            InitializeComponent();
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            FormPrincipalLeitor formularioPai = this.FindForm() as FormPrincipalLeitor;
            if (formularioPai != null)
            {
                UC_PesquisarAcervo userControlPesquisarAcervoAdmin = new UC_PesquisarAcervo();

                formularioPai.CarregarTela(userControlPesquisarAcervoAdmin);
            }
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            FormPrincipalLeitor formularioPai = this.FindForm() as FormPrincipalLeitor;
            if (formularioPai != null)
            {
                UC_FeedPublicacoes uC_FeedPublicacoes = new UC_FeedPublicacoes();

                formularioPai.CarregarTela(uC_FeedPublicacoes);
            }
        }

        private void buttonHistorico_Click(object sender, EventArgs e)
        {
            FormPrincipalLeitor formularioPai = this.FindForm() as FormPrincipalLeitor;
            if (formularioPai != null)
            {
                UC_HistoricoLeitor uC_HistoricoLeitor = new UC_HistoricoLeitor();

                formularioPai.CarregarTela(uC_HistoricoLeitor);
            }
        }
    }
}
