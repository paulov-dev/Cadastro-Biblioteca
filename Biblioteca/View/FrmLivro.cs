using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class FrmLivro : Form
    {
        public bool Incluir = true;
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuLivro.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSLivro.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmLivro_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Livro";

        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            Genero.PreencherComboBoxGenero(CmbGenero);
            Editora.PreencherComboBoxEditora(CmbEditora);
            Autor.PreencherComboBoxAutor(CmbAutor);
            Idioma.PreencherComboBoxIdioma(CmbIdioma);
        }

        private bool ValidaControles()
        {
            int Codigo;
            //Código
            if (TxtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("O campo Código é de preenchimento obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo Código não é numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            } 
            //Nome do Livro
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome do Livro é de preenchimento obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
            //ISBN
            if (TxtIsbn.Text.Trim() == "")
            {
                MessageBox.Show("O campo ISBN é de preenchimento obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if (int.TryParse(TxtIsbn.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo ISBN não é numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
            //N páginas
            if (TxtPag.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nº Páginas é de preenchimento obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if (int.TryParse(TxtPag.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo Nº Páginas não é numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
            //Edição
            if (TxtEdicao.Text.Trim() == "")
            {
                MessageBox.Show("O campo Edição é de preenchimento obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if (int.TryParse(TxtEdicao.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo Edição não é numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }
            //Comboboxes
            if (CmbIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Idioma do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbIdioma.Focus();
                return false;
            }

            if (CmbAutor.SelectedIndex == -1)
            {
                MessageBox.Show("Autor do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbIdioma.Focus();
                return false;
            }

            if (CmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Gênero do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbIdioma.Focus();
                return false;
            }
            
            if (CmbEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Editora do livro é obrigatória", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbIdioma.Focus();
                return false;
            }

            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Corrigir
            if (ValidaControles())
            {

                Livro oLivro = new Livro(
                int.Parse(TxtCodigo.Text),
                int.Parse(TxtIsbn.Text),
                TxtNome.Text,
                TxtDescricao.Text,
                int.Parse(TxtEdicao.Text),
                int.Parse(TxtPag.Text)
                );

            }
        }
    }
}