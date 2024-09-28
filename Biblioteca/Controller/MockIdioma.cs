using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Helper;
using Biblioteca.Model;

namespace Biblioteca.Mock
{
    public class MockIdioma
    {
        public static void CarregaIdioma()
        {
            List<Idioma> oLista = new List<Idioma>();

            for (int i = 1; i < 11; i++)
            {
                Idioma oIdioma = new Idioma
                {
                    idIdioma = i,
                    nomeIdioma = $"Idioma {i}"
                };
                oLista.Add(oIdioma);
            }

            DataHelper.ListaIdioma = oLista;

        }
    }
}
