using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GerenciamentoBiblioteca
{
    public partial class UC_Config : UserControl
    {
        public UC_Config()
        {
            InitializeComponent();
        }

        string caminhoArquivo = Path.Combine(Application.StartupPath, "manual.pdf");

        private void linkLabelConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo manual.pdf não encontrado no diretório do programa.");
                return;
            }

            SaveFileDialog salvarComo = new SaveFileDialog();
            salvarComo.FileName = "manual.pdf";
            salvarComo.Filter = "Arquivos PDF (*.pdf)|*.pdf";

            if (salvarComo.ShowDialog() == DialogResult.OK)
            {
                File.Copy(caminhoArquivo, salvarComo.FileName, true);
                MessageBox.Show("Arquivo salvo com sucesso!");
            }
        }
    }
}
