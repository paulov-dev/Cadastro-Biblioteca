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
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Genero VALUES ('{this.id}','{this.Nome.Replace("'","")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Genero oGenero)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Genero set Nome = '{oGenero.Nome}' WHERE id = {oGenero.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Genero WHERE id = {this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
                DataHelper.ListaGenero.Remove(this);
            }
        }

        internal static void PreencherComboBoxGenero(ComboBox cmbGenero)
        {
            List<Genero> listaGenero = Genero.ListarTodos();

            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "id";

            cmbGenero.DataSource = listaGenero;
        }
    }
}
