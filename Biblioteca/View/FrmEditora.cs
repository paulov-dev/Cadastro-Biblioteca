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
    public partial class FrmEditora : Form
    {
        public bool Incluir = true;

        public FrmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Editora";
            GrdItens.ReadOnly = true;
        }

        private void FrmEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuEditora.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSEditora.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Editora.ListarTodos();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
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

                //Inclui um gênero na lista

                if (Incluir)
                {
                    Editora oEditora = new Editora
                    {
                        idEditora = int.Parse(TxtCodigo.Text),
                        NomeEditora = TxtNome.Text
                    };

                    try
                    {
                        oEditora.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir a editora: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
                else
                {
                    //Altera o gênero selecionado                    

                    Editora oEditora = new Editora
                    {
                        idEditora = int.Parse(TxtCodigo.Text),
                        NomeEditora = TxtNome.Text
                    };
                    try
                    {
                        Editora.Alterar(oEditora);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar a Editora: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }

            }
        }

        private void GrdItens_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
                {
                    Editora objSelecionado = (Editora)GrdItens.Rows[e.RowIndex].DataBoundItem;
                    if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                    {
                        //Clicou no botao alterar
                        TxtCodigo.Text = objSelecionado.idEditora.ToString();
                        TxtNome.Text = objSelecionado.NomeEditora;
                        TxtCodigo.Enabled = false;
                        TxtNome.Focus();
                        Incluir = false;
                    }
                    else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                    {
                        //Clicou no botao excluir
                        if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                objSelecionado.Excluir();
                                CarregaGrid();
                            }
                            catch (InvalidOperationException ex)
                            {
                                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
