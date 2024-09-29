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

        private void FrmLivro_Activated(object sender, EventArgs e, Livro livro)
        {
            livro.CarregaIdiomas(CmbIdioma);
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
        }

        private bool ValidaControles()
        {
            int Codigo;

            if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo código não é numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }        

            if (CmbIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Idioma do livro é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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