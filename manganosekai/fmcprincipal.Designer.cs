
namespace manganosekai
{
    partial class fmcprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmcprincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menucadcargo = new System.Windows.Forms.ToolStripMenuItem();
            this.menucadfuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.tslTipoAcesso = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslbmensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.statusPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AllowMerge = false;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuConsultas,
            this.menuRelatorio,
            this.menuVendas,
            this.menuSair});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1482, 56);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuPrincipal";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucadcargo,
            this.menucadfuncionario,
            this.autorToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.editoraToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.menuCadastro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastro.Image")));
            this.menuCadastro.MergeIndex = 4;
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Padding = new System.Windows.Forms.Padding(5);
            this.menuCadastro.Size = new System.Drawing.Size(143, 46);
            this.menuCadastro.Text = "Cadastros";
            // 
            // menucadcargo
            // 
            this.menucadcargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucadcargo.Name = "menucadcargo";
            this.menucadcargo.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menucadcargo.Size = new System.Drawing.Size(189, 26);
            this.menucadcargo.Text = "Cargo";
            this.menucadcargo.Click += new System.EventHandler(this.menucadcargo_Click);
            // 
            // menucadfuncionario
            // 
            this.menucadfuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucadfuncionario.Name = "menucadfuncionario";
            this.menucadfuncionario.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menucadfuncionario.Size = new System.Drawing.Size(189, 26);
            this.menucadfuncionario.Text = "Funcionário";
            this.menucadfuncionario.Click += new System.EventHandler(this.menucadfuncionario_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // editoraToolStripMenuItem
            // 
            this.editoraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editoraToolStripMenuItem.Name = "editoraToolStripMenuItem";
            this.editoraToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.editoraToolStripMenuItem.Text = "Editora";
            this.editoraToolStripMenuItem.Click += new System.EventHandler(this.editoraToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargoToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.autorToolStripMenuItem1,
            this.categoriaToolStripMenuItem1,
            this.editoraToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.produtoToolStripMenuItem1});
            this.menuConsultas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConsultas.Image = ((System.Drawing.Image)(resources.GetObject("menuConsultas.Image")));
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Padding = new System.Windows.Forms.Padding(5);
            this.menuConsultas.Size = new System.Drawing.Size(140, 46);
            this.menuConsultas.Text = "Consultas";
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem1
            // 
            this.autorToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorToolStripMenuItem1.Name = "autorToolStripMenuItem1";
            this.autorToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.autorToolStripMenuItem1.Text = "Autor";
            this.autorToolStripMenuItem1.Click += new System.EventHandler(this.autorToolStripMenuItem1_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // editoraToolStripMenuItem1
            // 
            this.editoraToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editoraToolStripMenuItem1.Name = "editoraToolStripMenuItem1";
            this.editoraToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.editoraToolStripMenuItem1.Text = "Editora";
            this.editoraToolStripMenuItem1.Click += new System.EventHandler(this.editoraToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // menuRelatorio
            // 
            this.menuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem1,
            this.clienteToolStripMenuItem2,
            this.produtoToolStripMenuItem2,
            this.vendasToolStripMenuItem});
            this.menuRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("menuRelatorio.Image")));
            this.menuRelatorio.Name = "menuRelatorio";
            this.menuRelatorio.Padding = new System.Windows.Forms.Padding(5);
            this.menuRelatorio.Size = new System.Drawing.Size(142, 46);
            this.menuRelatorio.Text = "Relatórios";
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.funcionarioToolStripMenuItem1.Text = "Funcionário";
            this.funcionarioToolStripMenuItem1.Click += new System.EventHandler(this.funcionarioToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // produtoToolStripMenuItem2
            // 
            this.produtoToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoToolStripMenuItem2.Name = "produtoToolStripMenuItem2";
            this.produtoToolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.produtoToolStripMenuItem2.Text = "Produto";
            this.produtoToolStripMenuItem2.Click += new System.EventHandler(this.produtoToolStripMenuItem2_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVendas.Image = ((System.Drawing.Image)(resources.GetObject("menuVendas.Image")));
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(118, 46);
            this.menuVendas.Text = "Vendas";
            this.menuVendas.Click += new System.EventHandler(this.menuVendas_Click);
            // 
            // menuSair
            // 
            this.menuSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.Image = ((System.Drawing.Image)(resources.GetObject("menuSair.Image")));
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(87, 46);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.statusPrincipal.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTipoAcesso,
            this.statuslbhora,
            this.statuslbdata,
            this.statuslbmensagem});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 667);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusPrincipal.Size = new System.Drawing.Size(1482, 22);
            this.statusPrincipal.TabIndex = 1;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // tslTipoAcesso
            // 
            this.tslTipoAcesso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslTipoAcesso.Name = "tslTipoAcesso";
            this.tslTipoAcesso.Size = new System.Drawing.Size(74, 17);
            this.tslTipoAcesso.Text = "Tipo Acesso";
            // 
            // statuslbhora
            // 
            this.statuslbhora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbhora.Name = "statuslbhora";
            this.statuslbhora.Size = new System.Drawing.Size(34, 17);
            this.statuslbhora.Text = "Hora";
            // 
            // statuslbdata
            // 
            this.statuslbdata.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbdata.Name = "statuslbdata";
            this.statuslbdata.Size = new System.Drawing.Size(35, 17);
            this.statuslbdata.Text = "Data";
            // 
            // statuslbmensagem
            // 
            this.statuslbmensagem.BackColor = System.Drawing.Color.Transparent;
            this.statuslbmensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbmensagem.Margin = new System.Windows.Forms.Padding(0, 3, 4, 2);
            this.statuslbmensagem.Name = "statuslbmensagem";
            this.statuslbmensagem.Size = new System.Drawing.Size(186, 17);
            this.statuslbmensagem.Text = "Bem-vindo ao Mangá no Sekai";
            this.statuslbmensagem.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // fmcprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 689);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimizeBox = false;
            this.Name = "fmcprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mangá No Sekai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmcprincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menucadcargo;
        private System.Windows.Forms.ToolStripMenuItem menucadfuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripStatusLabel statuslbdata;
        private System.Windows.Forms.ToolStripStatusLabel statuslbhora;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem2;
        public System.Windows.Forms.ToolStripStatusLabel statuslbmensagem;
        public System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tslTipoAcesso;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}
