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
    public partial class fmconscategoria : Form
    {
        public fmconscategoria()
        {
            InitializeComponent();
        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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


        private void fmconscategoria_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Nome da categoria");
            cbOpcoes.Items.Add("Data de cadastro");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0)
            {
                tbnome.Enabled = true;
                dtpDataCadastro.Enabled = false;
                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = true;
            }
            else if (cbOpcoes.SelectedIndex == 1)
            {
                tbnome.Enabled = false;
                dtpDataCadastro.Enabled = true;
                gbStatus.Enabled = false;
                gbTipoPesquisa.Enabled = false;
            }
            else if (cbOpcoes.SelectedIndex == 2)
            {
                tbnome.Enabled = false;
                dtpDataCadastro.Enabled = false;
                gbStatus.Enabled = true;
                gbTipoPesquisa.Enabled = false;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            string filtro = cbOpcoes.SelectedItem.ToString();


            switch (filtro)
            {
                case "Data de cadastro":
                    dgvCategoria.DataSource = cCategoria.consultarCategoriaData(Convert.ToDateTime(dtpDataCadastro.Text));
                    break;
                case "Status":
                    if (rbInativo.Checked)
                    {
                        dgvCategoria.DataSource = cCategoria.consultarCategoriaStatus(0);
                    }
                    else
                    {
                        dgvCategoria.DataSource = cCategoria.consultarCategoriaStatus(1);
                    }
                    break;
                default:
                    if (string.IsNullOrWhiteSpace(tbnome.Text))
                    {
                        MessageBox.Show("Preencher o campo destacado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbnome.BackColor = Color.PaleVioletRed;
                        tbnome.Focus();
                    }
                    else
                    {
                        if (rbInicio.Checked)
                        {
                            dgvCategoria.DataSource = cCategoria.consultarCategoriaNomeInicio(tbnome.Text);
                        }
                        else
                        {
                            dgvCategoria.DataSource = cCategoria.consultarCategoriaNomeContem(tbnome.Text);
                        }
                    }

                    break;

            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir a categoria selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCategoria cCategoria = new classCategoria();
                fmccategoria objCategoria = new fmccategoria();
                cCategoria.dadoscategoria(Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value));
                objCategoria.tbcodcategoria.Text = cCategoria.cod_categoria.ToString();
                objCategoria.tbcategoria.Text = cCategoria.nome.ToString();
                objCategoria.tboxdescricao.Text = cCategoria.descricao.ToString();
                objCategoria.lbdata.Text = cCategoria.data_cadastro.ToString("dd/MM/yyyy HH:mm");

                if (cCategoria.status == 1)
                {
                    rbAtivo.Checked = true;
                }
                else if(cCategoria.status == 0)
                {
                    rbInativo.Checked = true;
                }
                objCategoria.tipo = "Atualização";
                objCategoria.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Não há categorias cadastradas com esses filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
