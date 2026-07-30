
namespace manganosekai
{
    partial class formRelProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelProduto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSair = new System.Windows.Forms.Button();
            this.gbTipoRel = new System.Windows.Forms.GroupBox();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbPrecoVenda = new System.Windows.Forms.GroupBox();
            this.tbPrecoFim = new System.Windows.Forms.TextBox();
            this.tbPrecoIni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAutor = new System.Windows.Forms.GroupBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.gbEditora = new System.Windows.Forms.GroupBox();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.tbEstoqueFim = new System.Windows.Forms.TextBox();
            this.tbEstoqueIni = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbDataLancamento = new System.Windows.Forms.GroupBox();
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.dtpini = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.classFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).BeginInit();
            this.gbTipoRel.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbPrecoVenda.SuspendLayout();
            this.gbAutor.SuspendLayout();
            this.gbEditora.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbDataLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classProdutoBindingSource
            // 
            this.classProdutoBindingSource.DataSource = typeof(manganosekai.classProduto);
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(33, 717);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(207, 43);
            this.btSair.TabIndex = 146;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoRel.Location = new System.Drawing.Point(33, 52);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(207, 66);
            this.gbTipoRel.TabIndex = 145;
            this.gbTipoRel.TabStop = false;
            this.gbTipoRel.Text = "Selecione o Relatório:";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(7, 26);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(187, 27);
            this.cbTipoRel.TabIndex = 130;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Enabled = false;
            this.gbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(33, 196);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(207, 66);
            this.gbCategoria.TabIndex = 143;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(9, 28);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(185, 27);
            this.cbCategoria.TabIndex = 66;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(33, 668);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(206, 43);
            this.btGerarRelatorio.TabIndex = 144;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbPrecoVenda
            // 
            this.gbPrecoVenda.Controls.Add(this.tbPrecoFim);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoIni);
            this.gbPrecoVenda.Controls.Add(this.label6);
            this.gbPrecoVenda.Controls.Add(this.label8);
            this.gbPrecoVenda.Enabled = false;
            this.gbPrecoVenda.Location = new System.Drawing.Point(33, 340);
            this.gbPrecoVenda.Name = "gbPrecoVenda";
            this.gbPrecoVenda.Size = new System.Drawing.Size(206, 105);
            this.gbPrecoVenda.TabIndex = 141;
            this.gbPrecoVenda.TabStop = false;
            this.gbPrecoVenda.Text = "Preço de venda:";
            // 
            // tbPrecoFim
            // 
            this.tbPrecoFim.Location = new System.Drawing.Point(53, 70);
            this.tbPrecoFim.Name = "tbPrecoFim";
            this.tbPrecoFim.Size = new System.Drawing.Size(93, 20);
            this.tbPrecoFim.TabIndex = 48;
            // 
            // tbPrecoIni
            // 
            this.tbPrecoIni.Location = new System.Drawing.Point(53, 32);
            this.tbPrecoIni.Name = "tbPrecoIni";
            this.tbPrecoIni.Size = new System.Drawing.Size(93, 20);
            this.tbPrecoIni.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Até:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "De:";
            // 
            // gbAutor
            // 
            this.gbAutor.Controls.Add(this.cbAutor);
            this.gbAutor.Enabled = false;
            this.gbAutor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAutor.Location = new System.Drawing.Point(33, 268);
            this.gbAutor.Name = "gbAutor";
            this.gbAutor.Size = new System.Drawing.Size(207, 66);
            this.gbAutor.TabIndex = 142;
            this.gbAutor.TabStop = false;
            this.gbAutor.Text = "Autor";
            // 
            // cbAutor
            // 
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(9, 28);
            this.cbAutor.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(185, 27);
            this.cbAutor.TabIndex = 66;
            // 
            // gbEditora
            // 
            this.gbEditora.Controls.Add(this.cbEditora);
            this.gbEditora.Enabled = false;
            this.gbEditora.Location = new System.Drawing.Point(33, 124);
            this.gbEditora.Name = "gbEditora";
            this.gbEditora.Size = new System.Drawing.Size(207, 66);
            this.gbEditora.TabIndex = 140;
            this.gbEditora.TabStop = false;
            this.gbEditora.Text = "Editora";
            // 
            // cbEditora
            // 
            this.cbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(10, 25);
            this.cbEditora.Margin = new System.Windows.Forms.Padding(4);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(184, 27);
            this.cbEditora.TabIndex = 78;
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.tbEstoqueFim);
            this.gbEstoque.Controls.Add(this.tbEstoqueIni);
            this.gbEstoque.Controls.Add(this.label13);
            this.gbEstoque.Controls.Add(this.label14);
            this.gbEstoque.Enabled = false;
            this.gbEstoque.Location = new System.Drawing.Point(33, 451);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(206, 66);
            this.gbEstoque.TabIndex = 139;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // tbEstoqueFim
            // 
            this.tbEstoqueFim.Location = new System.Drawing.Point(144, 29);
            this.tbEstoqueFim.MaxLength = 3;
            this.tbEstoqueFim.Name = "tbEstoqueFim";
            this.tbEstoqueFim.Size = new System.Drawing.Size(50, 20);
            this.tbEstoqueFim.TabIndex = 45;
            // 
            // tbEstoqueIni
            // 
            this.tbEstoqueIni.Location = new System.Drawing.Point(43, 28);
            this.tbEstoqueIni.MaxLength = 3;
            this.tbEstoqueIni.Name = "tbEstoqueIni";
            this.tbEstoqueIni.Size = new System.Drawing.Size(50, 20);
            this.tbEstoqueIni.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "De:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(101, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Até:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Enabled = false;
            this.gbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(33, 595);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(207, 66);
            this.gbStatus.TabIndex = 137;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(98, 30);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 23);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(9, 30);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(177)))), ((int)(((byte)(52)))));
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1008, 46);
            this.pnTituloFuncionario.TabIndex = 136;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(400, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(233, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatorio de Produtos";
            // 
            // gbDataLancamento
            // 
            this.gbDataLancamento.Controls.Add(this.dtpfim);
            this.gbDataLancamento.Controls.Add(this.dtpini);
            this.gbDataLancamento.Controls.Add(this.label1);
            this.gbDataLancamento.Controls.Add(this.label2);
            this.gbDataLancamento.Enabled = false;
            this.gbDataLancamento.Location = new System.Drawing.Point(33, 523);
            this.gbDataLancamento.Name = "gbDataLancamento";
            this.gbDataLancamento.Size = new System.Drawing.Size(206, 74);
            this.gbDataLancamento.TabIndex = 140;
            this.gbDataLancamento.TabStop = false;
            this.gbDataLancamento.Text = "Data de Lançamento";
            // 
            // dtpfim
            // 
            this.dtpfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfim.Location = new System.Drawing.Point(43, 44);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(103, 20);
            this.dtpfim.TabIndex = 47;
            // 
            // dtpini
            // 
            this.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpini.Location = new System.Drawing.Point(33, 18);
            this.dtpini.Name = "dtpini";
            this.dtpini.Size = new System.Drawing.Size(103, 20);
            this.dtpini.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Até:";
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classProdutoBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "manganosekai.ReportProdutoTable.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(294, 62);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(666, 698);
            this.reportViewer.TabIndex = 147;
            // 
            // classFuncionarioBindingSource
            // 
            this.classFuncionarioBindingSource.DataSource = typeof(manganosekai.classFuncionario);
            // 
            // formRelProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 807);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.gbDataLancamento);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gbTipoRel);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbPrecoVenda);
            this.Controls.Add(this.gbAutor);
            this.Controls.Add(this.gbEditora);
            this.Controls.Add(this.gbEstoque);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.pnTituloFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRelProduto";
            this.Load += new System.EventHandler(this.formRelProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).EndInit();
            this.gbTipoRel.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbPrecoVenda.ResumeLayout(false);
            this.gbPrecoVenda.PerformLayout();
            this.gbAutor.ResumeLayout(false);
            this.gbEditora.ResumeLayout(false);
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbDataLancamento.ResumeLayout(false);
            this.gbDataLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbTipoRel;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbPrecoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbAutor;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.GroupBox gbEditora;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.TextBox tbEstoqueFim;
        private System.Windows.Forms.TextBox tbEstoqueIni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbPrecoFim;
        private System.Windows.Forms.TextBox tbPrecoIni;
        private System.Windows.Forms.GroupBox gbDataLancamento;
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.DateTimePicker dtpini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource classProdutoBindingSource;
        private System.Windows.Forms.BindingSource classFuncionarioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}