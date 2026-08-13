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
    public partial class fmconsautor : Form
    {
        public fmconsautor()
        {
            InitializeComponent();
        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Deseja alterar ou excluir o autor selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



            }
            else
            {
                MessageBox.Show("Não há autores cadastrados com esses filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classAutor cAutor = new classAutor();
            string filtro = cbOpcoes.SelectedItem.ToString();


            switch (filtro)
            {
                case "Data de cadastro":
                    dgvAutor.DataSource = cAutor.consultarAutorData(Convert.ToDateTime(dtpDataCadastro.Text));
                    break;
                case "Status":
                    if (rbInativo.Checked)
                    {
                        dgvAutor.DataSource = cAutor.consultarAutorStatus(0);
                    }
                    else
                    {
                        dgvAutor.DataSource = cAutor.consultarAutorStatus(1);
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
                            dgvAutor.DataSource = cAutor.consultarAutorNomeInicio(tbnome.Text);
                        }
                        else
                        {
                            dgvAutor.DataSource = cAutor.consultarAutorNomeContem(tbnome.Text);
                        }
                    }

                    break;
            }
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

        private void fmconsautor_Load(object sender, EventArgs e)
        {

            cbOpcoes.Items.Add("Nome do autor");
            cbOpcoes.Items.Add("Data de cadastro");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;
        }

        private void dgvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir o autor selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classAutor cAutor = new classAutor();
                fmcautor objAutor = new fmcautor();
                cAutor.dadosautor(Convert.ToInt32(dgvAutor.SelectedRows[0].Cells[0].Value));
                objAutor.tbcodigoautor.Text = cAutor.cod_autor.ToString();
                objAutor.tbnomeautor.Text = cAutor.nome.ToString();
                objAutor.tbdescricao.Text = cAutor.descricao.ToString();
                objAutor.data_cadastro = cAutor.data_cadastro;
                objAutor.nacionalidade = cAutor.nacionalidade.ToString();
                if (cAutor.status == 1)
                {
                    objAutor.rbativo.Checked = true;
                }
                else
                {
                    objAutor.rbinativo.Checked = true;
                }
                objAutor.tipo = "Atualização";
                objAutor.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Não há autores cadastrados com esses filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void gbConsFuncionario_Enter(object sender, EventArgs e)
        {

        }
    }
}
