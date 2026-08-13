
namespace manganosekai
{
    partial class fmconsproduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmconsproduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbConsproduto = new System.Windows.Forms.GroupBox();
            this.btsair = new System.Windows.Forms.Button();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.gbAutor = new System.Windows.Forms.GroupBox();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.gbEditora = new System.Windows.Forms.GroupBox();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.gbdatalancamento = new System.Windows.Forms.GroupBox();
            this.dtpDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbTitulo = new System.Windows.Forms.GroupBox();
            this.tbtitulo = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbConsproduto.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.gbEditora.SuspendLayout();
            this.gbdatalancamento.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConsproduto
            // 
            this.gbConsproduto.Controls.Add(this.btsair);
            this.gbConsproduto.Controls.Add(this.gbCategoria);
            this.gbConsproduto.Controls.Add(this.gbAutor);
            this.gbConsproduto.Controls.Add(this.gbEditora);
            this.gbConsproduto.Controls.Add(this.gbdatalancamento);
            this.gbConsproduto.Controls.Add(this.gbStatus);
            this.gbConsproduto.Controls.Add(this.gbOpcao);
            this.gbConsproduto.Controls.Add(this.btPesquisar);
            this.gbConsproduto.Controls.Add(this.gbTitulo);
            this.gbConsproduto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsproduto.Location = new System.Drawing.Point(12, 30);
            this.gbConsproduto.Name = "gbConsproduto";
            this.gbConsproduto.Size = new System.Drawing.Size(378, 572);
            this.gbConsproduto.TabIndex = 55;
            this.gbConsproduto.TabStop = false;
            this.gbConsproduto.Enter += new System.EventHandler(this.gbConsproduto_Enter);
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsair.Location = new System.Drawing.Point(186, 507);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(171, 59);
            this.btsair.TabIndex = 116;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(199, 239);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(164, 65);
            this.gbCategoria.TabIndex = 2;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(6, 26);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(152, 27);
            this.cbCategoria.TabIndex = 0;
            // 
            // gbAutor
            // 
            this.gbAutor.Controls.Add(this.dgvAutor);
            this.gbAutor.Location = new System.Drawing.Point(6, 310);
            this.gbAutor.Name = "gbAutor";
            this.gbAutor.Size = new System.Drawing.Size(357, 192);
            this.gbAutor.TabIndex = 115;
            this.gbAutor.TabStop = false;
            this.gbAutor.Text = "Autor";
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.AllowUserToResizeColumns = false;
            this.dgvAutor.AllowUserToResizeRows = false;
            this.dgvAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutor.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAutor.Location = new System.Drawing.Point(6, 19);
            this.dgvAutor.MultiSelect = false;
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            this.dgvAutor.RowHeadersVisible = false;
            this.dgvAutor.RowHeadersWidth = 51;
            this.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutor.Size = new System.Drawing.Size(345, 167);
            this.dgvAutor.TabIndex = 58;
            // 
            // gbEditora
            // 
            this.gbEditora.Controls.Add(this.cbEditora);
            this.gbEditora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditora.Location = new System.Drawing.Point(6, 168);
            this.gbEditora.Name = "gbEditora";
            this.gbEditora.Size = new System.Drawing.Size(179, 65);
            this.gbEditora.TabIndex = 1;
            this.gbEditora.TabStop = false;
            this.gbEditora.Text = "Editora";
            // 
            // cbEditora
            // 
            this.cbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(6, 26);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(167, 27);
            this.cbEditora.TabIndex = 0;
            // 
            // gbdatalancamento
            // 
            this.gbdatalancamento.Controls.Add(this.dtpDataLancamento);
            this.gbdatalancamento.Location = new System.Drawing.Point(201, 168);
            this.gbdatalancamento.Name = "gbdatalancamento";
            this.gbdatalancamento.Size = new System.Drawing.Size(162, 65);
            this.gbdatalancamento.TabIndex = 114;
            this.gbdatalancamento.TabStop = false;
            this.gbdatalancamento.Text = "Ano de lançamento";
            // 
            // dtpDataLancamento
            // 
            this.dtpDataLancamento.CustomFormat = "yyyy";
            this.dtpDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataLancamento.Location = new System.Drawing.Point(10, 26);
            this.dtpDataLancamento.Name = "dtpDataLancamento";
            this.dtpDataLancamento.ShowUpDown = true;
            this.dtpDataLancamento.Size = new System.Drawing.Size(146, 27);
            this.dtpDataLancamento.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(6, 239);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(179, 65);
            this.gbStatus.TabIndex = 102;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(89, 26);
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
            this.rbAtivo.Location = new System.Drawing.Point(12, 25);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.cbOpcoes);
            this.gbOpcao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcao.Location = new System.Drawing.Point(6, 26);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(357, 65);
            this.gbOpcao.TabIndex = 4;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Escolha uma Opção de Consulta:";
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(6, 26);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(345, 27);
            this.cbOpcoes.TabIndex = 8;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(6, 507);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btPesquisar.Size = new System.Drawing.Size(174, 59);
            this.btPesquisar.TabIndex = 111;
            this.btPesquisar.Text = "     Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbTitulo
            // 
            this.gbTitulo.Controls.Add(this.tbtitulo);
            this.gbTitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTitulo.Location = new System.Drawing.Point(6, 97);
            this.gbTitulo.Name = "gbTitulo";
            this.gbTitulo.Size = new System.Drawing.Size(357, 65);
            this.gbTitulo.TabIndex = 0;
            this.gbTitulo.TabStop = false;
            this.gbTitulo.Text = "Título";
            // 
            // tbtitulo
            // 
            this.tbtitulo.Location = new System.Drawing.Point(6, 25);
            this.tbtitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtitulo.MaxLength = 50;
            this.tbtitulo.Name = "tbtitulo";
            this.tbtitulo.Size = new System.Drawing.Size(345, 27);
            this.tbtitulo.TabIndex = 0;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduto.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProduto.Location = new System.Drawing.Point(396, 40);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(744, 562);
            this.dgvProduto.TabIndex = 57;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 27);
            this.statusStrip1.TabIndex = 58;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(181, 22);
            this.toolStripStatusLabel1.Text = "Consulta de produto";
            // 
            // fmconsproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 614);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbConsproduto);
            this.Controls.Add(this.dgvProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmconsproduto";
            this.Text = "fmconsproduto";
            this.Load += new System.EventHandler(this.fmconsproduto_Load);
            this.gbConsproduto.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbAutor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.gbEditora.ResumeLayout(false);
            this.gbdatalancamento.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbTitulo.ResumeLayout(false);
            this.gbTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbConsproduto;
        public System.Windows.Forms.GroupBox gbdatalancamento;
        private System.Windows.Forms.DateTimePicker dtpDataLancamento;
        public System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        public System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Button btPesquisar;
        public System.Windows.Forms.GroupBox gbTitulo;
        private System.Windows.Forms.TextBox tbtitulo;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.ComboBox cbEditora;
        public System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox gbAutor;
        private System.Windows.Forms.DataGridView dgvAutor;
        public System.Windows.Forms.GroupBox gbEditora;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btsair;
    }
}
