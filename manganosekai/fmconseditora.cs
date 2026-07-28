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
    public partial class fmconseditora : Form
    {
        public fmconseditora()
        {
            InitializeComponent();
        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fmconseditora_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Nome da editora");
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
            classEditora cEditora = new classEditora();
            string filtro = cbOpcoes.SelectedItem.ToString();
            switch (filtro)
            {
                case "Data de cadastro":
                    dgvEditora.DataSource = cEditora.consultarEditoraData(Convert.ToDateTime(dtpDataCadastro.Text));
                    break;
                case "Status":
                    if (rbInativo.Checked)
                    {
                        dgvEditora.DataSource = cEditora.consultarEditoraStatus(0);
                    }
                    else
                    {
                        dgvEditora.DataSource = cEditora.consultarEditoraStatus(1);
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
                            dgvEditora.DataSource = cEditora.consultarEditoraNomeInicio(tbnome.Text);
                        }
                        else
                        {
                            dgvEditora.DataSource = cEditora.consultarEditoraNomeContem(tbnome.Text);
                        }
                    } 
                    break;

            }
        }

        private void dgvEditora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir a editora selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classEditora cEditora = new classEditora();
                fmcceditora objEditora = new fmcceditora();
                cEditora.dadoseditora(Convert.ToInt32(dgvEditora.SelectedRows[0].Cells[0].Value));
                objEditora.tbcodigoeditora.Text = cEditora.cod_editora.ToString();
                objEditora.tbeditora.Text = cEditora.nome.ToString();
                objEditora.tbdescricao.Text = cEditora.descricao.ToString();
                objEditora.data_cadastro = cEditora.data_cadastro;

                if (cEditora.status == 1)
                {
                    objEditora.rbativo.Checked = true;
                }
                else if (cEditora.status == 0)
                {
                    objEditora.rbinativo.Checked = true;
                }
                objEditora.tipo = "Atualização";
                objEditora.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Não há usuarios cadastro com esse filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
