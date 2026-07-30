using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manganosekai
{
    public partial class formVenda52 : Form
    {
        public formVenda52()
        {
            InitializeComponent();


        }

        //Criar Lista que sera usada na grid de produtos vendidos que tera como base a classe de itens_produto
        private List<item_produto> ListaItensVenda = new
        List<item_produto>();

        // variavel para calcular valor total de venda
        private decimal VendaTotal = 0;

        //Variavel para contar quantas linhas foram adicionadas na grid de venda
        private int itensproduto = 0;
        
        private void formVenda52_Load(object sender, EventArgs e)
        {
            //CARREGAR DATA DA VENDA
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

            //COMBO FORMA DE PAGAMENTO
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Pix");
            cbFormaPagamento.SelectedIndex = -1;

            //Carregar funcionario
            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.carregarVendedor();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "cod_funcionario";
            cbFuncionario.SelectedIndex = -1;

            

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            if(String.IsNullOrWhiteSpace(txtPesqCliente.Text))
            {
                MessageBox.Show("Preencher o campo destacado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesqCliente.BackColor = Color.PaleVioletRed;

            }
            else
            {
                dgvCliente.DataSource = cCliente.consultarClienteVenda(txtPesqCliente.Text);
            }

        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPesqProduto.Text))
            {
                MessageBox.Show("Preencher o campo destacado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesqProduto.BackColor = Color.PaleVioletRed;

            }
            else
            {
                classProduto cProduto = new classProduto();
                dgvProduto.DataSource = cProduto.consultarProdutoVenda(txtPesqProduto.Text);
            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtQtdeEstoque.Text) || txtQtdeEstoque.Text == "0")
            {
                MessageBox.Show("Insira um valor valido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdeEstoque.Text = "01";
                txtQtde.SelectAll();

            }
            else
            {
            }


            int qntdvendida = Convert.ToInt32(txtQtde.Text);
            int qntdestoque = Convert.ToInt32(txtQtdeEstoque.Text);

            if (qntdvendida > qntdestoque)
            {
                MessageBox.Show("A Quantidade disponivel em estoque é de " + qntdestoque + " unidades", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();
            }
            else
            {
                qntdvendida = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qntdvendida * valor).ToString();
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classProduto cProduto = new classProduto();

            bool resp = cProduto.dadosProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

            if (resp == true)
            {
                txtProduto.Text = cProduto.titulo;
                txtQtdeEstoque.Text = cProduto.qntd_estoque.ToString();
                txtValor.Text = cProduto.preco_venda.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();
            }
        }
    }
}
