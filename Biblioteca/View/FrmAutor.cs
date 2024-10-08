﻿using Biblioteca.Model;
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
    public partial class FrmAutor : Form
    {
        public bool Incluir = true;

        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Autor";
            GrdItens.ReadOnly = true;
        }

        private void FrmAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuAutor.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSAutor.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Autor.ListarTodos();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
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
                    Autor oAutor = new Autor
                    {
                        idAutor = int.Parse(TxtCodigo.Text),
                        nomeAutor = TxtNome.Text
                    };

                    try
                    {
                        oAutor.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
                else
                {
                    //Altera o gênero selecionado                    

                    Autor oAutor = new Autor
                    {
                        idAutor = int.Parse(TxtCodigo.Text),
                        nomeAutor = TxtNome.Text
                    };
                    try
                    {
                        Autor.Alterar(oAutor);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }

            }
        }
        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
                {
                    Autor objSelecionado = (Autor)GrdItens.Rows[e.RowIndex].DataBoundItem;
                    if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                    {
                        //Clicou no botao alterar
                        TxtCodigo.Text = objSelecionado.idAutor.ToString();
                        TxtNome.Text = objSelecionado.nomeAutor;
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
