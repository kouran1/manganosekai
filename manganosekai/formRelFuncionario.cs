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
    public partial class formRelFuncionario : Form
    {
        public formRelFuncionario()
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



        private void formRelFuncionario_Load(object sender, EventArgs e)
        {
            
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes do Mês");     
            cbTipoRel.Items.Add("Cargo");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Data de Admissão");
            cbTipoRel.Items.Add("Idade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.SelectedIndex = 0;

            classFuncionario cFuncionario = new classFuncionario();
            cbCidade.DataSource = cFuncionario.buscarcidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedItem = 0;

            classCargo cCargo = new classCargo();
            cbCargo.DataSource = cCargo.buscarcargos();
            cbCargo.DisplayMember = "nome";
            cbCargo.ValueMember = "cod_cargo";
            cbCargo.SelectedIndex = 0;
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
           
            if (cbTipoRel.SelectedIndex == 1)//Cargo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = true;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 3)//Data de Admissão
            {
                gbAniversariantes.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 4)//Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 5)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 6)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch(relatorio)
            {
                case "Idade":
                    if(String.IsNullOrEmpty(txtIdadeInicial.Text) && String.IsNullOrWhiteSpace(txtIdadeFinal.Text))
                    {
                        MessageBox.Show("Por favor insira todos os valores nos campos destacados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdadeFinal.BackColor = Color.PaleVioletRed;
                        txtIdadeInicial.Focus();
                        txtIdadeInicial.BackColor = Color.PaleVioletRed;
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = 
                        cFuncionario.ReportFuncionariosIdade(Convert.ToInt32(txtIdadeInicial.Text), Convert.ToInt32(txtIdadeFinal.Text));
                        this.reportViewer.RefreshReport();

                    }
                    break;

                case "Cargo":
                    classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioCargo(Convert.ToInt32(cbCargo.SelectedValue));
                    this.reportViewer.RefreshReport();
                    break;
                case "Cidade":
                    classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioCidade(cbCidade.SelectedValue.ToString());
                    this.reportViewer.RefreshReport();
                    break;
                case "Data de Admissão":
                    if(dtpDataInicial.Value > dtpDataFinal.Value || dtpDataFinal.Value < dtpDataInicial.Value)
                    {
                        MessageBox.Show("Insira um intervalo de datas válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioDataAdmissao(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));
                        this.reportViewer.RefreshReport();
                    }
                   
                    break;
                case "Sexo":
                    if(cbSexo.SelectedIndex == 1)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioSexo("f");
                        this.reportViewer.RefreshReport();
                    }
                    else if(cbSexo.SelectedIndex == 2)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioSexo("m");
                        this.reportViewer.RefreshReport();
                    }
                    else if (cbSexo.SelectedIndex == 3)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioSexo("n");
                        this.reportViewer.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Escolha um valor válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbSexo.Focus();
                    }
 
                    break;

                case "Status":
                    if(rbAtivo.Checked)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioStatus(1);
                        this.reportViewer.RefreshReport();
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioStatus(0);
                        this.reportViewer.RefreshReport();
                    }
                    
                    break;

                   

                default:
                    if(cbMes.SelectedIndex == 0)
                    {
                        MessageBox.Show("Selecione um mês válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbMes.Focus();
                        cbMes.ForeColor = Color.PaleVioletRed;
                        
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.ReportFuncionarioBirthdayMonth(cbMes.SelectedIndex);
                        this.reportViewer.RefreshReport();
                    }

                    break;
            }
        }

        private void classFuncionarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
