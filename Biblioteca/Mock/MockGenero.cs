using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Helper;
using Biblioteca.Model;

namespace Biblioteca.Mock
{
    public class MockGenero
    {
        public static void CarregaGenero()
        {
            List<Genero> oLista = new List<Genero>();

            for (int i = 0; i < 10; i++) 
            {
                Genero oGenero = new Genero
                {
                    Codigo = i,
                    Nome = $"Gênero {i}"
                };
                oLista.Add(oGenero);
            }

            DataHelper.ListaGenero = oLista;

        }
    }
}
