using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string TituloLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public DateTime? DataDevolvido { get; set; }
        public string NotificaçaoExcluida { get; set; }
        public string Status { get; set; }
    
    public bool EmAtraso
        {
            get
            {
                return !DataDevolvido.HasValue && DataDevolucao.HasValue && DataDevolucao.Value < DateTime.Now;
            }
        }
    }
}
