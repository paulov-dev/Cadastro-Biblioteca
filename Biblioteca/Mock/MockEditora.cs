using Biblioteca.Helper;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Mock
{
    public class MockEditora
    {
        public static void CarregaEditora()
        {
            List<Editora> oLista = new List<Editora>();

            for (int i = 1; i < 11; i++)
            {
                Editora oEditora = new Editora
                {
                    idEditora = i,
                    NomeEditora = $"Editora {i}"
                };
                oLista.Add(oEditora);
            }

            DataHelper.ListaEditora = oLista;

        }
    }
}

