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
    public partial class formRelCliente : Form
    {
        public formRelCliente()
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


        private void formRelCliente_Load(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            cboxopcoes.Items.Add("Nome do Cliente");
            cboxopcoes.Items.Add("Sexo");
            cboxopcoes.Items.Add("Cidade");
            cboxopcoes.Items.Add("Email");
            cboxopcoes.Items.Add("Telefone Celular");
            cboxopcoes.Items.Add("Data de Cadastro");
            cboxopcoes.Items.Add("CPF");
            cboxopcoes.Items.Add("Status");
            cboxopcoes.SelectedIndex = 0;

            cboxcidade.DataSource = cCliente.buscarCidade();
            cboxcidade.DisplayMember = "cidade";
            cboxcidade.ValueMember = "cidade";

            
            cboxsexo.Items.Add("Masculino");
            cboxsexo.Items.Add("Feminino");
            cboxsexo.Items.Add("Não informado");
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboxopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxopcoes.SelectedIndex == 0)
            {
                gbNome.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbEmail.Enabled = false;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbTelefone.Enabled = false;
                gbStatus.Enabled = false;
            }
            else if (cboxopcoes.SelectedIndex == 1)
            {
                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbCidade.Enabled = false;
                gbEmail.Enabled = false;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = true;
                gbTelefone.Enabled = false;
                gbStatus.Enabled = false;
            }
            else if (cboxopcoes.SelectedIndex == 2)
            {
                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
                gbEmail.Enabled = false;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbTelefone.Enabled = false;
                gbStatus.Enabled = false;
            }
            else if (cboxopcoes.SelectedIndex == 3)
            {
                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbEmail.Enabled = true;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbTelefone.Enabled = false;
                gbStatus.Enabled = false;

            }
            else if (cboxopcoes.SelectedIndex == 4)
            {
                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbEmail.Enabled = false;
                gbTelefone.Enabled = true;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;

            }
            else if (cboxopcoes.SelectedIndex == 5)
            {
                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbEmail.Enabled = false;
                gbTelefone.Enabled = false;
                gbdatacadastro.Enabled = true;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;

            }
            else if (cboxopcoes.SelectedIndex == 6)
            {

                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbEmail.Enabled = false;
                gbTelefone.Enabled = false;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = true;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;

            }
            else
            {
                gbNome.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbEmail.Enabled = false;
                gbTelefone.Enabled = false;
                gbdatacadastro.Enabled = false;
                gbCPF.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = true;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            switch (cboxopcoes.SelectedItem.ToString())
            {
                case "Nome do Cliente":
                    if (String.IsNullOrWhiteSpace(tbnome.Text))
                    {
                        MessageBox.Show("Por favor, informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbnome.Focus();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.ReportClienteNomeC(tbnome.Text);
                        this.reportViewer1.RefreshReport();
                    }
                    break;

                case "Sexo":
                    if (cboxsexo.SelectedIndex < 0)
                    {
                        MessageBox.Show("Por favor, selecione o sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboxsexo.Focus();
                    }
                    else
                    {
                        string sexo = cboxsexo.SelectedIndex == 0 ? "m" : cboxsexo.SelectedIndex == 1 ? "f" : "n";
                        classClienteBindingSource.DataSource = cCliente.ReportClientSexo(sexo);
                        this.reportViewer1.RefreshReport();
                    }
                    break;

                case "Cidade":
                    classClienteBindingSource.DataSource = cCliente.ReportClienteCidade(cboxcidade.SelectedValue.ToString());
                    this.reportViewer1.RefreshReport();
                    break;

                case "Email":
                    if (String.IsNullOrWhiteSpace(tbemail.Text))
                    {
                        MessageBox.Show("Por favor, informe o e-mail do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbemail.Focus();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.ReportClienteEmail(tbemail.Text);
                        this.reportViewer1.RefreshReport();
                    }
                    break;

                case "Telefone Celular":
                    if (!mtbtelcelular.MaskCompleted)
                    {
                        MessageBox.Show("Por favor, informe o telefone celular completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mtbtelcelular.Focus();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.ReportClienteTelCel(mtbtelcelular.Text);
                        this.reportViewer1.RefreshReport();
                    }
                    break;

                case "Data de Cadastro":
                    classClienteBindingSource.DataSource = cCliente.ReportClienteDataCadastro(dtpDataCadastro.Value);
                    this.reportViewer1.RefreshReport();
                    break;

                case "CPF":
                    if (!mtboxcpf.MaskCompleted)
                    {
                        MessageBox.Show("Por favor, informe o CPF completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mtboxcpf.Focus();
                    }
                    else
                    {
                        classClienteBindingSource.DataSource = cCliente.ReportClientCPF(mtboxcpf.Text);
                        this.reportViewer1.RefreshReport();
                    }
                    break;

                default:
                    classClienteBindingSource.DataSource = cCliente.ReportClienteStatus(rbAtivo.Checked ? 1 : 0);
                    this.reportViewer1.RefreshReport();
                    break;
            }
        }
    }
}
