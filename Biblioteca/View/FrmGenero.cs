﻿using Biblioteca.Helper;
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
            GrdItens.ReadOnly = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    Genero oGenero = new Genero
                    {
                        id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oGenero.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o gênero: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
                else
                {
                    //Altera o gênero selecionado                    

                    Genero oGenero = new Genero
                    {
                        id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Genero.Alterar(oGenero);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o gênero: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }

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

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
                {
                    Genero objSelecionado = (Genero)GrdItens.Rows[e.RowIndex].DataBoundItem;
                    if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                    {
                        //Clicou no botao alterar
                        TxtCodigo.Text = objSelecionado.id.ToString();
                        TxtNome.Text = objSelecionado.Nome;
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
    }
}
