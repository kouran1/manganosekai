
namespace manganosekai
{
    partial class formRelCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelCliente));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbConsFuncionario = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
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
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.cboxopcoes = new System.Windows.Forms.ComboBox();
            this.gbCPF = new System.Windows.Forms.GroupBox();
            this.mtboxcpf = new System.Windows.Forms.MaskedTextBox();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gbConsFuncionario.SuspendLayout();
            this.gbdatacadastro.SuspendLayout();
            this.gbTelefone.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbCPF.SuspendLayout();
            this.gbNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // classClienteBindingSource
            // 
            this.classClienteBindingSource.DataSource = typeof(manganosekai.classCliente);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1145, 27);
            this.statusStrip1.TabIndex = 147;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(173, 22);
            this.toolStripStatusLabel1.Text = "Relatório de cliente";
            // 
            // gbConsFuncionario
            // 
            this.gbConsFuncionario.Controls.Add(this.btSair);
            this.gbConsFuncionario.Controls.Add(this.btGerarRelatorio);
            this.gbConsFuncionario.Controls.Add(this.gbdatacadastro);
            this.gbConsFuncionario.Controls.Add(this.gbTelefone);
            this.gbConsFuncionario.Controls.Add(this.gbEmail);
            this.gbConsFuncionario.Controls.Add(this.gbCidade);
            this.gbConsFuncionario.Controls.Add(this.gbSexo);
            this.gbConsFuncionario.Controls.Add(this.gbStatus);
            this.gbConsFuncionario.Controls.Add(this.gbTipoPesquisa);
            this.gbConsFuncionario.Controls.Add(this.gbCPF);
            this.gbConsFuncionario.Controls.Add(this.gbNome);
            this.gbConsFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsFuncionario.Location = new System.Drawing.Point(12, 30);
            this.gbConsFuncionario.Name = "gbConsFuncionario";
            this.gbConsFuncionario.Size = new System.Drawing.Size(408, 458);
            this.gbConsFuncionario.TabIndex = 148;
            this.gbConsFuncionario.TabStop = false;
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(231, 385);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(162, 58);
            this.btSair.TabIndex = 147;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(12, 385);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(213, 58);
            this.btGerarRelatorio.TabIndex = 132;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbdatacadastro
            // 
            this.gbdatacadastro.Controls.Add(this.label8);
            this.gbdatacadastro.Controls.Add(this.dtpDataCadastro);
            this.gbdatacadastro.Location = new System.Drawing.Point(235, 234);
            this.gbdatacadastro.Name = "gbdatacadastro";
            this.gbdatacadastro.Size = new System.Drawing.Size(158, 65);
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
            this.dtpDataCadastro.Size = new System.Drawing.Size(110, 27);
            this.dtpDataCadastro.TabIndex = 0;
            // 
            // gbTelefone
            // 
            this.gbTelefone.Controls.Add(this.mtbtelcelular);
            this.gbTelefone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelefone.Location = new System.Drawing.Point(6, 234);
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
            this.gbEmail.Location = new System.Drawing.Point(235, 168);
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
            this.gbCidade.Location = new System.Drawing.Point(6, 168);
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
            this.gbSexo.Location = new System.Drawing.Point(235, 102);
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
            this.gbStatus.Location = new System.Drawing.Point(235, 300);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(158, 65);
            this.gbStatus.TabIndex = 102;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Checked = true;
            this.rbInativo.Location = new System.Drawing.Point(77, 25);
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
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.cboxopcoes);
            this.gbTipoPesquisa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPesquisa.Location = new System.Drawing.Point(6, 26);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(387, 65);
            this.gbTipoPesquisa.TabIndex = 4;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Escolha uma Opção de Consulta:";
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
            // gbCPF
            // 
            this.gbCPF.Controls.Add(this.mtboxcpf);
            this.gbCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCPF.Location = new System.Drawing.Point(6, 300);
            this.gbCPF.Name = "gbCPF";
            this.gbCPF.Size = new System.Drawing.Size(219, 65);
            this.gbCPF.TabIndex = 107;
            this.gbCPF.TabStop = false;
            this.gbCPF.Text = "CPF:";
            // 
            // mtboxcpf
            // 
            this.mtboxcpf.Location = new System.Drawing.Point(6, 23);
            this.mtboxcpf.Mask = "000,000,000-00";
            this.mtboxcpf.Name = "mtboxcpf";
            this.mtboxcpf.Size = new System.Drawing.Size(207, 27);
            this.mtboxcpf.TabIndex = 0;
            // 
            // gbNome
            // 
            this.gbNome.Controls.Add(this.tbnome);
            this.gbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.Location = new System.Drawing.Point(6, 97);
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "manganosekai.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(426, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(707, 441);
            this.reportViewer1.TabIndex = 149;
            // 
            // formRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 498);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbConsFuncionario);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRelCliente";
            this.Load += new System.EventHandler(this.formRelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbCPF.ResumeLayout(false);
            this.gbCPF.PerformLayout();
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbConsFuncionario;
        public System.Windows.Forms.GroupBox gbdatacadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.GroupBox gbTelefone;
        public System.Windows.Forms.MaskedTextBox mtbtelcelular;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox cboxcidade;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cboxsexo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.ComboBox cboxopcoes;
        private System.Windows.Forms.GroupBox gbCPF;
        public System.Windows.Forms.MaskedTextBox mtboxcpf;
        private System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.BindingSource classClienteBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
