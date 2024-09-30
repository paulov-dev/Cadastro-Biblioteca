using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string? nomeUsuario { get; set; }

        public static List<Usuario> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Usuario> Retorno = new List<Usuario>();
                string SQL = "SELECT id, nome FROM Usuario";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.idUsuario = oDr.GetInt32(oDr.GetOrdinal("id"));
                    oUsuario.nomeUsuario = oDr.GetString(oDr.GetOrdinal("nome"));
                    Retorno.Add(oUsuario);
                }
                oDr.Close();
                return Retorno;
            }
        }
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Usuario VALUES ('{this.idUsuario}','{this.nomeUsuario.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public static void Alterar(Usuario oUsuario)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Usuario set nome = '{oUsuario.nomeUsuario}' WHERE id = {oUsuario.idUsuario}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Usuario WHERE id = {this.idUsuario}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        internal static void PreencherComboBoxUsuario(ComboBox cmbUsuario)
        {
            List<Usuario> listaUsuario = Usuario.ListarTodos();

            cmbUsuario.DisplayMember = "NomeUsuario";
            cmbUsuario.ValueMember = "idUsuario";

            cmbUsuario.DataSource = listaUsuario;
        }
    }
}
