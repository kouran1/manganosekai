
namespace manganosekai
{
    partial class formVenda52
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenda52));
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtPesqCliente = new System.Windows.Forms.TextBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQtdeItens = new System.Windows.Forms.TextBox();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesqProduto = new System.Windows.Forms.TextBox();
            this.btBuscaProduto = new System.Windows.Forms.Button();
            this.btFechaVenda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gbPagamneto = new System.Windows.Forms.GroupBox();
            this.txtTrocoEntregue = new System.Windows.Forms.TextBox();
            this.lbTrocoEntregue = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lbTroco = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbFuncionario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbPagamneto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFormaPagamento.Location = new System.Drawing.Point(10, 61);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(275, 30);
            this.cbFormaPagamento.TabIndex = 224;
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormaPagamento.Location = new System.Drawing.Point(6, 35);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(171, 23);
            this.lbFormaPagamento.TabIndex = 223;
            this.lbFormaPagamento.Text = "* Forma de pagamento:";
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.dgvCliente);
            this.gbClientes.Controls.Add(this.txtPesqCliente);
            this.gbClientes.Controls.Add(this.btBuscaCliente);
            this.gbClientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.Location = new System.Drawing.Point(12, 126);
            this.gbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Padding = new System.Windows.Forms.Padding(4);
            this.gbClientes.Size = new System.Drawing.Size(519, 167);
            this.gbClientes.TabIndex = 212;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "* Pesquisa de Clientes:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.Location = new System.Drawing.Point(7, 70);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(500, 90);
            this.dgvCliente.TabIndex = 4;
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.Location = new System.Drawing.Point(7, 31);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.Size = new System.Drawing.Size(450, 27);
            this.txtPesqCliente.TabIndex = 1;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.Image")));
            this.btBuscaCliente.Location = new System.Drawing.Point(463, 22);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(44, 42);
            this.btBuscaCliente.TabIndex = 3;
            this.btBuscaCliente.UseVisualStyleBackColor = true;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(207, 135);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(149, 30);
            this.txtTotalVenda.TabIndex = 220;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(203, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 219;
            this.label11.Text = "Total da Venda (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 218;
            this.label2.Text = "=";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Enabled = false;
            this.txtTotalDesconto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(85, 136);
            this.txtTotalDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(102, 30);
            this.txtTotalDesconto.TabIndex = 217;
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualDesconto.Location = new System.Drawing.Point(10, 135);
            this.txtPercentualDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentualDesconto.MaxLength = 2;
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.Size = new System.Drawing.Size(60, 30);
            this.txtPercentualDesconto.TabIndex = 216;
            this.txtPercentualDesconto.TextChanged += new System.EventHandler(this.txtPercentualDesconto_TextChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(356, 61);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(151, 30);
            this.txtValorTotal.TabIndex = 215;
            // 
            // txtQtdeItens
            // 
            this.txtQtdeItens.Enabled = false;
            this.txtQtdeItens.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItens.Location = new System.Drawing.Point(375, 135);
            this.txtQtdeItens.Name = "txtQtdeItens";
            this.txtQtdeItens.Size = new System.Drawing.Size(132, 30);
            this.txtQtdeItens.TabIndex = 214;
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtdeEstoque.Enabled = false;
            this.txtQtdeEstoque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEstoque.Location = new System.Drawing.Point(459, 47);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(49, 27);
            this.txtQtdeEstoque.TabIndex = 213;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(12, 47);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(441, 27);
            this.txtProduto.TabIndex = 211;
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.dgvProduto);
            this.gbProdutos.Controls.Add(this.txtPesqProduto);
            this.gbProdutos.Controls.Add(this.btBuscaProduto);
            this.gbProdutos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProdutos.Location = new System.Drawing.Point(540, 44);
            this.gbProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.gbProdutos.Size = new System.Drawing.Size(519, 249);
            this.gbProdutos.TabIndex = 210;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "* Pesquisa de Produtos:";
            this.gbProdutos.Enter += new System.EventHandler(this.gbProdutos_Enter);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProduto.Location = new System.Drawing.Point(7, 60);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(506, 182);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.Location = new System.Drawing.Point(7, 27);
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.Size = new System.Drawing.Size(450, 27);
            this.txtPesqProduto.TabIndex = 1;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.Image")));
            this.btBuscaProduto.Location = new System.Drawing.Point(463, 12);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Size = new System.Drawing.Size(44, 42);
            this.btBuscaProduto.TabIndex = 3;
            this.btBuscaProduto.UseVisualStyleBackColor = true;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFechaVenda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btFechaVenda.Image")));
            this.btFechaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.Location = new System.Drawing.Point(540, 678);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Size = new System.Drawing.Size(242, 67);
            this.btFechaVenda.TabIndex = 209;
            this.btFechaVenda.Text = "       Finalizar Venda";
            this.btFechaVenda.UseVisualStyleBackColor = true;
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 23);
            this.label13.TabIndex = 208;
            this.label13.Text = "Desconto (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(352, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 207;
            this.label10.Text = "Valor Total (R$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 206;
            this.label9.Text = "Qtde Itens:";
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.dgvItens);
            this.gbItensVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItensVenda.Location = new System.Drawing.Point(539, 309);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(520, 363);
            this.gbItensVenda.TabIndex = 205;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "* Itens da Venda:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.Location = new System.Drawing.Point(6, 25);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(508, 332);
            this.dgvItens.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 204;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(294, 101);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 27);
            this.txtTotal.TabIndex = 203;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 202;
            this.label6.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(148, 101);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(105, 27);
            this.txtValor.TabIndex = 201;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 200;
            this.label5.Text = "Qtde";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.White;
            this.txtQtde.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(12, 101);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(95, 27);
            this.txtQtde.TabIndex = 199;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 198;
            this.label4.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 197;
            this.label3.Text = "Produto";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFuncionario.Location = new System.Drawing.Point(7, 29);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(339, 27);
            this.cbFuncionario.TabIndex = 194;
            // 
            // btRemover
            // 
            this.btRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(463, 89);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(45, 48);
            this.btRemover.TabIndex = 230;
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdicionar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionar.Image")));
            this.btAdicionar.Location = new System.Drawing.Point(411, 89);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(45, 48);
            this.btAdicionar.TabIndex = 229;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.Location = new System.Drawing.Point(174, 44);
            this.gbFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Padding = new System.Windows.Forms.Padding(4);
            this.gbFuncionario.Size = new System.Drawing.Size(358, 74);
            this.gbFuncionario.TabIndex = 213;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "* Escolha o Funcionário:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDataVenda);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(154, 74);
            this.groupBox3.TabIndex = 214;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "* Data da venda:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.BackColor = System.Drawing.Color.White;
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Location = new System.Drawing.Point(13, 30);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(121, 27);
            this.txtDataVenda.TabIndex = 232;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtProduto);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtQtde);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btRemover);
            this.groupBox5.Controls.Add(this.txtValor);
            this.groupBox5.Controls.Add(this.btAdicionar);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.txtQtdeEstoque);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 309);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(520, 153);
            this.groupBox5.TabIndex = 211;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "* Produto Selecionado:";
            // 
            // gbPagamneto
            // 
            this.gbPagamneto.Controls.Add(this.txtTrocoEntregue);
            this.gbPagamneto.Controls.Add(this.lbTrocoEntregue);
            this.gbPagamneto.Controls.Add(this.txtTroco);
            this.gbPagamneto.Controls.Add(this.lbTroco);
            this.gbPagamneto.Controls.Add(this.txtValorRecebido);
            this.gbPagamneto.Controls.Add(this.label1);
            this.gbPagamneto.Controls.Add(this.txtValorTotal);
            this.gbPagamneto.Controls.Add(this.txtQtdeItens);
            this.gbPagamneto.Controls.Add(this.cbFormaPagamento);
            this.gbPagamneto.Controls.Add(this.label9);
            this.gbPagamneto.Controls.Add(this.label10);
            this.gbPagamneto.Controls.Add(this.lbFormaPagamento);
            this.gbPagamneto.Controls.Add(this.txtPercentualDesconto);
            this.gbPagamneto.Controls.Add(this.label2);
            this.gbPagamneto.Controls.Add(this.txtTotalDesconto);
            this.gbPagamneto.Controls.Add(this.label11);
            this.gbPagamneto.Controls.Add(this.txtTotalVenda);
            this.gbPagamneto.Controls.Add(this.label13);
            this.gbPagamneto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagamneto.Location = new System.Drawing.Point(12, 480);
            this.gbPagamneto.Name = "gbPagamneto";
            this.gbPagamneto.Size = new System.Drawing.Size(519, 265);
            this.gbPagamneto.TabIndex = 206;
            this.gbPagamneto.TabStop = false;
            // 
            // txtTrocoEntregue
            // 
            this.txtTrocoEntregue.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrocoEntregue.Location = new System.Drawing.Point(350, 208);
            this.txtTrocoEntregue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrocoEntregue.MaxLength = 10;
            this.txtTrocoEntregue.Name = "txtTrocoEntregue";
            this.txtTrocoEntregue.Size = new System.Drawing.Size(157, 30);
            this.txtTrocoEntregue.TabIndex = 230;
            this.txtTrocoEntregue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrocoEntregue_KeyPress);
            // 
            // lbTrocoEntregue
            // 
            this.lbTrocoEntregue.AutoSize = true;
            this.lbTrocoEntregue.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrocoEntregue.Location = new System.Drawing.Point(346, 182);
            this.lbTrocoEntregue.Name = "lbTrocoEntregue";
            this.lbTrocoEntregue.Size = new System.Drawing.Size(134, 23);
            this.lbTrocoEntregue.TabIndex = 229;
            this.lbTrocoEntregue.Text = "Troco entregue";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.White;
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(180, 208);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(150, 30);
            this.txtTroco.TabIndex = 228;
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroco.Location = new System.Drawing.Point(176, 182);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(132, 23);
            this.lbTroco.TabIndex = 227;
            this.lbTroco.Text = "Troco calculado";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(7, 208);
            this.txtValorRecebido.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorRecebido.MaxLength = 10;
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(153, 30);
            this.txtValorRecebido.TabIndex = 226;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            this.txtValorRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorRecebido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 225;
            this.label1.Text = "Valor recebido";
            // 
            // bt_sair
            // 
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Image = ((System.Drawing.Image)(resources.GetObject("bt_sair.Image")));
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(788, 678);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(271, 67);
            this.bt_sair.TabIndex = 233;
            this.bt_sair.Text = "     Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1063, 27);
            this.statusStrip1.TabIndex = 234;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripStatusLabel1.Text = "Venda";
            // 
            // formVenda52
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1063, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbPagamneto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.btFechaVenda);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVenda52";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.formVenda52_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gbItensVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbFuncionario.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbPagamneto.ResumeLayout(false);
            this.gbPagamneto.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtPesqCliente;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtPercentualDesconto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtQtdeItens;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Button btBuscaProduto;
        private System.Windows.Forms.Button btFechaVenda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gbPagamneto;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.TextBox txtTrocoEntregue;
        private System.Windows.Forms.Label lbTrocoEntregue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
