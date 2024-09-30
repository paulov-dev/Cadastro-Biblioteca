using Biblioteca.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        public int idLivro { get; set; }
        public int isbn { get; set; }
        public string nomeLivro { get; set; }
        public string descricaoLivro { get; set; }
        public int edicaoLivro { get; set; }
        public int qtdPagLivro { get; set; }
        public Autor Autor { get; set; }
        public Idioma Idioma { get; set; }
        public Editora Editora { get; set; }
        public Genero Genero { get; set; }


        public static List<Livro> ListaTodos()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "SELECT * FROM Livros";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                SqlDataReader oDr = oCmd.ExecuteReader();

                List<Livro> Retorno = new List<Livro>();
                while (oDr.Read())
                {
                    Retorno.Add(new Livro
                    {
                        idLivro = oDr.GetInt32(oDr.GetOrdinal("id")),
                        isbn = oDr.GetInt32(oDr.GetOrdinal("isbn")),
                        nomeLivro = oDr.GetString(oDr.GetOrdinal("nome")),
                        descricaoLivro = oDr.GetString(oDr.GetOrdinal("descricao")),
                        edicaoLivro = oDr.GetInt32(oDr.GetOrdinal("edicao")),
                        qtdPagLivro = oDr.GetInt32(oDr.GetOrdinal("qtdPaginas")),
                        Autor = Autor.Seleciona(oDr.GetInt32(oDr.GetOrdinal("autor_id"))),
                        Idioma = Idioma.Seleciona(oDr.GetInt32(oDr.GetOrdinal("idioma_id"))),
                        Editora = Editora.Seleciona(oDr.GetInt32(oDr.GetOrdinal("editora_id"))),
                        Genero = Genero.Seleciona(oDr.GetInt32(oDr.GetOrdinal("genero_id")))
                    });
                }
                oDr.Close();

                return Retorno;
            }
        }

        public void Incluir()
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "INSERT INTO Livros (id, nome, descricao, isbn, edicao, qtdPaginas, editora_id, idioma_id, autor_id, genero_id) VALUES (@id, @nome, @descricao, @isbn, @edicao, @qtdPaginas, @editora_id, @idioma_id, @autor_id, @genero_id)";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@id", this.idLivro);
                oCmd.Parameters.AddWithValue("@nome", this.nomeLivro);
                oCmd.Parameters.AddWithValue("@descricao", this.descricaoLivro);
                oCmd.Parameters.AddWithValue("@isbn", this.isbn);
                oCmd.Parameters.AddWithValue("@edicao", this.edicaoLivro);
                oCmd.Parameters.AddWithValue("@qtdPaginas", this.qtdPagLivro);
                oCmd.Parameters.AddWithValue("@editora_id", this.Editora.idEditora);
                oCmd.Parameters.AddWithValue("@idioma_id", this.Idioma.idIdioma);
                oCmd.Parameters.AddWithValue("@autor_id", this.Autor.idAutor);
                oCmd.Parameters.AddWithValue("@genero_id", this.Genero.id);
                oCmd.ExecuteNonQuery();
            }
        }

        public static void Alterar(Livro oLivro)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = "UPDATE Livros SET nome=@nome, descricao=@descricao, isbn=@isbn, edicao=@edicao, qtdPaginas=@qtdPaginas, editora_id=@editora_id, idioma_id=@idioma_id, autor_id=@autor_id, genero_id=@genero_id WHERE id=@id";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.Parameters.AddWithValue("@nome", oLivro.nomeLivro);
                oCmd.Parameters.AddWithValue("@descricao", oLivro.descricaoLivro);
                oCmd.Parameters.AddWithValue("@isbn", oLivro.isbn);
                oCmd.Parameters.AddWithValue("@qtdPaginas", oLivro.qtdPagLivro);
                oCmd.Parameters.AddWithValue("@edicao", oLivro.edicaoLivro);
                oCmd.Parameters.AddWithValue("@autor_id", oLivro.Autor.idAutor);
                oCmd.Parameters.AddWithValue("@editora_id", oLivro.Editora.idEditora);
                oCmd.Parameters.AddWithValue("@idioma_id", oLivro.Idioma.idIdioma);
                oCmd.Parameters.AddWithValue("@genero_id", oLivro.Genero.id);
                oCmd.Parameters.AddWithValue("@id", oLivro.idLivro);
                oCmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            using (var ocn = DataHelper.Conexao())
            {
                string sql = $"DELETE FROM Livros WHERE id={id}";
                SqlCommand oCmd = new SqlCommand(sql, ocn);
                oCmd.ExecuteNonQuery();
            }
        }
    }
}
