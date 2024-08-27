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
        public int Codigo { get; set; }
        public string? Nome { get; set; }

        public static List<Genero> ListarTodos()
        {
            return (from p in DataHelper.ListaGenero select p).ToList();
        }

        public static Genero? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.Codigo == Codigo select p).FirstOrDefault();
        }

        public void Incluir()
        { // PAREI AQUI
            Genero? oGeneroSelecionado = Genero.Seleciona(this.Codigo);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no gênero {oGeneroSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaGenero.Add(this);
            }
           
        }
    }
}
