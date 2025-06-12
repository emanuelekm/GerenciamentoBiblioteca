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
    public partial class UC_InicioAdmin : UserControl
    {
        private MySqlConnection conexao;

        public UC_InicioAdmin()
        {
            InitializeComponent();
            string conexaoString = "Server=localhost;Database=gerenciamentobiblioteca;Uid=root;Pwd=;";
            conexao = new MySqlConnection(conexaoString);
        }

        private void buttonPesquisarAcervo_Click(object sender, EventArgs e)
        {
            FormPrincipalAdmin formularioPai = this.FindForm() as FormPrincipalAdmin;
            if (formularioPai != null)
            {
                UC_PesquisarAcervo userControlPesquisarAcervoAdmin = new UC_PesquisarAcervo();

                formularioPai.CarregarTela(userControlPesquisarAcervoAdmin);
            }

        }

        private void buttonAlterarColeção_Click(object sender, EventArgs e)
        {
            FormPrincipalAdmin formularioPai = this.FindForm() as FormPrincipalAdmin;
            if (formularioPai != null)
            {
                UC_AlterarAcervo uCAlterarAcervo = new UC_AlterarAcervo();

                formularioPai.CarregarTela(uCAlterarAcervo);
            }
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            FormPrincipalAdmin formularioPai = this.FindForm() as FormPrincipalAdmin;
            if (formularioPai != null)
            {
                UC_ControleDeUsuarios uCControleDeUsuarios = new UC_ControleDeUsuarios();

                formularioPai.CarregarTela(uCControleDeUsuarios);
            }
        }

        private void buttonEmprestimo_Click(object sender, EventArgs e)
        {
            FormPrincipalAdmin formularioPai = this.FindForm() as FormPrincipalAdmin;
            if (formularioPai != null)
            {
                UC_Emprestimo uCEmprestimo = new UC_Emprestimo();

                formularioPai.CarregarTela(uCEmprestimo);
            }
        }

        private void buttonDevolucoes_Click(object sender, EventArgs e)
        {
            FormPrincipalAdmin formularioPai = this.FindForm() as FormPrincipalAdmin;
            if (formularioPai != null)
            {
                UC_Devolucao uCDevolucao = new UC_Devolucao();

                formularioPai.CarregarTela(uCDevolucao);
            }
        }
    }
}
