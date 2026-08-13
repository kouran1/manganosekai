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
    public partial class fmcproduto : Form
    {
        public fmcproduto()
        {
            InitializeComponent();

            tbtitulo.MaxLength = 40;
            tbvolume.MaxLength = 2;
            tbresumo.MaxLength = 250;
            tbdescricao.MaxLength = 150;
            tbquantidade.MaxLength = 3;
            tbpcusto.MaxLength = 7;
            tblucro.MaxLength = 7;
            tbpvenda.MaxLength = 7;
            tbppromocao.MaxLength = 7;
            tbppromocional.MaxLength = 7;
        }
        public string tipo, nome_autor;
        public int cod_categoria, cod_editora, cod_autor;
        public DateTime data_cadastro;


        public void calcular()
        {
            if (tbpcusto.Text != "" && tblucro.Text != "")
            {
                decimal custo = Convert.ToDecimal(tbpcusto.Text);
                decimal lucro = Convert.ToDecimal(tblucro.Text);
                decimal venda = custo + (custo * lucro / 100);
                tbpvenda.Text = venda.ToString("n2");
                tbpvenda.Enabled = false;
 
            }
            else
            {
                tbpvenda.Text = "";
                tbpvenda.Enabled = false;
            }
        }
        public void calculardesconto()
        {
            if (tbpvenda.Text != "" && tbppromocao.Text != "")
            {
                decimal venda = Convert.ToDecimal(tbpvenda.Text);
                decimal desconto = Convert.ToDecimal(tbppromocao.Text);
                decimal promocional = venda - (venda * desconto / 100);
                tbppromocional.Text = promocional.ToString("n2");
            }
            else
            {
                tbppromocional.Text = "";
            }
        }

        private void cbeditora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }
        public void MetodoCampo()
        {
            if (rbnao.Checked)
            {
                tbppromocao.Enabled = false;
                tbppromocional.Enabled = false;
            }
            else
            {
                tbppromocao.Enabled = true;
                tbppromocional.Enabled = true;
            }
        }

        private void CamposObrigatorios()
        {
            tbtitulo.BackColor = Color.PaleVioletRed;
            tbvolume.BackColor = Color.PaleVioletRed;
            tbresumo.BackColor = Color.PaleVioletRed;
            tbdescricao.BackColor = Color.PaleVioletRed;
            tbquantidade.BackColor = Color.PaleVioletRed;
            tbpcusto.BackColor = Color.PaleVioletRed;
            tblucro.BackColor = Color.PaleVioletRed;
            tbpvenda.BackColor = Color.PaleVioletRed;
            tbtitulo.Focus();

        }
        private void MetodoLimpar()
        {
            tbtitulo.Clear();
            tbvolume.Clear();
            dtplancamento.Value = DateTime.Today;
            rbnao.Checked = true;
            cboxcategoria.SelectedIndex = -1;
            cboxeditora.SelectedIndex = -1;
            tbpcusto.Clear();
            tbquantidade.Clear();
            tblucro.Clear();
            tbpvenda.Clear();
            tbppromocao.Clear();
            tbppromocional.Clear();
            rbAtivo.Checked = true;
            tbtitulo.Focus();
        }

        private void cadastraritemproduto()
        {
           
        }

        

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();
            {
                if (string.IsNullOrWhiteSpace(tbtitulo.Text) || string.IsNullOrWhiteSpace(tbvolume.Text) || string.IsNullOrWhiteSpace(tbresumo.Text) || string.IsNullOrWhiteSpace(tbdescricao.Text) || string.IsNullOrWhiteSpace(tbquantidade.Text) || string.IsNullOrWhiteSpace(tbpcusto.Text) || string.IsNullOrWhiteSpace(tblucro.Text) || string.IsNullOrWhiteSpace(tbpvenda.Text) || (rbsim.Checked == true && (string.IsNullOrWhiteSpace(tbppromocao.Text) || string.IsNullOrWhiteSpace(tbppromocional.Text))))
                {
                    MessageBox.Show("Verificar os campos listados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CamposObrigatorios();
                }
                else
                {

                    cProduto.titulo = tbtitulo.Text;
                    cProduto.volume = Convert.ToInt32(tbvolume.Text);
                    cProduto.data_lancamento = dtplancamento.Value;
                    cProduto.resumo = tbresumo.Text;
                    cProduto.descricao = tbdescricao.Text;
                    cProduto.qntd_estoque = Convert.ToInt32(tbquantidade.Text);
                    cProduto.preco_custo = Convert.ToDecimal(tbpcusto.Text);
                    cProduto.lucro = Convert.ToDecimal(tblucro.Text);
                    cProduto.foto = "";
                    cProduto.preco_venda = Convert.ToDecimal(tbpvenda.Text);
                    if (rbnao.Checked == true)
                    {
                        cProduto.ifpromocao = 0;
                        cProduto.percentualpromocao = 0;
                        cProduto.precopromocao = 0;
                    }
                    else
                    {
                        cProduto.ifpromocao = 1;
                        cProduto.percentualpromocao = Convert.ToDecimal(tbppromocao.Text);
                        cProduto.precopromocao = Convert.ToDecimal(tbppromocional.Text);
                    }
                   


                    cProduto.cod_editora = Convert.ToInt32(cboxeditora.SelectedValue);
                    cProduto.cod_categoria = Convert.ToInt32(cboxcategoria.SelectedValue);
                
                    int resp = cProduto.cadastrarproduto();

                    if (resp == 1)
                    {
                        int idProduto = cProduto.ultimoid();

                        for (int i = 0; i < dgvAutores.SelectedRows.Count; i++)
                        {
                            DataRowView row = dgvAutores.SelectedRows[i].DataBoundItem as DataRowView;
                            if (row == null) continue;

                            cProduto.cod_produto = idProduto;
                            cProduto.cod_autor = Convert.ToInt32(row["Código"]);
                            cProduto.cadastrarAutorProduto();
                        }

                        MessageBox.Show($"Produto: {cProduto.titulo} cadastrado com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MetodoLimpar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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


        private void fmcproduto_Load(object sender, EventArgs e)
        {
            classAutor cAutor = new classAutor();

            dgvAutores.DataSource = cAutor.buscarAutor02();

            

            
            //CARREGAR HORARIO E DATA NO SISTEMA

            lbdatacadastro.Text = DateTime.Now.ToString();


            classEditora cbeditora  = new classEditora();
            cboxeditora.DataSource = cbeditora.buscareditora();
            cboxeditora.DisplayMember = "nome";
            cboxeditora.ValueMember = "cod_editora";
            cboxeditora.SelectedIndex = -1;

            classCategoria cCategoria = new classCategoria();
            cboxcategoria.DataSource = cCategoria.buscarcategoria();
            cboxcategoria.DisplayMember = "nome";
            cboxcategoria.ValueMember = "cod_categoria";
            cboxcategoria.SelectedIndex = -1;
            MetodoCampo();

            if(tipo == "Atualização")
            {
                btatualizar.Enabled = true;
                btcadastrar.Enabled = false;
                btexcluir.Enabled = true;

                classProduto cProduto = new classProduto();

                DataTable tabela_autor = cProduto.buscarautorproduto(Convert.ToInt32(mtbcod.Text));

                foreach (DataGridViewRow row in dgvAutores.Rows)
                {
                    foreach (DataRow autor in tabela_autor.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["Código"].Value) == Convert.ToInt32(autor["cod_autor"]))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }

                cboxeditora.SelectedValue = cod_editora;
                cboxcategoria.SelectedValue = cod_categoria;
                lbdatacadastro.Text = data_cadastro.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
                btcadastrar.Enabled = true;
            }
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbnao_CheckedChanged(object sender, EventArgs e)
        {
            MetodoCampo();
        }

        private void mtbpcusto_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tblucro_TextChanged(object sender, EventArgs e)
        {
        }

        private void tblucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else if (e.KeyChar != 8)
            {
                string texto = tblucro.Text + e.KeyChar;

                if (texto.Length > 3)
                {
                    e.Handled = true;
                }
                else if (Convert.ToInt32(texto) > 100)
                {
                    e.Handled = true;
                }
                else
                {
                    tblucro.Text = texto;                    
                    tblucro.SelectionStart = tblucro.Text.Length;
                    e.Handled = true;                      
                    calcular();                            
                }
            }
        }

        private void tbpvenda_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void mtbpcusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbppromocao_TextChanged(object sender, EventArgs e)
        {
                 
        }


        private void tbpvenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbppromocional_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpcusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpcusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else if (e.KeyChar != 8)
            {
                string texto = tbpcusto.Text.Replace(",", "").Replace(".", "") + e.KeyChar;
                if (texto.Length > 6)
                {
                    e.Handled = true;
                }
                else
                {
                    double valor = Convert.ToDouble(texto);
                    tbpcusto.Text = (valor / 100).ToString("N2");
                    tbpcusto.SelectionStart = tbpcusto.Text.Length;
                    e.Handled = true;
                    calcular();
                }
            }
        }

        private void tbppromocao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else if (e.KeyChar != 8)
            {
                string texto = tbppromocao.Text + e.KeyChar;
                if (texto.Length > 3)
                {
                    e.Handled = true;
                }
                else if (Convert.ToInt32(texto) > 100)
                {
                    e.Handled = true;
                }
                else
                {
                    tbppromocao.Text = texto;           
                    tbppromocao.SelectionStart = tbppromocao.Text.Length;
                    e.Handled = true;                   
                    calculardesconto();                 
                }
            }
        }

        private void tbppromocional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else if (e.KeyChar != 8)
            {
                string texto = tbppromocional.Text.Replace(",", "").Replace(".", "") + e.KeyChar;
                if (texto.Length > 6)
                {
                    e.Handled = true;
                }
                else
                {
                    double valor = Convert.ToDouble(texto);
                    tbppromocional.Text = (valor / 100).ToString("N2");
                    tbppromocional.SelectionStart = tbppromocional.Text.Length;
                    e.Handled = true;
                    calculardesconto();
                }
            }
        }

        private void mtblancamento_Leave(object sender, EventArgs e)
        {


        }

        private void tbquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbtitulo.Text) || string.IsNullOrWhiteSpace(tbvolume.Text) || string.IsNullOrWhiteSpace(tbresumo.Text) || string.IsNullOrWhiteSpace(tbdescricao.Text) || string.IsNullOrWhiteSpace(tbquantidade.Text) || string.IsNullOrWhiteSpace(tbpcusto.Text) || string.IsNullOrWhiteSpace(tblucro.Text) || string.IsNullOrWhiteSpace(tbpvenda.Text) || (rbsim.Checked == true && (string.IsNullOrWhiteSpace(tbppromocao.Text) || string.IsNullOrWhiteSpace(tbppromocional.Text))))
            {
                MessageBox.Show("Verificar os campos listados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
            }
            else
            {
                classProduto cProduto = new classProduto();

                if (dgvAutores.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione pelo menos um autor para o produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cProduto.cod_produto = Convert.ToInt32(mtbcod.Text);
                cProduto.titulo = tbtitulo.Text;
                cProduto.volume = Convert.ToInt32(tbvolume.Text);
                cProduto.data_lancamento = dtplancamento.Value;
                cProduto.cod_editora = Convert.ToInt32(cboxeditora.SelectedValue);
                cProduto.cod_categoria = Convert.ToInt32(cboxcategoria.SelectedValue);
                cProduto.qntd_estoque = Convert.ToInt32(tbquantidade.Text);
                cProduto.preco_custo = Convert.ToDecimal(tbpcusto.Text);
                cProduto.lucro = Convert.ToDecimal(tblucro.Text);
                cProduto.preco_venda = Convert.ToDecimal(tbpvenda.Text);
                if(rbAtivo.Checked == true)
                {
                    cProduto.status = 1;
                }
                else
                {
                    cProduto.status = 0;
                }
                //Promocao
                if (rbnao.Checked == true)
                {
                    cProduto.ifpromocao = 0;
                    cProduto.percentualpromocao = 0;
                    cProduto.precopromocao = 0;
                }
                else
                {
                    cProduto.ifpromocao = 1;
                    cProduto.percentualpromocao = Convert.ToDecimal(tbppromocao.Text);
                    cProduto.precopromocao = Convert.ToDecimal(tbppromocional.Text);
                }
                cProduto.descricao = tbdescricao.Text;
                cProduto.resumo = tbresumo.Text;

                int resp = cProduto.atualizarProduto();

                if (resp == 1)
                {

                    cProduto.removerautorproduto();

                    for (int i = 0; i < dgvAutores.SelectedRows.Count; i++)
                    {
                        DataRowView row = dgvAutores.SelectedRows[i].DataBoundItem as DataRowView;
                        if (row == null) continue;

                        cProduto.cod_autor = Convert.ToInt32(row["Código"]);
                        cProduto.cadastrarAutorProduto();
                    }

                    MessageBox.Show($"Produto: {cProduto.titulo} Atualizado com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MetodoLimpar();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir o produto {tbtitulo.Text}? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classProduto cProduto = new classProduto();
                cProduto.cod_produto = Convert.ToInt32(mtbcod.Text);

                int resp = cProduto.deletarproduto();

                if (resp == 1)
                {
                    MessageBox.Show("Produto excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
