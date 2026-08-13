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
    public partial class formRelProduto : Form
    {
        public formRelProduto()
        {
            InitializeComponent();
        }

        

        private void formRelProduto_Load(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();
            
            cbTipoRel.Items.Add("Editora");
            cbTipoRel.Items.Add("Categoria");
            cbTipoRel.Items.Add("Autor");
            cbTipoRel.Items.Add("Preço de Venda");
            cbTipoRel.Items.Add("Estoque");
            cbTipoRel.Items.Add("Data de Lançamento");
            cbTipoRel.Items.Add("Status");

            cbTipoRel.SelectedIndex = 0;

            cbEditora.DataSource = cProduto.buscarEditoraRelatorio();
            cbEditora.DisplayMember = "nome";
            cbEditora.ValueMember = "cod_editora";
            cbEditora.SelectedIndex = 0;

            cbAutor.DataSource = cProduto.buscarAutorRelatorio();
            cbAutor.DisplayMember = "Autor";
            cbAutor.ValueMember = "Código";
            cbAutor.SelectedIndex = 0;

            cbCategoria.DataSource = cProduto.buscarCategoriaRelatorio();
            cbCategoria.DisplayMember = "nome";
            cbCategoria.ValueMember = "cod_categoria";
            cbCategoria.SelectedIndex = 0;


            this.reportViewer.RefreshReport();

        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)
            {
                gbEditora.Enabled = true;
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbStatus.Enabled = false;
                gbDataLancamento.Enabled = false;
                gbEstoque.Enabled = false;
                gbPrecoVenda.Enabled = false;

            }
            
            else if (cbTipoRel.SelectedIndex == 1)
            {
                gbEditora.Enabled = false;
                gbAutor.Enabled = false;
                gbCategoria.Enabled = true;
                gbStatus.Enabled = false;
                gbDataLancamento.Enabled = false;
                gbEstoque.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }
            else if(cbTipoRel.SelectedIndex == 2)
            {
                gbEditora.Enabled = false;
                gbAutor.Enabled = true;
                gbCategoria.Enabled = false;
                gbStatus.Enabled = false;
                gbDataLancamento.Enabled = false;
                gbEstoque.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }
            else if(cbTipoRel.SelectedIndex == 3)
            {
                gbEditora.Enabled = false;
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbStatus.Enabled = false;
                gbDataLancamento.Enabled = false;
                gbEstoque.Enabled = false;
                gbPrecoVenda.Enabled = true;
            }
            else if (cbTipoRel.SelectedIndex == 4)
            {
                gbEditora.Enabled = false;
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbStatus.Enabled = false;
                gbDataLancamento.Enabled = false;
                gbEstoque.Enabled = true;
                gbPrecoVenda.Enabled = false;
            }
            else if(cbTipoRel.SelectedIndex ==5)
            {
                gbEditora.Enabled = false;
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbStatus.Enabled = false;
                gbDataLancamento.Enabled = true;
                gbEstoque.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }
            else
            {
                gbEditora.Enabled = false;
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbStatus.Enabled = true;
                gbAutor.Enabled = false;
                gbDataLancamento.Enabled = false;
                gbEstoque.Enabled = false;
                gbPrecoVenda.Enabled = false;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classConexao cConexao = new classConexao();
            classProduto cProduto = new classProduto();

            string opcao = cbTipoRel.SelectedItem.ToString();

            switch(opcao)
            {
                case "Editora":
                    classProdutoBindingSource.DataSource = cProduto.ReportProdutoEditora(Convert.ToInt32(cbEditora.SelectedValue));
                    this.reportViewer.RefreshReport();
                    break;
                case "Categoria":
                    classProdutoBindingSource.DataSource = cProduto.ReportProdutoCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                    this.reportViewer.RefreshReport();
                    break;
                case "Autor":
                    classProdutoBindingSource.DataSource = cProduto.ReportProdutoAutor(Convert.ToInt32(cbAutor.SelectedValue));
                    this.reportViewer.RefreshReport();
                    break;
                case "Preço de Venda":
                    if(String.IsNullOrWhiteSpace(tbPrecoIni.Text) || String.IsNullOrWhiteSpace(tbPrecoFim.Text))
                    {
                        MessageBox.Show("Por favor preencha os campos destacados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbPrecoFim.BackColor = Color.PaleVioletRed;
                        tbPrecoIni.BackColor = Color.PaleVioletRed;
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.ReportProdutoPrecoVenda(Convert.ToDecimal(tbPrecoIni.Text), Convert.ToDecimal(tbPrecoFim.Text));
                        this.reportViewer.RefreshReport();
                    }
                    
                    break;
                case "Estoque":
                    if (String.IsNullOrWhiteSpace(tbEstoqueIni.Text) || String.IsNullOrWhiteSpace(tbEstoqueFim.Text))
                    {
                        MessageBox.Show("Por favor preencha os campos destacados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbEstoqueIni.BackColor = Color.PaleVioletRed;
                        tbEstoqueFim.BackColor = Color.PaleVioletRed;
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.ReportProdutoEstoque(Convert.ToInt32(tbEstoqueIni.Text), Convert.ToInt32(tbEstoqueFim.Text));
                        this.reportViewer.RefreshReport();
                    }

                    break;
                case "Data de Lançamento":
                    if (dtpfim.Value < dtpini.Value || dtpfim.Value > DateTime.Now || dtpini.Value > DateTime.Now)
                    {
                        MessageBox.Show("Insira uma data válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.ReportProdutoDataLancamento(dtpini.Value, dtpfim.Value);
                        this.reportViewer.RefreshReport();
                    }

                    break;
                default:
                    if(rbAtivo.Checked)
                    {
                        classProdutoBindingSource.DataSource = cProduto.ReportProdutoStatus(1);
                        this.reportViewer.RefreshReport();
                    }
                    else
                    {
                        classProdutoBindingSource.DataSource = cProduto.ReportProdutoStatus(0);
                        this.reportViewer.RefreshReport();
                    }

                    break;

            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
