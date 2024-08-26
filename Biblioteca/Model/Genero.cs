using Biblioteca.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Genero
    {
        public int? Codigo { get; set; }
        public string? Nome { get; set; }

        public static List<Genero> ListarTodos()
        {
            return (from p in DataHelper.ListaGenero select p).ToList();
        }
    }
}
