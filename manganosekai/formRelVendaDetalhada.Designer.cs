
namespace manganosekai
{
    partial class formRelVendaDetalhada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelVendaDetalhada));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gbfiltro = new System.Windows.Forms.GroupBox();
            this.cbMetodoFiltro = new System.Windows.Forms.ComboBox();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.checkIntervalorFuncionario = new System.Windows.Forms.CheckBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbIntervalo = new System.Windows.Forms.GroupBox();
            this.dtpfim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpini = new System.Windows.Forms.DateTimePicker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.checkClienteIntervalo = new System.Windows.Forms.CheckBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.btnGerarReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.classReportVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbfiltro.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.gbIntervalo.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classReportVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfiltro
            // 
            this.gbfiltro.Controls.Add(this.cbMetodoFiltro);
            this.gbfiltro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfiltro.Location = new System.Drawing.Point(12, 40);
            this.gbfiltro.Name = "gbfiltro";
            this.gbfiltro.Size = new System.Drawing.Size(278, 56);
            this.gbfiltro.TabIndex = 124;
            this.gbfiltro.TabStop = false;
            this.gbfiltro.Text = "Método de filtro";
            // 
            // cbMetodoFiltro
            // 
            this.cbMetodoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodoFiltro.FormattingEnabled = true;
            this.cbMetodoFiltro.Location = new System.Drawing.Point(6, 21);
            this.cbMetodoFiltro.Name = "cbMetodoFiltro";
            this.cbMetodoFiltro.Size = new System.Drawing.Size(266, 26);
            this.cbMetodoFiltro.TabIndex = 0;
            this.cbMetodoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbMetodoFiltro_SelectedIndexChanged);
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.checkIntervalorFuncionario);
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.Location = new System.Drawing.Point(12, 102);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(278, 80);
            this.gbFuncionario.TabIndex = 125;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionário";
            // 
            // checkIntervalorFuncionario
            // 
            this.checkIntervalorFuncionario.AutoSize = true;
            this.checkIntervalorFuncionario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIntervalorFuncionario.Location = new System.Drawing.Point(11, 59);
            this.checkIntervalorFuncionario.Name = "checkIntervalorFuncionario";
            this.checkIntervalorFuncionario.Size = new System.Drawing.Size(150, 19);
            this.checkIntervalorFuncionario.TabIndex = 132;
            this.checkIntervalorFuncionario.Text = "Procurar por intervalo?";
            this.checkIntervalorFuncionario.UseVisualStyleBackColor = true;
            this.checkIntervalorFuncionario.CheckedChanged += new System.EventHandler(this.checkIntervalorFuncionario_CheckedChanged);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(7, 25);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(265, 27);
            this.cbFuncionario.TabIndex = 131;
            // 
            // gbIntervalo
            // 
            this.gbIntervalo.Controls.Add(this.dtpfim);
            this.gbIntervalo.Controls.Add(this.label1);
            this.gbIntervalo.Controls.Add(this.dtpini);
            this.gbIntervalo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIntervalo.Location = new System.Drawing.Point(12, 474);
            this.gbIntervalo.Name = "gbIntervalo";
            this.gbIntervalo.Size = new System.Drawing.Size(278, 71);
            this.gbIntervalo.TabIndex = 126;
            this.gbIntervalo.TabStop = false;
            this.gbIntervalo.Text = "Intervalo";
            // 
            // dtpfim
            // 
            this.dtpfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfim.Location = new System.Drawing.Point(154, 33);
            this.dtpfim.Name = "dtpfim";
            this.dtpfim.Size = new System.Drawing.Size(118, 25);
            this.dtpfim.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 128;
            this.label1.Text = "à";
            // 
            // dtpini
            // 
            this.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpini.Location = new System.Drawing.Point(7, 33);
            this.dtpini.Name = "dtpini";
            this.dtpini.Size = new System.Drawing.Size(119, 25);
            this.dtpini.TabIndex = 127;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.dgvCliente);
            this.gbCliente.Controls.Add(this.checkClienteIntervalo);
            this.gbCliente.Controls.Add(this.btnPesquisarCliente);
            this.gbCliente.Controls.Add(this.tbCliente);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 186);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(278, 280);
            this.gbCliente.TabIndex = 132;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCliente.Location = new System.Drawing.Point(7, 75);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(265, 171);
            this.dgvCliente.TabIndex = 134;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // checkClienteIntervalo
            // 
            this.checkClienteIntervalo.AutoSize = true;
            this.checkClienteIntervalo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClienteIntervalo.Location = new System.Drawing.Point(7, 252);
            this.checkClienteIntervalo.Name = "checkClienteIntervalo";
            this.checkClienteIntervalo.Size = new System.Drawing.Size(150, 19);
            this.checkClienteIntervalo.TabIndex = 133;
            this.checkClienteIntervalo.Text = "Procurar por intervalo?";
            this.checkClienteIntervalo.UseVisualStyleBackColor = true;
            this.checkClienteIntervalo.CheckedChanged += new System.EventHandler(this.checkClienteIntervalo_CheckedChanged);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.Image")));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(208, 21);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(64, 48);
            this.btnPesquisarCliente.TabIndex = 1;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(7, 34);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(195, 25);
            this.tbCliente.TabIndex = 0;
            // 
            // btnGerarReport
            // 
            this.btnGerarReport.AutoSize = true;
            this.btnGerarReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarReport.Image")));
            this.btnGerarReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarReport.Location = new System.Drawing.Point(12, 551);
            this.btnGerarReport.Name = "btnGerarReport";
            this.btnGerarReport.Size = new System.Drawing.Size(161, 44);
            this.btnGerarReport.TabIndex = 133;
            this.btnGerarReport.Text = "Gerar relatório";
            this.btnGerarReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarReport.UseVisualStyleBackColor = true;
            this.btnGerarReport.Click += new System.EventHandler(this.btnGerarReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classReportVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "manganosekai.reportDetalheVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(296, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(832, 555);
            this.reportViewer1.TabIndex = 134;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 135;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1155, 27);
            this.statusStrip1.TabIndex = 136;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(285, 22);
            this.toolStripStatusLabel1.Text = "Relatório de Vendas (Detalhado)";
            // 
            // classReportVendaBindingSource
            // 
            this.classReportVendaBindingSource.DataSource = typeof(manganosekai.classReportVenda);
            // 
            // formRelVendaDetalhada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGerarReport);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbIntervalo);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.gbfiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelVendaDetalhada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de venda detalhado";
            this.Load += new System.EventHandler(this.formRelVendaDetalhada_Load);
            this.gbfiltro.ResumeLayout(false);
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            this.gbIntervalo.ResumeLayout(false);
            this.gbIntervalo.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classReportVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource classReportVendaBindingSource;
        private System.Windows.Forms.GroupBox gbfiltro;
        private System.Windows.Forms.ComboBox cbMetodoFiltro;
        private System.Windows.Forms.GroupBox gbFuncionario;
        public System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox gbIntervalo;
        private System.Windows.Forms.DateTimePicker dtpfim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpini;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.CheckBox checkIntervalorFuncionario;
        private System.Windows.Forms.CheckBox checkClienteIntervalo;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btnGerarReport;
        private System.Windows.Forms.DataGridView dgvCliente;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
