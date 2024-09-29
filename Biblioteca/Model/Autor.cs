using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
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
            using (var oCn = DataHelper.Conexao())
            {
                List <Autor> Retorno = new List<Autor>();
                string SQL = "SELECT id, Nome FROM Autor";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Autor oAutor = new Autor();
                    oAutor.idAutor  = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oAutor.nomeAutor = oDr.GetString(oDr.GetOrdinal("nome"));
                    Retorno.Add(oAutor);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Autor? Seleciona(int id)
        {            
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Autor WHERE id={id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Autor? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Autor
                    {
                        idAutor = oDr.GetInt32(oDr.GetOrdinal("id")),
                        nomeAutor = oDr.GetString(oDr.GetOrdinal("nome"))
                    };
                }
                oDr.Close();

                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Autor VALUES ('{this.idAutor}', '{this.nomeAutor}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Autor oAutor)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Autor set Nome = '{oAutor.nomeAutor}' WHERE id = {oAutor.idAutor}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Autor WHERE id = {this.idAutor}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
                DataHelper.ListaAutor.Remove(this);
            }
        }
        internal static void PreencherComboBoxAutor(ComboBox cmbAutor)
        {
            List<Autor> listaAutor = Autor.ListarTodos();

            cmbAutor.DisplayMember = "nomeAutor";
            cmbAutor.ValueMember = "idAutor";

            cmbAutor.DataSource = listaAutor;
        }
    }
}
