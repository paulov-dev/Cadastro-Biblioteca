using Biblioteca.Helper;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public class MockUsuario
    {
        public static void CarregaUsuario()
        {
            List<Usuario> oLista = new List<Usuario>();

            for (int i = 1; i < 11; i++)
            {
                Usuario oUsuario = new Usuario
                {
                    idUsuario = i,
                    nomeUsuario = $"Usuário {i}"
                };
                oLista.Add(oUsuario);
            }

            DataHelper.ListaUsuario = oLista;

        }
    }
}
