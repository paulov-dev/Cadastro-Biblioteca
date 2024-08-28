using Biblioteca.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Autor
    {
        public int idAutor { get; set; }
        public string? nomeAutor { get; set; }

        public static List<Autor> ListarTodos()
        {
            return (from p in DataHelper.ListaAutor select p).ToList();
        }

        public static Autor? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaAutor where p.idAutor == Codigo select p).FirstOrDefault();
        }

        public void Incluir()
        {
            Autor? oAutorSelecionado = Autor.Seleciona(this.idAutor);
            if (oAutorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no autor {oAutorSelecionado.nomeAutor}");
            }
            else
            {
                DataHelper.ListaAutor.Add(this);
            }

        }

        public static void Alterar(Autor oAutor)
        {
            Autor? AutorColecao = Seleciona(oAutor.idAutor);

            if (AutorColecao == null)
            {
                throw new Exception($"O objeto informado não existe mais no contexto.");
            }
            else
            {
                //GeneroColecao.id = oGenero.id;
                AutorColecao.nomeAutor = oAutor.nomeAutor;
            }
        }

        public void Excluir()
        {
            DataHelper.ListaAutor.Remove(this);
        }
    }
}
