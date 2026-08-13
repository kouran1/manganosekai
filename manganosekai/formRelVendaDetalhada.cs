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
    public partial class formRelVendaDetalhada : Form
    {
        public formRelVendaDetalhada()
        {
            InitializeComponent();
        }

        private void formRelVendaDetalhada_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            //Combo metodo
            cbMetodoFiltro.Items.Add("Selecione um filtro");
            cbMetodoFiltro.Items.Add("Funcionário");
            cbMetodoFiltro.Items.Add("Cliente");
            cbMetodoFiltro.Items.Add("Período");
            cbMetodoFiltro.SelectedIndex = 0;


            
            

            //Combo funcionario
            classFuncionario cFuncionario = new classFuncionario();   
            cbFuncionario.DataSource = cFuncionario.carregarVendedor();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "cod_funcionario";
            if (cbFuncionario.Items.Count > 0)
            {
                cbFuncionario.SelectedIndex = 0;
            }
            else
            {
                cbFuncionario.SelectedIndex = -1;
            }

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbCliente.Text))
            {
                MessageBox.Show("Por favor, digite um nome", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                classCliente cCliente = new classCliente();
                dgvCliente.DataSource = cCliente.consultarClienteNomeContem(tbCliente.Text);
            }
        }

        private void btnGerarReport_Click(object sender, EventArgs e)
        {
            classReportVenda cReportVenda = new classReportVenda();

            string report = cbMetodoFiltro.SelectedItem.ToString();

            switch (report)
            {

                //Funcionario
                case "Funcionário":
                    if (cbFuncionario.SelectedIndex < 0)
                    {
                        MessageBox.Show("Nenhum funcionário foi encontrado.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if(checkIntervalorFuncionario.Checked == false)
                        {
                            if (MessageBox.Show("Deseja emitir um relatório sem um período definido? A geração do relatório pode ocasionar lentidão no sistema.", "Mangá no Sekai", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DataTable dadosReport = cReportVenda.ReportVendaFuncionario(Convert.ToInt32(cbFuncionario.SelectedValue));

                                if (dadosReport == null)
                                {
                                    MessageBox.Show("Não foi possível gerar o relatório.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (dadosReport.Rows.Count == 0)
                                {
                                    MessageBox.Show("Nenhuma venda foi encontrada para este funcionário.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    classReportVendaBindingSource.DataSource = dadosReport;
                                    this.reportViewer1.RefreshReport();
                                }
                            }
                        }
                        else
                        {
                            if (dtpfim.Value < dtpini.Value)
                            {
                                MessageBox.Show("Insira uma data válida", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                DataTable dadosReport = cReportVenda.ReportPeriodoFuncionario(dtpini.Value, dtpfim.Value, Convert.ToInt32(cbFuncionario.SelectedValue));

                                if (dadosReport == null)
                                {
                                    MessageBox.Show("Não foi possível gerar o relatório.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (dadosReport.Rows.Count == 0)
                                {
                                    MessageBox.Show("Nenhuma venda foi encontrada no período informado.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    classReportVendaBindingSource.DataSource = dadosReport;
                                    this.reportViewer1.RefreshReport();
                                }
                            }
                        }

                    }
                    
                    // Cliente
                    break;
                case "Cliente":
                    if (dgvCliente.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Pesquise e selecione um cliente.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (checkClienteIntervalo.Checked == false)
                        {
                            if(MessageBox.Show("Deseja emitir um relatório sem um período definido? A geração do relatório pode ocasionar lentidão no sistema.","Mangá no Sekai", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DataTable dadosReport = cReportVenda.ReportVendaCliente(Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value));

                                if (dadosReport == null)
                                {
                                    MessageBox.Show("Não foi possível gerar o relatório.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (dadosReport.Rows.Count == 0)
                                {
                                    MessageBox.Show("Nenhuma venda foi encontrada para este cliente.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    classReportVendaBindingSource.DataSource = dadosReport;
                                    this.reportViewer1.RefreshReport();
                                }
                            }
                        }
                        else
                        {
                            if (dtpfim.Value < dtpini.Value)
                            {
                                MessageBox.Show("Insira uma data válida", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                DataTable dadosReport = cReportVenda.ReportPeriodoCliente(dtpini.Value, dtpfim.Value, Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value));

                                if (dadosReport == null)
                                {
                                    MessageBox.Show("Não foi possível gerar o relatório.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (dadosReport.Rows.Count == 0)
                                {
                                    MessageBox.Show("Nenhuma venda foi encontrada no período informado.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    classReportVendaBindingSource.DataSource = dadosReport;
                                    this.reportViewer1.RefreshReport();
                                }
                            }
                        }
                    }


                    //Periodo
                    break;
                case "Período":
                    if (dtpfim.Value < dtpini.Value || dtpini.Value > dtpfim.Value)
                    {
                        MessageBox.Show("Insira uma data válida", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DataTable dadosReport = cReportVenda.ReportVendaDetalhadaData(dtpini.Value, dtpfim.Value);

                        if (dadosReport == null)
                        {
                            MessageBox.Show("Não foi possível gerar o relatório.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dadosReport.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhuma venda foi encontrada no período informado.", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            classReportVendaBindingSource.DataSource = dadosReport;
                            this.reportViewer1.RefreshReport();
                        }
                    }
                    break;

                default:

                    MessageBox.Show("Nenhum método de filtro selecionado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMetodoFiltro.Focus();


                    break;

            }

        }

        private void cbMetodoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodoFiltro.SelectedIndex == 0)
            {
                gbCliente.Enabled = false;
                gbIntervalo.Enabled = false;
                gbFuncionario.Enabled = false;
            }
            if (cbMetodoFiltro.SelectedIndex == 1)
            {
                gbCliente.Enabled = false;
                gbIntervalo.Enabled = false;
                gbFuncionario.Enabled = true;
            }
            if (cbMetodoFiltro.SelectedIndex == 2)
            {
                gbCliente.Enabled = true;
                gbIntervalo.Enabled = false;
                gbFuncionario.Enabled = false;
            }
            if(cbMetodoFiltro.SelectedIndex == 3)
            {
                gbCliente.Enabled = false;
                gbIntervalo.Enabled = true;
                gbFuncionario.Enabled = false;
            }
        }

        private void checkIntervalorFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if(checkIntervalorFuncionario.Checked == true)
            {
                gbIntervalo.Enabled = true;

            }
            else
            {
                gbIntervalo.Enabled = false;
            }
        }

        private void checkClienteIntervalo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkClienteIntervalo.Checked == true)
            {
                gbIntervalo.Enabled = true;
            }
            else
            {
                gbIntervalo.Enabled = false;
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
