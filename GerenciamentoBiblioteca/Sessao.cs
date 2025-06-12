using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    public static class Sessao
    {
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Email { get; set; }
        public static string TipoUsuario { get; set; }
        public static DateTime DataNascimento { get; set; }
        public static string Telefone { get; set; }
    }
}
