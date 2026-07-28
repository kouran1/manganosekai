
namespace manganosekai
{
    partial class fmconscliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmconscliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.gbdatacadastro = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.gbTelefone = new System.Windows.Forms.GroupBox();
            this.mtbtelcelular = new System.Windows.Forms.MaskedTextBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cboxcidade = new System.Windows.Forms.ComboBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cboxsexo = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.cboxopcoes = new System.Windows.Forms.ComboBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbCPF = new System.Windows.Forms.GroupBox();
            this.mtboxcpf = new System.Windows.Forms.MaskedTextBox();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbConsFuncionario.SuspendLayout();
            this.gbdatacadastro.SuspendLayout();
            this.gbTelefone.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbCPF.SuspendLayout();
            this.gbNome.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(177)))), ((int)(((byte)(52)))));
            this.pnTituloFuncionario.Controls.Add(this.btSair);
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Controls.Add(this.label10);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1227, 38);
            this.pnTituloFuncionario.TabIndex = 53;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(1150, 0);
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
            this.lbTitulo.Location = new System.Drawing.Point(22, 3);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(203, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(549, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(474, 23);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir  um funcionário, selecione na grid!!!";
            // 
            // gbConsFuncionario
            // 
            this.gbConsFuncionario.Controls.Add(this.gbdatacadastro);
            this.gbConsFuncionario.Controls.Add(this.gbTelefone);
            this.gbConsFuncionario.Controls.Add(this.gbEmail);
            this.gbConsFuncionario.Controls.Add(this.gbCidade);
            this.gbConsFuncionario.Controls.Add(this.gbSexo);
            this.gbConsFuncionario.Controls.Add(this.gbStatus);
            this.gbConsFuncionario.Controls.Add(this.gbOpcao);
            this.gbConsFuncionario.Controls.Add(this.btPesquisar);
            this.gbConsFuncionario.Controls.Add(this.gbCPF);
            this.gbConsFuncionario.Controls.Add(this.gbNome);
            this.gbConsFuncionario.Controls.Add(this.gbTipoPesquisa);
            this.gbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsFuncionario.Location = new System.Drawing.Point(0, 35);
            this.gbConsFuncionario.Name = "gbConsFuncionario";
            this.gbConsFuncionario.Size = new System.Drawing.Size(408, 458);
            this.gbConsFuncionario.TabIndex = 52;
            this.gbConsFuncionario.TabStop = false;
            this.gbConsFuncionario.Enter += new System.EventHandler(this.gbConsFuncionario_Enter);
            // 
            // gbdatacadastro
            // 
            this.gbdatacadastro.Controls.Add(this.label8);
            this.gbdatacadastro.Controls.Add(this.dtpDataCadastro);
            this.gbdatacadastro.Location = new System.Drawing.Point(6, 300);
            this.gbdatacadastro.Name = "gbdatacadastro";
            this.gbdatacadastro.Size = new System.Drawing.Size(219, 65);
            this.gbdatacadastro.TabIndex = 115;
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
            this.dtpDataCadastro.Size = new System.Drawing.Size(158, 27);
            this.dtpDataCadastro.TabIndex = 0;
            // 
            // gbTelefone
            // 
            this.gbTelefone.Controls.Add(this.mtbtelcelular);
            this.gbTelefone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelefone.Location = new System.Drawing.Point(174, 234);
            this.gbTelefone.Name = "gbTelefone";
            this.gbTelefone.Size = new System.Drawing.Size(219, 60);
            this.gbTelefone.TabIndex = 113;
            this.gbTelefone.TabStop = false;
            this.gbTelefone.Text = "Telefone celular:";
            // 
            // mtbtelcelular
            // 
            this.mtbtelcelular.Location = new System.Drawing.Point(6, 23);
            this.mtbtelcelular.Mask = "(00)00000-0000";
            this.mtbtelcelular.Name = "mtbtelcelular";
            this.mtbtelcelular.Size = new System.Drawing.Size(207, 27);
            this.mtbtelcelular.TabIndex = 1;
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.tbemail);
            this.gbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmail.Location = new System.Drawing.Point(6, 234);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(158, 60);
            this.gbEmail.TabIndex = 113;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email:";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(6, 23);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbemail.MaxLength = 50;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(146, 27);
            this.tbemail.TabIndex = 1;
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cboxcidade);
            this.gbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.Location = new System.Drawing.Point(174, 168);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(219, 60);
            this.gbCidade.TabIndex = 105;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade:";
            // 
            // cboxcidade
            // 
            this.cboxcidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxcidade.FormattingEnabled = true;
            this.cboxcidade.Location = new System.Drawing.Point(6, 23);
            this.cboxcidade.Name = "cboxcidade";
            this.cboxcidade.Size = new System.Drawing.Size(207, 27);
            this.cboxcidade.TabIndex = 50;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.cboxsexo);
            this.gbSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(6, 168);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(158, 60);
            this.gbSexo.TabIndex = 112;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // cboxsexo
            // 
            this.cboxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxsexo.FormattingEnabled = true;
            this.cboxsexo.Location = new System.Drawing.Point(6, 23);
            this.cboxsexo.Name = "cboxsexo";
            this.cboxsexo.Size = new System.Drawing.Size(142, 27);
            this.cboxsexo.TabIndex = 50;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Location = new System.Drawing.Point(6, 371);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(219, 65);
            this.gbStatus.TabIndex = 102;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Checked = true;
            this.rbInativo.Location = new System.Drawing.Point(109, 25);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 23);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(12, 25);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.cboxopcoes);
            this.gbOpcao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcao.Location = new System.Drawing.Point(6, 26);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(387, 65);
            this.gbOpcao.TabIndex = 4;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Escolha uma Opção de Consulta:";
            // 
            // cboxopcoes
            // 
            this.cboxopcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxopcoes.FormattingEnabled = true;
            this.cboxopcoes.Location = new System.Drawing.Point(6, 26);
            this.cboxopcoes.Name = "cboxopcoes";
            this.cboxopcoes.Size = new System.Drawing.Size(375, 27);
            this.cboxopcoes.TabIndex = 8;
            this.cboxopcoes.SelectedIndexChanged += new System.EventHandler(this.cboxopcoes_SelectedIndexChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(232, 378);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btPesquisar.Size = new System.Drawing.Size(161, 56);
            this.btPesquisar.TabIndex = 111;
            this.btPesquisar.Text = "     Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbCPF
            // 
            this.gbCPF.Controls.Add(this.mtboxcpf);
            this.gbCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCPF.Location = new System.Drawing.Point(232, 300);
            this.gbCPF.Name = "gbCPF";
            this.gbCPF.Size = new System.Drawing.Size(161, 65);
            this.gbCPF.TabIndex = 107;
            this.gbCPF.TabStop = false;
            this.gbCPF.Text = "CPF:";
            // 
            // mtboxcpf
            // 
            this.mtboxcpf.Location = new System.Drawing.Point(6, 23);
            this.mtboxcpf.Mask = "000,000,000-00";
            this.mtboxcpf.Name = "mtboxcpf";
            this.mtboxcpf.Size = new System.Drawing.Size(120, 27);
            this.mtboxcpf.TabIndex = 0;
            // 
            // gbNome
            // 
            this.gbNome.Controls.Add(this.tbnome);
            this.gbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.Location = new System.Drawing.Point(174, 97);
            this.gbNome.Name = "gbNome";
            this.gbNome.Size = new System.Drawing.Size(219, 65);
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
            this.tbnome.Size = new System.Drawing.Size(207, 27);
            this.tbnome.TabIndex = 0;
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(6, 97);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(158, 65);
            this.gbTipoPesquisa.TabIndex = 102;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(71, 27);
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
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCliente.Location = new System.Drawing.Point(414, 44);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(801, 449);
            this.dgvCliente.TabIndex = 54;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // fmconscliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 498);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Controls.Add(this.gbConsFuncionario);
            this.Controls.Add(this.dgvCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmconscliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmconscliente";
            this.Load += new System.EventHandler(this.fmconscliente_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbConsFuncionario.ResumeLayout(false);
            this.gbdatacadastro.ResumeLayout(false);
            this.gbdatacadastro.PerformLayout();
            this.gbTelefone.ResumeLayout(false);
            this.gbTelefone.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbCPF.ResumeLayout(false);
            this.gbCPF.PerformLayout();
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbConsFuncionario;
        private System.Windows.Forms.GroupBox gbTelefone;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox cboxcidade;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cboxsexo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.ComboBox cboxopcoes;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbCPF;
        public System.Windows.Forms.MaskedTextBox mtboxcpf;
        private System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.DataGridView dgvCliente;
        public System.Windows.Forms.MaskedTextBox mtbtelcelular;
        private System.Windows.Forms.TextBox tbemail;
        public System.Windows.Forms.GroupBox gbdatacadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
    }
}