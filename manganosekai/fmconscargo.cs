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
    public partial class fmconscargo : Form
    {
        public fmconscargo()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fmconscargo_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Nome do cargo");
            cbOpcoes.Items.Add("Data de cadastro");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.SelectedIndex = 0;
        }

        private void pnTituloFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbOpcoes.SelectedIndex == 0)
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

        private void gbConsFuncionario_Enter(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();
            string filtro = cbOpcoes.SelectedItem.ToString();
            

            switch(filtro)
            {
                case "Data de cadastro":
                    dgvCargo.DataSource = cCargo.consultarCargoData(Convert.ToDateTime(dtpDataCadastro.Text));
                    break;
                case "Status":
                    if (rbInativo.Checked)
                    {
                        dgvCargo.DataSource = cCargo.consultarCargoStatus(0);
                    }
                    else
                    {
                        dgvCargo.DataSource = cCargo.consultarCargoStatus(1);
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
                            dgvCargo.DataSource = cCargo.consultarCargoNomeInicio(tbnome.Text);
                        }
                        else
                        {
                            dgvCargo.DataSource = cCargo.consultarCargoNomeContem(tbnome.Text);
                        }
                    }

                    break;

            }
        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir o funcionario selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCargo cCargo = new classCargo();
                fmccargo fmCargo = new fmccargo();
                cCargo.dadoscargo(Convert.ToInt32(dgvCargo.SelectedRows[0].Cells[0].Value));
                fmCargo.tbcodigocargo.Text = cCargo.cod_cargo.ToString();
                fmCargo.tbcargo.Text = cCargo.nome.ToString();
                fmCargo.tbobservacao.Text = cCargo.observacao.ToString();
                fmCargo.lbdatacadastro.Text = cCargo.data_cadastro.ToString("dd/MM/yyyy HH:mm");
                if(cCargo.status == 1)
                {
                    rbAtivo.Checked = true;
                    rbInativo.Checked = false;
                }
                else
                {
                    rbInativo.Checked = true;
                    rbAtivo.Checked = false;
                }
                fmCargo.tipo = "Atualização";
                fmCargo.ShowDialog();

                btPesquisar_Click(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Não há usuarios cadastro com esse filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
