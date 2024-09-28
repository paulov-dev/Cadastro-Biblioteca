namespace Biblioteca.View
{
    partial class FrmUsuario
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
            GrdItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnSalvar = new Button();
            label1 = new Label();
            LblCodigo = new Label();
            TxtNome = new TextBox();
            TxtCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.AllowUserToResizeColumns = false;
            GrdItens.AllowUserToResizeRows = false;
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Location = new Point(0, 99);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(563, 468);
            GrdItens.TabIndex = 21;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "idUsuario";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "nomeUsuario";
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
            // BtnFechar
            // 
            BtnFechar.Location = new Point(152, 48);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(104, 30);
            BtnFechar.TabIndex = 20;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(32, 48);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(104, 30);
            BtnSalvar.TabIndex = 19;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 1);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 17;
            label1.Text = "Nome";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(32, 1);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 15;
            LblCodigo.Text = "Código";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(84, 19);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(432, 23);
            TxtNome.TabIndex = 18;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(32, 19);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(46, 23);
            TxtCodigo.TabIndex = 16;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 567);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmUsuario";
            Text = "Cadastro de Usuário";
            Activated += FrmUsuario_Activated;
            FormClosed += FrmUsuario_FormClosed;
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private Button BtnFechar;
        private Button BtnSalvar;
        private Label label1;
        private Label LblCodigo;
        private TextBox TxtNome;
        private TextBox TxtCodigo;
    }
}