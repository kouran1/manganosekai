
namespace manganosekai
{
    partial class fmcautor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmcautor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcodigoautor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbnomeautor = new System.Windows.Forms.TextBox();
            this.gboxsituacao = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gboxnacionalidade = new System.Windows.Forms.GroupBox();
            this.cboxnacionalidade = new System.Windows.Forms.ComboBox();
            this.tbdescricao = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.GroupBox();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbdata = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gboxsituacao.SuspendLayout();
            this.gboxnacionalidade.SuspendLayout();
            this.Descricao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcodigoautor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cód.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbcodigoautor
            // 
            this.tbcodigoautor.Enabled = false;
            this.tbcodigoautor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigoautor.Location = new System.Drawing.Point(10, 18);
            this.tbcodigoautor.Name = "tbcodigoautor";
            this.tbcodigoautor.Size = new System.Drawing.Size(74, 22);
            this.tbcodigoautor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbnomeautor);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome do autor";
            // 
            // tbnomeautor
            // 
            this.tbnomeautor.Location = new System.Drawing.Point(6, 17);
            this.tbnomeautor.MaxLength = 40;
            this.tbnomeautor.Name = "tbnomeautor";
            this.tbnomeautor.Size = new System.Drawing.Size(222, 22);
            this.tbnomeautor.TabIndex = 0;
            this.tbnomeautor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnomeautor_KeyPress);
            // 
            // gboxsituacao
            // 
            this.gboxsituacao.Controls.Add(this.rbinativo);
            this.gboxsituacao.Controls.Add(this.rbativo);
            this.gboxsituacao.Location = new System.Drawing.Point(117, 44);
            this.gboxsituacao.Name = "gboxsituacao";
            this.gboxsituacao.Size = new System.Drawing.Size(132, 44);
            this.gboxsituacao.TabIndex = 1;
            this.gboxsituacao.TabStop = false;
            this.gboxsituacao.Text = "Situação*";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbinativo.Location = new System.Drawing.Point(61, 20);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(60, 19);
            this.rbinativo.TabIndex = 15;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbativo.Location = new System.Drawing.Point(6, 20);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(50, 19);
            this.rbativo.TabIndex = 14;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gboxnacionalidade
            // 
            this.gboxnacionalidade.Controls.Add(this.cboxnacionalidade);
            this.gboxnacionalidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxnacionalidade.Location = new System.Drawing.Point(265, 94);
            this.gboxnacionalidade.Name = "gboxnacionalidade";
            this.gboxnacionalidade.Size = new System.Drawing.Size(104, 44);
            this.gboxnacionalidade.TabIndex = 4;
            this.gboxnacionalidade.TabStop = false;
            this.gboxnacionalidade.Text = "Nacionalidade";
            // 
            // cboxnacionalidade
            // 
            this.cboxnacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxnacionalidade.FormattingEnabled = true;
            this.cboxnacionalidade.Location = new System.Drawing.Point(6, 15);
            this.cboxnacionalidade.Name = "cboxnacionalidade";
            this.cboxnacionalidade.Size = new System.Drawing.Size(92, 24);
            this.cboxnacionalidade.TabIndex = 0;
            // 
            // tbdescricao
            // 
            this.tbdescricao.Location = new System.Drawing.Point(6, 19);
            this.tbdescricao.MaxLength = 120;
            this.tbdescricao.Multiline = true;
            this.tbdescricao.Name = "tbdescricao";
            this.tbdescricao.Size = new System.Drawing.Size(336, 137);
            this.tbdescricao.TabIndex = 6;
            // 
            // Descricao
            // 
            this.Descricao.Controls.Add(this.tbdescricao);
            this.Descricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.Location = new System.Drawing.Point(21, 146);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(348, 163);
            this.Descricao.TabIndex = 5;
            this.Descricao.TabStop = false;
            this.Descricao.Text = "Descrição";
            this.Descricao.Enter += new System.EventHandler(this.Descricao_Enter);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btcadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btcadastrar.Image")));
            this.btcadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcadastrar.Location = new System.Drawing.Point(21, 315);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(84, 34);
            this.btcadastrar.TabIndex = 6;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(111, 315);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(77, 34);
            this.btatualizar.TabIndex = 7;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexcluir.Location = new System.Drawing.Point(194, 315);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(79, 34);
            this.btexcluir.TabIndex = 8;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbdata);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(255, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data de cadastro";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata.Location = new System.Drawing.Point(7, 20);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(42, 16);
            this.lbdata.TabIndex = 0;
            this.lbdata.Text = "label1";
            this.lbdata.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(388, 27);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(161, 22);
            this.toolStripStatusLabel1.Text = "Cadastro de autor";
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btvoltar.Image")));
            this.btvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvoltar.Location = new System.Drawing.Point(279, 316);
            this.btvoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(90, 33);
            this.btvoltar.TabIndex = 20;
            this.btvoltar.Text = "Sair";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click_1);
            // 
            // fmcautor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(388, 371);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.gboxnacionalidade);
            this.Controls.Add(this.gboxsituacao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmcautor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de autores";
            this.Load += new System.EventHandler(this.fmcautor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gboxsituacao.ResumeLayout(false);
            this.gboxsituacao.PerformLayout();
            this.gboxnacionalidade.ResumeLayout(false);
            this.Descricao.ResumeLayout(false);
            this.Descricao.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gboxsituacao;
        private System.Windows.Forms.GroupBox gboxnacionalidade;
        private System.Windows.Forms.GroupBox Descricao;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbcodigoautor;
        public System.Windows.Forms.TextBox tbnomeautor;
        public System.Windows.Forms.ComboBox cboxnacionalidade;
        public System.Windows.Forms.TextBox tbdescricao;
        public System.Windows.Forms.Label lbdata;
        public System.Windows.Forms.RadioButton rbinativo;
        public System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btvoltar;
    }
}
