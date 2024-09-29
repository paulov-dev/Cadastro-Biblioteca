namespace Biblioteca.View
{
    partial class FrmLivro
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
            Descrição = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Paginas = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnSalvar = new Button();
            label1 = new Label();
            LblCodigo = new Label();
            TxtNome = new TextBox();
            TxtCodigo = new TextBox();
            label2 = new Label();
            TxtDescricao = new RichTextBox();
            label3 = new Label();
            TxtIsbn = new TextBox();
            label4 = new Label();
            TxtPag = new TextBox();
            label5 = new Label();
            CmbIdioma = new ComboBox();
            CmbEditora = new ComboBox();
            label6 = new Label();
            CmbGenero = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            TxtEdicao = new TextBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Descrição, ISBN, Paginas, Idioma, Editora, BtnAlterar, BtnExcluir });
            GrdItens.Location = new Point(3, 212);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersVisible = false;
            GrdItens.Size = new Size(1045, 413);
            GrdItens.TabIndex = 10;
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
            // Descrição
            // 
            Descrição.DataPropertyName = "Descricao";
            Descrição.HeaderText = "Descrição";
            Descrição.Name = "Descrição";
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // Paginas
            // 
            Paginas.HeaderText = "Páginas";
            Paginas.Name = "Paginas";
            // 
            // Idioma
            // 
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            // 
            // Editora
            // 
            Editora.HeaderText = "Editora";
            Editora.Name = "Editora";
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
            BtnFechar.Location = new Point(155, 161);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(104, 30);
            BtnFechar.TabIndex = 9;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(35, 161);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(104, 30);
            BtnSalvar.TabIndex = 8;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome do Livro";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(35, 8);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 12;
            LblCodigo.Text = "Código";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(87, 26);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(175, 23);
            TxtNome.TabIndex = 15;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(35, 26);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(46, 23);
            TxtCodigo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 52);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 16;
            label2.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(35, 70);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(985, 85);
            TxtDescricao.TabIndex = 18;
            TxtDescricao.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 8);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 19;
            label3.Text = "ISBN";
            // 
            // TxtIsbn
            // 
            TxtIsbn.Location = new Point(268, 26);
            TxtIsbn.MaxLength = 4;
            TxtIsbn.Name = "TxtIsbn";
            TxtIsbn.Size = new Size(88, 23);
            TxtIsbn.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 9);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 21;
            label4.Text = "Nº Páginas";
            // 
            // TxtPag
            // 
            TxtPag.Location = new Point(362, 26);
            TxtPag.MaxLength = 4;
            TxtPag.Name = "TxtPag";
            TxtPag.Size = new Size(65, 23);
            TxtPag.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 9);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 23;
            label5.Text = "Idioma";
            // 
            // CmbIdioma
            // 
            CmbIdioma.FormattingEnabled = true;
            CmbIdioma.Location = new Point(504, 26);
            CmbIdioma.Name = "CmbIdioma";
            CmbIdioma.Size = new Size(121, 23);
            CmbIdioma.TabIndex = 24;
            // 
            // CmbEditora
            // 
            CmbEditora.FormattingEnabled = true;
            CmbEditora.Location = new Point(631, 26);
            CmbEditora.Name = "CmbEditora";
            CmbEditora.Size = new Size(121, 23);
            CmbEditora.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(631, 9);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 25;
            label6.Text = "Editora";
            // 
            // CmbGenero
            // 
            CmbGenero.FormattingEnabled = true;
            CmbGenero.Location = new Point(758, 26);
            CmbGenero.Name = "CmbGenero";
            CmbGenero.Size = new Size(121, 23);
            CmbGenero.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(758, 9);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 27;
            label7.Text = "Gênero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 9);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 29;
            label8.Text = "Edição";
            // 
            // TxtEdicao
            // 
            TxtEdicao.Location = new Point(433, 26);
            TxtEdicao.MaxLength = 4;
            TxtEdicao.Name = "TxtEdicao";
            TxtEdicao.Size = new Size(65, 23);
            TxtEdicao.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(885, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(885, 9);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 31;
            label9.Text = "Gênero";
            // 
            // FrmLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 627);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TxtEdicao);
            Controls.Add(CmbGenero);
            Controls.Add(label7);
            Controls.Add(CmbEditora);
            Controls.Add(label6);
            Controls.Add(CmbIdioma);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtPag);
            Controls.Add(label3);
            Controls.Add(TxtIsbn);
            Controls.Add(TxtDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Name = "FrmLivro";
            Text = "Cadastrar Livro";
            Activated += FrmLivro_Activated;
            FormClosed += FrmLivro_FormClosed;
            Load += FrmLivro_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private Button BtnFechar;
        private Button BtnSalvar;
        private Label label1;
        private Label LblCodigo;
        private TextBox TxtNome;
        private TextBox TxtCodigo;
        private Label label2;
        private RichTextBox TxtDescricao;
        private Label label3;
        private TextBox TxtIsbn;
        private Label label4;
        private TextBox TxtPag;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Paginas;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        public ComboBox CmbIdioma;
        public ComboBox CmbEditora;
        public ComboBox CmbGenero;
        private Label label7;
        private Label label8;
        private TextBox TxtEdicao;
        public ComboBox comboBox1;
        private Label label9;
    }
}