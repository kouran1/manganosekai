
namespace manganosekai
{
    partial class fmccategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmccategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcodcategoria = new System.Windows.Forms.TextBox();
            this.gboxsituacao = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbcategoria = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.GroupBox();
            this.tboxdescricao = new System.Windows.Forms.TextBox();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbdata = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.gboxsituacao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Descricao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcodcategoria);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo";
            // 
            // tbcodcategoria
            // 
            this.tbcodcategoria.Enabled = false;
            this.tbcodcategoria.Location = new System.Drawing.Point(7, 19);
            this.tbcodcategoria.Name = "tbcodcategoria";
            this.tbcodcategoria.Size = new System.Drawing.Size(114, 22);
            this.tbcodcategoria.TabIndex = 17;
            // 
            // gboxsituacao
            // 
            this.gboxsituacao.Controls.Add(this.rbinativo);
            this.gboxsituacao.Controls.Add(this.rbativo);
            this.gboxsituacao.Location = new System.Drawing.Point(154, 66);
            this.gboxsituacao.Name = "gboxsituacao";
            this.gboxsituacao.Size = new System.Drawing.Size(178, 50);
            this.gboxsituacao.TabIndex = 5;
            this.gboxsituacao.TabStop = false;
            this.gboxsituacao.Text = "Situação*";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(91, 21);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(60, 19);
            this.rbinativo.TabIndex = 18;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Location = new System.Drawing.Point(7, 21);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(50, 19);
            this.rbativo.TabIndex = 17;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcategoria);
            this.groupBox2.Location = new System.Drawing.Point(18, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome da categoria";
            // 
            // tbcategoria
            // 
            this.tbcategoria.Location = new System.Drawing.Point(7, 20);
            this.tbcategoria.Name = "tbcategoria";
            this.tbcategoria.Size = new System.Drawing.Size(436, 21);
            this.tbcategoria.TabIndex = 0;
            this.tbcategoria.TextChanged += new System.EventHandler(this.tbcategoria_TextChanged);
            this.tbcategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcategoria_KeyPress);
            // 
            // Descricao
            // 
            this.Descricao.Controls.Add(this.tboxdescricao);
            this.Descricao.Location = new System.Drawing.Point(18, 185);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(449, 189);
            this.Descricao.TabIndex = 8;
            this.Descricao.TabStop = false;
            this.Descricao.Text = "Descrição";
            // 
            // tboxdescricao
            // 
            this.tboxdescricao.Location = new System.Drawing.Point(7, 21);
            this.tboxdescricao.Multiline = true;
            this.tboxdescricao.Name = "tboxdescricao";
            this.tboxdescricao.Size = new System.Drawing.Size(436, 157);
            this.tboxdescricao.TabIndex = 6;
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btvoltar.Image")));
            this.btvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvoltar.Location = new System.Drawing.Point(356, 380);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(110, 40);
            this.btvoltar.TabIndex = 15;
            this.btvoltar.Text = "Sair";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexcluir.Location = new System.Drawing.Point(245, 380);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(105, 40);
            this.btexcluir.TabIndex = 14;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(136, 380);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(105, 40);
            this.btatualizar.TabIndex = 13;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btcadastrar.Image")));
            this.btcadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcadastrar.Location = new System.Drawing.Point(18, 380);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(112, 40);
            this.btcadastrar.TabIndex = 12;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbdata);
            this.groupBox3.Location = new System.Drawing.Point(339, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data cadastro";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Location = new System.Drawing.Point(14, 24);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(31, 15);
            this.lbdata.TabIndex = 0;
            this.lbdata.Text = "data";
            this.lbdata.Click += new System.EventHandler(this.lbdata_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(478, 27);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 22);
            this.toolStripStatusLabel1.Text = "Cadastro de categoria";
            // 
            // fmccategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(478, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gboxsituacao);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmccategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmccategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxsituacao.ResumeLayout(false);
            this.gboxsituacao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox gboxsituacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Descricao;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbcategoria;
        public System.Windows.Forms.TextBox tboxdescricao;
        public System.Windows.Forms.Label lbdata;
        public System.Windows.Forms.RadioButton rbinativo;
        public System.Windows.Forms.RadioButton rbativo;
        public System.Windows.Forms.TextBox tbcodcategoria;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

