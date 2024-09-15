using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Genero
    {
        public int id { get; set; }
        public string? Nome { get; set; }

        public static List<Genero> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List <Genero> Retorno = new List<Genero>();
                string SQL = "SELECT id, Nome FROM Genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Genero oGenero = new Genero();
                    oGenero.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oGenero.Nome = oDr.GetString(oDr.GetOrdinal("nome"));
                    Retorno.Add(oGenero);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Genero? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.id == Codigo select p).FirstOrDefault();
        }

        public void Incluir()
        { 
            Genero? oGeneroSelecionado = Genero.Seleciona(this.id);
            if (oGeneroSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no gênero {oGeneroSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaGenero.Add(this);
            }
           
        }

        public static void Alterar(Genero oGenero)
        {
            Genero? GeneroColecao = Seleciona(oGenero.id);

            if (GeneroColecao == null)
            {
                throw new Exception($"O objeto informado não existe mais no contexto.");
            }
            else
            {
                //GeneroColecao.id = oGenero.id;
                GeneroColecao.Nome = oGenero.Nome;
            }
        }

        public void Excluir()
        {
            DataHelper.ListaGenero.Remove(this);
        }

    }
}
