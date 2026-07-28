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
    }
}
