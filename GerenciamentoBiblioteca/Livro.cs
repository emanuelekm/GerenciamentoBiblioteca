using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public int N_pagina { get; set; }
        public int Qtd_exemplares { get; set; }
        public string Status { get; set; }
        public string Estado { get; set; }
    }
}
