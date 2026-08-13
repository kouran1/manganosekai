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

        
        private void formVenda52_Load(object sender, EventArgs e)
        {

            txtQtde.Enabled = false;
            //CARREGAR DATA DA VENDA
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

            //COMBO FORMA DE PAGAMENTO
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Pix");
            cbFormaPagamento.SelectedIndex = -1;

            txtValorRecebido.Enabled = false;
            txtTroco.Enabled = false;
            txtTrocoEntregue.Enabled = false;

            //Carregar funcionario
            classFuncionario cFuncionario = new classFuncionario();
            cbFuncionario.DataSource = cFuncionario.carregarVendedor();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "cod_funcionario";
            cbFuncionario.SelectedIndex = -1;


        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                MessageBox.Show("Insira um valor válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdeEstoque.Text = "01";
                txtQtde.SelectAll();

            }
            else
            {
                if(String.IsNullOrWhiteSpace(txtQtde.Text))
                {
                    txtQtde.Text = "01";
                }
            }

            int qntdvendida;
            int qntdestoque;
            int.TryParse(txtQtde.Text, out qntdvendida);
            int.TryParse(txtQtdeEstoque.Text, out qntdestoque);
            

            if (qntdvendida > qntdestoque)
            {
                MessageBox.Show("A quantidade disponível em estoque é de " + qntdestoque + " unidades", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (e.RowIndex >= 0 && dgvProduto.SelectedRows.Count > 0)
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
                    txtQtde.Enabled = true;
                    txtQtde.Select();
                }
            }

        }
        //Método que será usado pela grid de venda com os produtos vendidos
        private void AtualizarGrid()
        {
            //Instanciar a classe produto para pegar o metodo que traz o nome do produto
            classProduto cProduto = new classProduto();

            //Criar uma tabela temporaria

            DataTable dt = new DataTable();

            //Criar as colunas da grid
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor Unitario"));
            dt.Columns.Add(new DataColumn("Valor total"));

            //Adicionar as linhas da grid

            foreach(item_produto item in ListaItensVenda)
            {
                dt.Rows.Add(item.cod_produto, cProduto.BuscarNomeProd(item.cod_produto), item.qntd_item, item.valor_item, item.valor_total_item);
                dt.AcceptChanges();
            }
            dgvItens.DataSource = dt;


        }
        private void CalcularDescontoVenda()
        {
            decimal valorVenda = 0;
            decimal percentualdesconto = 0;
            decimal.TryParse(txtValorTotal.Text, out valorVenda);
            decimal.TryParse(txtPercentualDesconto.Text, out percentualdesconto);

            if(percentualdesconto < 0)
            {
                percentualdesconto = 0;
            }

            decimal valordesconto = valorVenda * percentualdesconto / 100;
            decimal totalvenda = valorVenda - valordesconto;


            txtTotalDesconto.Text = valordesconto.ToString("N2");
            txtTotalVenda.Text = totalvenda.ToString("N2");
            CalcularTroco();
            
        }

        private void CalcularTroco()
        {
            decimal valorRecebido = 0;
            decimal totalVenda = 0;

            decimal.TryParse(txtValorRecebido.Text, out valorRecebido);
            decimal.TryParse(txtTotalVenda.Text, out totalVenda);

            if (valorRecebido >= totalVenda && totalVenda > 0)
            {
                txtTroco.Text = (valorRecebido - totalVenda).ToString("N2");
            }
            else
            {
                txtTroco.Text = "0,00";
            }
        }

        private void txtPercentualDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularDescontoVenda();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtProduto.Text))
            {
                MessageBox.Show("Selecione um produto na grid", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesqProduto.BackColor = Color.Yellow;
            }
            else
            {
                item_produto cItem_produto = new item_produto();

                //INFORMACOES DOS PRODUTOS VENDIDOS
                cItem_produto.cod_produto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);
                cItem_produto.qntd_item = Convert.ToInt32(txtQtde.Text);
                cItem_produto.valor_item = Convert.ToDecimal(txtValor.Text);
                cItem_produto.valor_total_item = Convert.ToDecimal(txtTotal.Text);

                //ADICIONA O ITEM NA LISTA
                ListaItensVenda.Add(cItem_produto);
                //SOMAR VALOR DO ITEM SELECIONADO AO TOTAL DE VENDA 
                decimal valorItem = 0;
                valorItem = Convert.ToDecimal(txtTotal.Text);
                VendaTotal = VendaTotal + valorItem;
                txtValorTotal.Text = VendaTotal.ToString("n2");

                //Atualiza a quantidade de itens
                txtQtdeItens.Text = ListaItensVenda.Count.ToString();

                //Atualizar grid
                AtualizarGrid();

                // Limpar Campos
                txtProduto.Clear();
                txtQtde.Text = "1";
                txtValor.Clear  ();
                txtTotal.Clear();
                txtQtdeEstoque.Clear();

                //Recalcular desconto venda 
                CalcularDescontoVenda();
                txtQtdeItens.Focus();


 
            }
           
        }
        private void MetodoLimpar()
        {

            //FUNCIONARIO E CLIENTE
            cbFuncionario.SelectedIndex = - 1;
            txtPesqCliente.Clear();
            dgvCliente.DataSource = null;

            //PRODUTO 
            txtPesqProduto.Clear();
            dgvProduto.DataSource = null;

            //Lista de venda
            ListaItensVenda.Clear();
            AtualizarGrid();

            //totais
            VendaTotal = 0;
            txtValorTotal.Text = "0,00";
            txtTotalVenda.Text = "0,00";
            txtTotalDesconto.Text = "0,00";
            txtPercentualDesconto.Text = "0";
            txtQtdeItens.Text = "0";

            //Pagamento
            cbFormaPagamento.SelectedIndex = -1;
            txtValorRecebido.Clear();
            txtTroco.Clear();
            txtTrocoEntregue.Clear();
            txtValorRecebido.Enabled = false;
            txtTroco.Enabled = false;
            txtTrocoEntregue.Enabled = false;

            //TBOX qntd

            txtQtde.Enabled = false;
        }
        private void camposobrigatorio()
        {
            gbFuncionario.BackColor = Color.PaleVioletRed;
            gbClientes.BackColor = Color.PaleVioletRed;
            gbItensVenda.BackColor = Color.PaleVioletRed;
            gbProdutos.BackColor = Color.PaleVioletRed;
            gbPagamneto.BackColor = Color.PaleVioletRed;

        }

        //Método Atualizar estoque ( fazer conta para excluir do estoque)
         private void CalculaEstoque(int qntd, int cod)
         {
            classProduto cProduto = new classProduto();
            cProduto.dadosProduto(cod);
            int estoque = cProduto.qntd_estoque;
            cProduto.atualizaEstoque(estoque - qntd, cod);
         }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            //VERIFICAR CAMPOS OBRIGATORIOS
            if(cbFuncionario.SelectedIndex != -1 && cbFormaPagamento.SelectedIndex !=-1 && dgvCliente.SelectedRows.Count > 0 && ListaItensVenda.Count > 0)
            {
                if (cbFormaPagamento.SelectedItem.ToString() == "Dinheiro")
                {
                    if (string.IsNullOrWhiteSpace(txtValorRecebido.Text) || string.IsNullOrWhiteSpace(txtTrocoEntregue.Text))
                    {
                        MessageBox.Show("Informe o valor recebido e o troco entregue ao cliente", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        decimal valorRecebido = Convert.ToDecimal(txtValorRecebido.Text);
                        decimal totalVenda = Convert.ToDecimal(txtTotalVenda.Text);
                        decimal trocoCalculado = Convert.ToDecimal(txtTroco.Text);
                        decimal trocoEntregue = Convert.ToDecimal(txtTrocoEntregue.Text);

                        if (valorRecebido < totalVenda)
                        {
                            MessageBox.Show("O valor recebido é menor que o total da venda", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (trocoEntregue != trocoCalculado)
                            {
                                MessageBox.Show("O troco entregue deve ser igual ao troco calculado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                RealizarVenda();
                            }
                        }
                    }
                }
                else
                {
                    RealizarVenda();
                }
            }
            else
            {
                camposobrigatorio();
                MessageBox.Show("Preencha todos os campos obrigatórios", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RealizarVenda()
        {
            classVenda cVenda = new classVenda();

            cVenda.valor_total = Convert.ToDecimal(txtTotalVenda.Text);
            cVenda.desconto = Convert.ToDecimal(txtTotalDesconto.Text);
            cVenda.forma_pagamento = cbFormaPagamento.SelectedItem.ToString();
            cVenda.cod_cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
            cVenda.cod_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);

            bool resp = cVenda.CadastrarVenda();

            if (resp == true)
            {
                foreach (item_produto item in ListaItensVenda)
                {
                    item.cod_venda = cVenda.cod_venda;
                    resp = item.CadastrarItemProduto();
                    CalculaEstoque(item.qntd_item, item.cod_produto);
                }

                if (resp == true)
                {
                    MessageBox.Show("Venda realizada com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MetodoLimpar();
                }
            }
            else
            {
                MessageBox.Show("Erro ao realizar a venda", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPagamento.SelectedItem != null && cbFormaPagamento.SelectedItem.ToString() == "Dinheiro")
            {
                txtValorRecebido.Enabled = true;
                txtTroco.Enabled = false;
                txtTrocoEntregue.Enabled = true;
                txtValorRecebido.Focus();
            }
            else
            {
                txtValorRecebido.Clear();
                txtTroco.Clear();
                txtTrocoEntregue.Clear();
                txtValorRecebido.Enabled = false;
                txtTroco.Enabled = false;
                txtTrocoEntregue.Enabled = false;
            }
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void txtValorRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar != 8)
                {
                    string texto = txtValorRecebido.Text.Replace(",", "").Replace(".", "") + e.KeyChar;
                    decimal valor = Convert.ToDecimal(texto);
                    txtValorRecebido.Text = (valor / 100).ToString("N2");
                    txtValorRecebido.SelectionStart = txtValorRecebido.Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void txtTrocoEntregue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar != 8)
                {
                    string texto = txtTrocoEntregue.Text.Replace(",", "").Replace(".", "") + e.KeyChar;
                    decimal valor = Convert.ToDecimal(texto);
                    txtTrocoEntregue.Text = (valor / 100).ToString("N2");
                    txtTrocoEntregue.SelectionStart = txtTrocoEntregue.Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if(dgvItens.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Deseja remover o produto selecionado?","Mangá no Sekai", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //RECALCULAR TOTAL DA VENDA
                    //PEGAR O VALOR DO ITEM SELECIONADO PELO USUARIO
                    decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[4].Value);
                    VendaTotal = VendaTotal - valor;
                    txtValorTotal.Text = VendaTotal.ToString("N2");

                    //Remover item selecionado na lista e atualizar grid
                    ListaItensVenda.RemoveAt(dgvItens.CurrentRow.Index);
                    AtualizarGrid();

                    txtQtdeItens.Text = ListaItensVenda.Count.ToString();
                    CalcularDescontoVenda();
                }
            }
            else
            {
                MessageBox.Show("Não há produtos selecionados", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gbProdutos_Enter(object sender, EventArgs e)
        {
        }
    }
}
