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


    }
}