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
    public partial class fmconsproduto : Form
    {
        public fmconsproduto()
        {
            InitializeComponent();
        }

        public Point downPoint = Point.Empty;
        protected override void OnLoad(EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                MouseDown += new MouseEventHandler(Form_MouseDown);
                MouseMove += new MouseEventHandler(Form_MouseMove);
                MouseUp += new MouseEventHandler(Form_MouseUp);
            }
            base.OnLoad(e);
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            downPoint = Point.Empty;
        }

        public string tipo;

        private void fmconsproduto_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Selecione um método de consulta");
            cbOpcoes.Items.Add("Nome do mangá");
            cbOpcoes.Items.Add("Editora");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Autor");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Ano de lançamento");
            cbOpcoes.SelectedIndex = 0;


            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.buscarcategoria();
            cbCategoria.DisplayMember = "nome";
            cbCategoria.ValueMember = "cod_categoria";

            classEditora cEditora = new classEditora();
            cbEditora.DataSource = cEditora.buscareditora();
            cbEditora.DisplayMember = "nome";
            cbEditora.ValueMember = "cod_editora";

            classAutor cAutor = new classAutor();
            dgvAutor.DataSource = cAutor.buscarautorGrid();
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbOpcoes.SelectedIndex == 0)
            {
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbdatalancamento.Enabled = false;
                gbEditora.Enabled = false;
                gbStatus.Enabled = false;
                gbTitulo.Enabled = false;

                btPesquisar.Enabled = false;
            }
            if(cbOpcoes.SelectedIndex == 1)
            {
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbdatalancamento.Enabled = false;
                gbEditora.Enabled = false;
                gbStatus.Enabled = false;
                gbTitulo.Enabled = true;


                btPesquisar.Enabled = true;
            }
            if(cbOpcoes.SelectedIndex == 2)
            {
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbdatalancamento.Enabled = false;
                gbEditora.Enabled = true;
                gbStatus.Enabled = false;
                gbTitulo.Enabled = false;


                btPesquisar.Enabled = true;
            }
            if(cbOpcoes.SelectedIndex ==3)
            {
                gbAutor.Enabled = false;
                gbCategoria.Enabled = true;
                gbdatalancamento.Enabled = false;
                gbEditora.Enabled = false;
                gbStatus.Enabled = false;
                gbTitulo.Enabled = false;


                btPesquisar.Enabled = true;
            }
            if(cbOpcoes.SelectedIndex == 4)
            {
                gbAutor.Enabled = true;
                gbCategoria.Enabled = false;
                gbdatalancamento.Enabled = false;
                gbEditora.Enabled = false;
                gbStatus.Enabled = false;
                gbTitulo.Enabled = false;


                btPesquisar.Enabled = true;
            }
            if(cbOpcoes.SelectedIndex==5)
            {
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbdatalancamento.Enabled = false;
                gbEditora.Enabled = false;
                gbStatus.Enabled = true;
                gbTitulo.Enabled = false;

                btPesquisar.Enabled = true;
            }
            if(cbOpcoes.SelectedIndex == 6)
            {
                gbAutor.Enabled = false;
                gbCategoria.Enabled = false;
                gbdatalancamento.Enabled = true;
                gbEditora.Enabled = false;
                gbStatus.Enabled = false;
                gbTitulo.Enabled = false;


                btPesquisar.Enabled = true;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {
                case "Nome do Mangá":
                    {
                        dgvProduto.DataSource = cProduto.consultarProdutoTitulo(tbtitulo.Text);
                        break;
                    }
                case "Editora":
                    {
                        dgvProduto.DataSource = cProduto.consultarProdutoEditora(Convert.ToInt32(cbEditora.SelectedValue));
                        break;
                    }
                case "Categoria":
                    {
                        dgvProduto.DataSource = cProduto.consultaProdutoCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                        break;
                    }
                case "Autor":
                    {
                        dgvProduto.DataSource = cProduto.consultaProdutoAutor(Convert.ToInt32(dgvAutor.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "Status":
                    {
                        if(rbAtivo.Checked == true)
                        {
                            dgvProduto.DataSource = cProduto.consultaProdutoStatus(1);

                        }
                        if(rbInativo.Checked == true)
                        {
                            dgvProduto.DataSource = cProduto.consultaProdutoStatus(0);
                        }
                        else
                        {

                        }
                        break;

                    }
                case "Ano de lançamento":
                    {
                        dgvProduto.DataSource = cProduto.consultarProdutoAno(Convert.ToInt32(dtpDataLancamento.Value.Year));
                        break;
                    }
                default:
                    {
                        break;
                    }



            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Deseja alterar ou excluir o produto selecionado","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                classProduto cProduto = new classProduto();
                fmcproduto fProduto = new fmcproduto();

                cProduto.dadosProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

                fProduto.mtbcod.Text = cProduto.cod_produto.ToString();
                fProduto.lbdatacadastro.Text = cProduto.data_cadastro.ToString("dd/MM/yyyy HH:mm");

                if(cProduto.status == 1)
                {
                    fProduto.rbAtivo.Checked = true;
                }
                if(cProduto.status == 0)
                {
                    fProduto.rbinativo.Checked = true;
                }

                fProduto.tbtitulo.Text = cProduto.titulo.ToString();
                fProduto.dtplancamento.Value = Convert.ToDateTime(cProduto.data_lancamento);
                fProduto.tbvolume.Text = cProduto.volume.ToString();
                fProduto.cod_editora  = cProduto.cod_editora;
                fProduto.cod_categoria = cProduto.cod_categoria ;
                fProduto.tbquantidade.Text = cProduto.qntd_estoque.ToString();
                fProduto.tblucro.Text = cProduto.lucro.ToString();
                fProduto.tbpvenda.Text = cProduto.preco_venda.ToString();
                fProduto.tbpcusto.Text = cProduto.preco_custo.ToString();
                if(cProduto.ifpromocao == 0)
                {
                    fProduto.rbnao.Checked = true;
                    fProduto.rbsim.Checked = false;
                }
                else
                {
                    fProduto.rbsim.Checked = true;
                    fProduto.rbnao.Checked = false;
                }
                fProduto.tbppromocao.Text = cProduto.percentualpromocao.ToString();
                fProduto.tbppromocional.Text = cProduto.precopromocao.ToString();
                fProduto.cod_autor = cProduto.cod_autor;
                fProduto.tbdescricao.Text = cProduto.descricao.ToString();
                fProduto.tbresumo.Text = cProduto.resumo.ToString();

                fProduto.tipo = "Atualização";
                fProduto.ShowDialog();

                btPesquisar_Click(this, new EventArgs());
            }
        }

        private void gbConsproduto_Enter(object sender, EventArgs e)
        {

        }



        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
