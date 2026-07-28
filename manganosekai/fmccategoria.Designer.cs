
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gboxsituacao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Descricao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcodcategoria);
            this.groupBox1.Location = new System.Drawing.Point(27, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo  categoria";
            // 
            // tbcodcategoria
            // 
            this.tbcodcategoria.Enabled = false;
            this.tbcodcategoria.Location = new System.Drawing.Point(14, 17);
            this.tbcodcategoria.Name = "tbcodcategoria";
            this.tbcodcategoria.Size = new System.Drawing.Size(90, 20);
            this.tbcodcategoria.TabIndex = 17;
            // 
            // gboxsituacao
            // 
            this.gboxsituacao.Controls.Add(this.rbinativo);
            this.gboxsituacao.Controls.Add(this.rbativo);
            this.gboxsituacao.Location = new System.Drawing.Point(143, 84);
            this.gboxsituacao.Name = "gboxsituacao";
            this.gboxsituacao.Size = new System.Drawing.Size(153, 44);
            this.gboxsituacao.TabIndex = 5;
            this.gboxsituacao.TabStop = false;
            this.gboxsituacao.Text = "Situação*";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(78, 19);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(57, 17);
            this.rbinativo.TabIndex = 18;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Location = new System.Drawing.Point(6, 19);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(49, 17);
            this.rbativo.TabIndex = 17;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcategoria);
            this.groupBox2.Location = new System.Drawing.Point(27, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nome da categoria";
            // 
            // tbcategoria
            // 
            this.tbcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbcategoria.Location = new System.Drawing.Point(6, 18);
            this.tbcategoria.Name = "tbcategoria";
            this.tbcategoria.Size = new System.Drawing.Size(374, 20);
            this.tbcategoria.TabIndex = 0;
            this.tbcategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcategoria_KeyPress);
            // 
            // Descricao
            // 
            this.Descricao.Controls.Add(this.tboxdescricao);
            this.Descricao.Location = new System.Drawing.Point(27, 187);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(385, 163);
            this.Descricao.TabIndex = 8;
            this.Descricao.TabStop = false;
            this.Descricao.Text = "Descrição";
            // 
            // tboxdescricao
            // 
            this.tboxdescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxdescricao.Location = new System.Drawing.Point(6, 19);
            this.tboxdescricao.Multiline = true;
            this.tboxdescricao.Name = "tboxdescricao";
            this.tboxdescricao.Size = new System.Drawing.Size(373, 137);
            this.tboxdescricao.TabIndex = 6;
            // 
            // btvoltar
            // 
            this.btvoltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(317, 356);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(95, 34);
            this.btvoltar.TabIndex = 15;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.Location = new System.Drawing.Point(221, 356);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(90, 34);
            this.btexcluir.TabIndex = 14;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.Location = new System.Drawing.Point(125, 356);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(90, 34);
            this.btatualizar.TabIndex = 13;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Location = new System.Drawing.Point(27, 356);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(96, 34);
            this.btcadastrar.TabIndex = 12;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbdata);
            this.groupBox3.Location = new System.Drawing.Point(302, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data cadastro";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Location = new System.Drawing.Point(12, 20);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(35, 13);
            this.lbdata.TabIndex = 0;
            this.lbdata.Text = "label2";
            this.lbdata.Click += new System.EventHandler(this.lbdata_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(177)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 35);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de categoria";
            // 
            // fmccategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gboxsituacao);
            this.Controls.Add(this.groupBox1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbcategoria;
        public System.Windows.Forms.TextBox tboxdescricao;
        public System.Windows.Forms.Label lbdata;
        public System.Windows.Forms.RadioButton rbinativo;
        public System.Windows.Forms.RadioButton rbativo;
        public System.Windows.Forms.TextBox tbcodcategoria;
    }
}

