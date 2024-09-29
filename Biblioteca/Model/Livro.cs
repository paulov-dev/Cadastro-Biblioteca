using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Edicao { get; set; }
        public int QtdPaginas { get; set; }

        public Livro(int id, int isbn, string nome, string descricao, int edicao, int qtdPaginas)
        {
            Id = id;
            ISBN = isbn;
            Nome = nome;
            Descricao = descricao;
            Edicao = edicao;
            QtdPaginas = qtdPaginas;
        }
    }
}
