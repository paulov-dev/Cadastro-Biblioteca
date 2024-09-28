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
    public partial class FrmUsuario : Form
    {
        public bool Incluir = true;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Usuário";
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuUsuario.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSUsuario.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Usuario.ListarTodos();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            int Codigo;

            if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo código não é numérico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if (TxtNome.Text.Trim() == "")
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
                if (Incluir)
                {
                    Usuario oUsuario = new Usuario
                    {
                        idUsuario = int.Parse(TxtCodigo.Text),
                        nomeUsuario = TxtNome.Text
                    };

                    try
                    {
                        oUsuario.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o usuário: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
                else
                {
                    //Altera o gênero selecionado                    

                    Usuario oUsuario = new Usuario
                    {
                        idUsuario = int.Parse(TxtCodigo.Text),
                        nomeUsuario = TxtNome.Text
                    };
                    try
                    {
                        Usuario.Alterar(oUsuario);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o usuário: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }

            }
        }
        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Usuario objSelecionado = (Usuario)GrdItens.Rows[e.RowIndex].DataBoundItem;           
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    //Clicou no botao alterar
                    TxtCodigo.Text = objSelecionado.idUsuario.ToString();
                    TxtNome.Text = objSelecionado.nomeUsuario;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    //Clicou no botao excluir
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
