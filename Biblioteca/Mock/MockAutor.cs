using Biblioteca.Helper;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Mock
{
    public class MockAutor
    {
        public static void CarregaAutor()
        {
            List<Autor> oLista = new List<Autor>();

            for (int i = 1; i < 11; i++)
            {
                Autor oAutor = new Autor
                {
                    idAutor = i,
                    nomeAutor = $"Autor {i}"
                };
                oLista.Add(oAutor);
            }

            DataHelper.ListaAutor = oLista;

        }
    }
}
//testezinho zinho