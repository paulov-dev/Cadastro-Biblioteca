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

        public static Idioma? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaIdioma where p.idIdioma == Codigo select p).FirstOrDefault();
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
                string SQL = $"DELETE FROM Idioma WHERE id = {this.idIdioma}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
                DataHelper.ListaIdioma.Remove(this);
            }
        }
        public void PreencherComboBoxIdioma(ComboBox combobox)
        {
            List<Idioma> listaIdiomas = Idioma.ListarTodos();

            combobox.DisplayMember = "Nome";
            combobox.ValueMember = "id";

            combobox.DataSource = listaIdiomas;
        }
    }
}
