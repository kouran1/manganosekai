
namespace manganosekai
{
    partial class fmconscategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmconscategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.gbdatacadastro = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbConsFuncionario.SuspendLayout();
            this.gbdatacadastro.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbNome.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(177)))), ((int)(((byte)(52)))));
            this.pnTituloFuncionario.Controls.Add(this.btSair);
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Controls.Add(this.label10);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(0, -1);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1160, 50);
            this.pnTituloFuncionario.TabIndex = 53;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(1112, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(34, 34);
            this.btSair.TabIndex = 233;
            this.btSair.Text = "X";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(23, 6);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(239, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de categorias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(593, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(447, 23);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir uma editora, selecione na grid!!!";
            // 
            // gbConsFuncionario
            // 
            this.gbConsFuncionario.Controls.Add(this.gbdatacadastro);
            this.gbConsFuncionario.Controls.Add(this.gbStatus);
            this.gbConsFuncionario.Controls.Add(this.gbOpcao);
            this.gbConsFuncionario.Controls.Add(this.btPesquisar);
            this.gbConsFuncionario.Controls.Add(this.gbNome);
            this.gbConsFuncionario.Controls.Add(this.gbTipoPesquisa);
            this.gbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsFuncionario.Location = new System.Drawing.Point(12, 55);
            this.gbConsFuncionario.Name = "gbConsFuncionario";
            this.gbConsFuncionario.Size = new System.Drawing.Size(378, 323);
            this.gbConsFuncionario.TabIndex = 52;
            this.gbConsFuncionario.TabStop = false;
            // 
            // gbdatacadastro
            // 
            this.gbdatacadastro.Controls.Add(this.label8);
            this.gbdatacadastro.Controls.Add(this.dtpDataCadastro);
            this.gbdatacadastro.Location = new System.Drawing.Point(6, 168);
            this.gbdatacadastro.Name = "gbdatacadastro";
            this.gbdatacadastro.Size = new System.Drawing.Size(179, 65);
            this.gbdatacadastro.TabIndex = 114;
            this.gbdatacadastro.TabStop = false;
            this.gbdatacadastro.Text = "Data de Cadastro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "De:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(42, 25);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(131, 27);
            this.dtpDataCadastro.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(199, 168);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(164, 65);
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
            this.btPesquisar.Location = new System.Drawing.Point(95, 248);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btPesquisar.Size = new System.Drawing.Size(174, 59);
            this.btPesquisar.TabIndex = 111;
            this.btPesquisar.Text = "     Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbNome
            // 
            this.gbNome.Controls.Add(this.tbnome);
            this.gbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.Location = new System.Drawing.Point(6, 97);
            this.gbNome.Name = "gbNome";
            this.gbNome.Size = new System.Drawing.Size(179, 65);
            this.gbNome.TabIndex = 0;
            this.gbNome.TabStop = false;
            this.gbNome.Text = "Nome:";
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(6, 25);
            this.tbnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbnome.MaxLength = 50;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(167, 27);
            this.tbnome.TabIndex = 0;
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(201, 97);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(162, 65);
            this.gbTipoPesquisa.TabIndex = 102;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(79, 27);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(77, 23);
            this.rbContem.TabIndex = 2;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Checked = true;
            this.rbInicio.Location = new System.Drawing.Point(6, 27);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(62, 23);
            this.rbInicio.TabIndex = 1;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCategoria.Location = new System.Drawing.Point(396, 65);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(721, 313);
            this.dgvCategoria.TabIndex = 54;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargo_CellContentClick);
            // 
            // fmconscategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 394);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Controls.Add(this.gbConsFuncionario);
            this.Controls.Add(this.dgvCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmconscategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmconscategoria";
            this.Load += new System.EventHandler(this.fmconscategoria_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbConsFuncionario.ResumeLayout(false);
            this.gbdatacadastro.ResumeLayout(false);
            this.gbdatacadastro.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbConsFuncionario;
        public System.Windows.Forms.GroupBox gbdatacadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        public System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        public System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Button btPesquisar;
        public System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.TextBox tbnome;
        public System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}