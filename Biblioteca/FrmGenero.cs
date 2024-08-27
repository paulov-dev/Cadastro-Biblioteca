using Biblioteca.Helper;
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

namespace Biblioteca
{
    public partial class FrmGenero : Form
    {
        public bool Incluir = true;

        public FrmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuGenero.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSGenero.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void FrmGenero_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Gênero";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaControles()
        {
            int Codigo;

            if (int.TryParse(TxtCodigo.Text, out Codigo)==false)
            {
                MessageBox.Show("O campo código não é numérico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if(TxtNome.Text.Trim()=="")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }

            return true;
        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            TxtCodigo.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {

                //Inclui um gênero na lista

                if (Incluir)
                {
                    Genero oGenero = new Genero
                    {
                        Codigo = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };

                    oGenero.Incluir();
                   
                }
                else
                {
                    //Altera o gênero selecionado
                }
                CarregaGrid();
                LimpaControles();
            }
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Genero.ListarTodos();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
