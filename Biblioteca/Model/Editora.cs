using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Editora
    {
        public int idEditora { get; set; }
        public string? NomeEditora { get; set; }
        
        public static List<Editora>ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = "SELECT id, Nome FROM Editora";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Editora oEditora = new Editora();
                    oEditora.idEditora = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oEditora.NomeEditora = oDr.GetString(oDr.GetOrdinal("nome"));
                    Retorno.Add(oEditora);
                }
                oDr.Close();
                return Retorno;
            }      
        }
        public static Editora? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaEditora where p.idEditora == Codigo select p).FirstOrDefault();
        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Editora VALUES ('{this.idEditora}','{this.NomeEditora.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Editora oEditora)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Editora set Nome = '{oEditora.NomeEditora}' WHERE id = {oEditora.idEditora}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Editora WHERE id = {this.idEditora}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
                DataHelper.ListaEditora.Remove(this);
            }
        }
    }
}
