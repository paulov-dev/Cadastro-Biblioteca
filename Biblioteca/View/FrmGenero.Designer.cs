namespace Biblioteca
{
    partial class FrmGenero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            LblCodigo = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(32, 47);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(46, 23);
            TxtCodigo.TabIndex = 1;
            toolTip1.SetToolTip(TxtCodigo, "Código numérico do gênero");
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(84, 47);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(432, 23);
            TxtNome.TabIndex = 3;
            toolTip1.SetToolTip(TxtNome, "Nome do Gênero do Filme");
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(32, 29);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(32, 76);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(104, 30);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(152, 76);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(104, 30);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Location = new Point(0, 127);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersVisible = false;
            GrdItens.Size = new Size(559, 413);
            GrdItens.TabIndex = 7;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "id";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 200;
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.Name = "BtnAlterar";
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            // 
            // FrmGenero
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnFechar;
            ClientSize = new Size(559, 542);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmGenero";
            Text = "Cadastro de Gêneros de Filme";
            Activated += FrmGenero_Activated;
            FormClosed += FrmGenero_FormClosed;
            Load += FrmGenero_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private Label LblCodigo;
        private Label label1;
        private ToolTip toolTip1;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}