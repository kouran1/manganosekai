
namespace manganosekai
{
    partial class fmccargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmccargo));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbdatacadastro = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.Descricao = new System.Windows.Forms.GroupBox();
            this.tbobservacao = new System.Windows.Forms.TextBox();
            this.gboxsituacao = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbcargo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcodigocargo = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            this.Descricao.SuspendLayout();
            this.gboxsituacao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbdatacadastro);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(306, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(163, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data de cadastro";
            // 
            // lbdatacadastro
            // 
            this.lbdatacadastro.AutoSize = true;
            this.lbdatacadastro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatacadastro.Location = new System.Drawing.Point(24, 27);
            this.lbdatacadastro.Name = "lbdatacadastro";
            this.lbdatacadastro.Size = new System.Drawing.Size(29, 14);
            this.lbdatacadastro.TabIndex = 1;
            this.lbdatacadastro.Text = "Data";
            this.lbdatacadastro.Click += new System.EventHandler(this.lbdatacadastro_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btvoltar.Image")));
            this.btvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvoltar.Location = new System.Drawing.Point(360, 353);
            this.btvoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(109, 42);
            this.btvoltar.TabIndex = 8;
            this.btvoltar.Text = "Sair";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexcluir.Location = new System.Drawing.Point(251, 353);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(100, 42);
            this.btexcluir.TabIndex = 7;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(142, 353);
            this.btatualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(100, 42);
            this.btatualizar.TabIndex = 6;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btcadastrar.Image")));
            this.btcadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcadastrar.Location = new System.Drawing.Point(33, 353);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(100, 42);
            this.btcadastrar.TabIndex = 5;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // Descricao
            // 
            this.Descricao.Controls.Add(this.tbobservacao);
            this.Descricao.Location = new System.Drawing.Point(33, 180);
            this.Descricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Descricao.Name = "Descricao";
            this.Descricao.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Descricao.Size = new System.Drawing.Size(436, 165);
            this.Descricao.TabIndex = 4;
            this.Descricao.TabStop = false;
            this.Descricao.Text = "Descrição";
            // 
            // tbobservacao
            // 
            this.tbobservacao.Location = new System.Drawing.Point(12, 23);
            this.tbobservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbobservacao.Multiline = true;
            this.tbobservacao.Name = "tbobservacao";
            this.tbobservacao.Size = new System.Drawing.Size(417, 132);
            this.tbobservacao.TabIndex = 0;
            // 
            // gboxsituacao
            // 
            this.gboxsituacao.Controls.Add(this.rbinativo);
            this.gboxsituacao.Controls.Add(this.rbativo);
            this.gboxsituacao.Enabled = false;
            this.gboxsituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gboxsituacao.Location = new System.Drawing.Point(145, 57);
            this.gboxsituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxsituacao.Name = "gboxsituacao";
            this.gboxsituacao.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxsituacao.Size = new System.Drawing.Size(154, 54);
            this.gboxsituacao.TabIndex = 1;
            this.gboxsituacao.TabStop = false;
            this.gboxsituacao.Text = "Situação*";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(71, 22);
            this.rbinativo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(62, 20);
            this.rbinativo.TabIndex = 1;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            this.rbinativo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Location = new System.Drawing.Point(7, 22);
            this.rbativo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(54, 20);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcargo);
            this.groupBox2.Location = new System.Drawing.Point(33, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(436, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargo";
            // 
            // tbcargo
            // 
            this.tbcargo.Location = new System.Drawing.Point(12, 22);
            this.tbcargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcargo.Name = "tbcargo";
            this.tbcargo.Size = new System.Drawing.Size(417, 22);
            this.tbcargo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcodigocargo);
            this.groupBox1.Location = new System.Drawing.Point(33, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(105, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código";
            // 
            // tbcodigocargo
            // 
            this.tbcodigocargo.Enabled = false;
            this.tbcodigocargo.Location = new System.Drawing.Point(12, 22);
            this.tbcodigocargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcodigocargo.Name = "tbcodigocargo";
            this.tbcodigocargo.Size = new System.Drawing.Size(86, 22);
            this.tbcodigocargo.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 27);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 22);
            this.toolStripStatusLabel1.Text = "Cadastro de cargo";
            // 
            // fmccargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(512, 430);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.gboxsituacao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmccargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmccargo";
            this.Load += new System.EventHandler(this.fmccargo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Descricao.ResumeLayout(false);
            this.Descricao.PerformLayout();
            this.gboxsituacao.ResumeLayout(false);
            this.gboxsituacao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.GroupBox Descricao;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbobservacao;
        public System.Windows.Forms.TextBox tbcargo;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox gboxsituacao;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbcodigocargo;
        public System.Windows.Forms.RadioButton rbinativo;
        public System.Windows.Forms.RadioButton rbativo;
        public System.Windows.Forms.Label lbdatacadastro;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
