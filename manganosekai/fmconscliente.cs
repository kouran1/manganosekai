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
    public partial class fmconscliente : Form
    {
        public fmconscliente()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            //Criar variavel para alimentar switch
            string filtro = cboxopcoes.SelectedItem.ToString();


            switch (filtro)
            {
                //Cargo
                case "Email":
                    dgvCliente.DataSource = cCliente.consultarClienteEmail(tbemail.Text);
                    break;
                case "Cidade":
                    dgvCliente.DataSource = cCliente.consultarClienteCidade(Convert.ToString(cboxcidade.SelectedValue));
                    break;
                case "CPF":
                    if (mtboxcpf.Text != "   .   .   -")
                    {

                        dgvCliente.DataSource = cCliente.consultarClienteCpf(mtboxcpf.Text);
                    }
                    else
                    {

                        MessageBox.Show("Preencher o campo destacado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtboxcpf.BackColor = Color.PaleVioletRed;
                        mtboxcpf.Focus();
                    }

                    break;
                case "Sexo":
                    if (cboxsexo.SelectedItem.ToString() == "Masculino")
                    {
                        dgvCliente.DataSource = cCliente.consultarClienteSexo("M");
                    }
                    else if (cboxsexo.SelectedItem.ToString() == "Feminino")
                    {
                        dgvCliente.DataSource = cCliente.consultarClienteSexo("F");
                    }
                    else
                    {
                        dgvCliente.DataSource = cCliente.consultarClienteSexo("N");
                    }
                    break;
                case "Data de Cadastro":
                    dgvCliente.DataSource = cCliente.consultarClienteData(Convert.ToDateTime(dtpDataCadastro.Text));
                    break;
                case "Status":
                    if (rbInativo.Checked)
                    {
                        dgvCliente.DataSource = cCliente.consultarClienteStatus(0);
                    }
                    else
                    {
                        dgvCliente.DataSource = cCliente.consultarClienteStatus(1);
                    }
                    break;
                case "Telefone Celular":
                    if(mtbtelcelular.Text != "   .   .   -")
                    {
                        dgvCliente.DataSource = cCliente.consultarClienteTelCelular(mtbtelcelular.ToString());
                    }
                    else
                    {

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
                            dgvCliente.DataSource = cCliente.consultarClienteNomeIni(tbnome.Text);
                        }
                        else
                        {
                            dgvCliente.DataSource = cCliente.consultarClienteNomeContem(tbnome.Text);
                        }
                    }
                    break;

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



        private void gbConsFuncionario_Enter(object sender, EventArgs e)
        {

        }

        private void fmconscliente_Load(object sender, EventArgs e)
        {
            cboxopcoes.Items.Add("Nome do Cliente");
            cboxopcoes.Items.Add("Sexo");
            cboxopcoes.Items.Add("Cidade");
            cboxopcoes.Items.Add("Email");
            cboxopcoes.Items.Add("Telefone Celular");
            cboxopcoes.Items.Add("Data de Cadastro");
            cboxopcoes.Items.Add("CPF");
            cboxopcoes.Items.Add("Status");
            cboxopcoes.SelectedIndex = 0;

            //Combo sexo
            cboxsexo.Items.Add("Masculino");
            cboxsexo.Items.Add("Feminino");
            cboxsexo.Items.Add("Não informado");


        }

        private void cboxopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxopcoes.SelectedIndex == 0)
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
                gbTipoPesquisa.Enabled = false;
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
                gbTipoPesquisa.Enabled = false;
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
                gbTipoPesquisa.Enabled = false;
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
                gbTipoPesquisa.Enabled = false;
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
                gbTipoPesquisa.Enabled = false;
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
                gbTipoPesquisa.Enabled = false;
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
                gbTipoPesquisa.Enabled = false;
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

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar ou excluir o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCliente cCliente = new classCliente();
                fmccliente objfmccliente = new fmccliente();           
                cCliente.dadoscliente(Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value));

                objfmccliente.tbcod.Text = cCliente.cod_cliente.ToString();
                objfmccliente.tbnomecliente.Text = cCliente.nome.ToString();
                objfmccliente.tbnomesocial.Text = cCliente.nome_social.ToString();
                objfmccliente.dtpnascimento.Value = cCliente.data_nascimento.Date;
                if (cCliente.sexo == "M")
                {
                    objfmccliente.rbmasculino.Checked = true;
                }
                else if (cCliente.sexo == "F")
                {
                    objfmccliente.rbfeminino.Checked = true;
                }
                else
                {
                    objfmccliente.rbna.Checked = true;
                }
                objfmccliente.mtboxcpf.Text = cCliente.cpf.ToString();
                objfmccliente.mtboxrg.Text = cCliente.rg.ToString();
                objfmccliente.data_cadastro = cCliente.data_cadastro;
                objfmccliente.mtbtelefonecel.Text = cCliente.telefone_celular;
                objfmccliente.mtboxtelefoneresi.Text = cCliente.telefone_residencial.ToString();
                objfmccliente.tbemail.Text = cCliente.email.ToString();
                objfmccliente.tbendereco.Text = cCliente.endereco.ToString();
                objfmccliente.tbnumero.Text = cCliente.numero.ToString();
                objfmccliente.tbcomplemento.Text = cCliente.complemento.ToString();
                objfmccliente.tbbairro.Text = cCliente.bairro.ToString();
                objfmccliente.tbcidade.Text = cCliente.cidade.ToString();
                objfmccliente.uf = cCliente.uf;
                objfmccliente.mtbcep.Text = cCliente.cep.ToString();

                if (cCliente.status == 1)
                {
                    objfmccliente.rbAtivo.Checked = true;
                }
                else
                {
                    objfmccliente.rbinativo.Checked = true;
                }
                objfmccliente.tipo = "Atualização";
                objfmccliente.ShowDialog();
                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Não há clientes cadastrados com esses filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
 }
