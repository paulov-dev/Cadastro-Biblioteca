using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Idioma
    {
        public int idIdioma { get; set; }
        public string? nomeIdioma { get; set; }
        public override string ToString() => $"{nomeIdioma}";

        public static List<Idioma> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = "SELECT id, Nome FROM Idioma";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Idioma oIdioma = new Idioma();
                    oIdioma.idIdioma = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oIdioma.nomeIdioma = oDr.GetString(oDr.GetOrdinal("nome"));
                    Retorno.Add(oIdioma);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public static Idioma? Seleciona(int id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"SELECT * FROM Idioma WHERE id={id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                Idioma? Retorno = null;
                while (oDr.Read())
                {
                    Retorno = new Idioma
                    {
                        idIdioma = oDr.GetInt32(oDr.GetOrdinal("id")),
                        nomeIdioma = oDr.GetString(oDr.GetOrdinal("nome"))
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
                string SQL = $"INSERT INTO Idioma VALUES ('{this.idIdioma}', '{this.nomeIdioma}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Idioma oIdioma)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Idioma set Nome = '{oIdioma.nomeIdioma}' WHERE id = {oIdioma.idIdioma}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string checkSQL = $"SELECT COUNT(*) FROM Livros WHERE idioma_id = {this.idIdioma}";
                using (var checkCommand = new SqlCommand(checkSQL, oCn))
                {
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new InvalidOperationException("Não é possível excluir o idioma porque ele está associado a um ou mais livros.");
                    }
                }
                string SQL = $"DELETE FROM Idioma WHERE id = {this.idIdioma}";
                using (var comando = new SqlCommand(SQL, oCn))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

        internal static void PreencherComboBoxIdioma(ComboBox cmbIdioma)
        {
            List<Idioma> listaIdioma = Idioma.ListarTodos();

            cmbIdioma.DisplayMember = "nomeIdioma";
            cmbIdioma.ValueMember = "idIdioma";

            cmbIdioma.DataSource = listaIdioma;
        }
    }
}
