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
    public partial class fmconsfuncionario : Form
    {
        public fmconsfuncionario()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void formConsFuncionario52_Load(object sender, EventArgs e)
        {
            cboxopcoes.Items.Add("Nome");
            cboxopcoes.Items.Add("Sexo");
            cboxopcoes.Items.Add("Cidade");
            cboxopcoes.Items.Add("Data de Admissão");
            cboxopcoes.Items.Add("Cargo");
            cboxopcoes.Items.Add("CPF");
            cboxopcoes.Items.Add("Status");
            cboxopcoes.Items.Add("Cidade & Sexo");

            cboxopcoes.SelectedIndex = 0;

            //Combo sexo
            cboxsexo.Items.Add("Masculino");
            cboxsexo.Items.Add("Feminino");
            cboxsexo.Items.Add("Não informado");

            cboxsexo.SelectedIndex = 0;

            classCargo cCargo = new classCargo();
            cboxcargo.DataSource = cCargo.buscarcargos();
            cboxcargo.DisplayMember = "nome";
            cboxcargo.ValueMember = "cod_cargo";
            cboxcargo.SelectedIndex = 0;

            classFuncionario cFuncionario = new classFuncionario();
            cboxcidade.DataSource = cFuncionario.buscarcidade();
            cboxcidade.DisplayMember = "cidade";
            cboxcidade.ValueMember = "cidade";
            cboxcidade.SelectedItem = 0 ;  








        }
        public void carregarsexocidade()
        {
            classFuncionario cFuncionario = new classFuncionario();
            if (cboxsexo.SelectedItem.ToString() == "Masculino")
            {
                dgvFuncionario.DataSource = cFuncionario.ConsultarFuncionarioCidadeSexo("M", Convert.ToString(cboxcidade.SelectedValue));
            }
            else if (cboxsexo.SelectedItem.ToString() == "Feminino")
            {
                dgvFuncionario.DataSource = cFuncionario.ConsultarFuncionarioCidadeSexo("F", Convert.ToString(cboxcidade.SelectedValue));
            }
            else
            {
                dgvFuncionario.DataSource = cFuncionario.ConsultarFuncionarioCidadeSexo("N", Convert.ToString(cboxcidade.SelectedValue));
            }
        }
        public void Metodocidadesexo()
        {
            classFuncionario cFuncionario = new classFuncionario();
            
        }
       
        private void gbConsFuncionario_Enter(object sender, EventArgs e)
        {

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


        private void cboxopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Habilitar/desabilitar componentes do form com a escolha do usuario
            if(cboxopcoes.SelectedIndex == 0)
            {
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbCargo.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = false;
                gbDataAdmissao.Enabled = false;
                tbnome.Focus();
            }
            else if (cboxopcoes.SelectedIndex == 1)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
                gbCargo.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = false;
                gbDataAdmissao.Enabled = false;
            }
            else if(cboxopcoes.SelectedIndex == 2)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
                gbCargo.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = false;
            }
            else if (cboxopcoes.SelectedIndex ==3)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbCargo.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = false;
                gbDataAdmissao.Enabled = true;
            }
            else if (cboxopcoes.SelectedIndex == 4)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbCargo.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = false;
                
            }
            else if (cboxopcoes.SelectedIndex ==5 )
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbCargo.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCPF.Enabled = true;
                gbStatus.Enabled = false;
                mtboxcpf.Focus();
            }
            else if (cboxopcoes.SelectedIndex == 6)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbCargo.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = true;
              
            }
            else if (cboxopcoes.SelectedIndex == 7)
            {
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = true;
                gbCargo.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCPF.Enabled = false;
                gbStatus.Enabled = false;

            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //Criar variavel para alimentar switch
            string filtro = cboxopcoes.SelectedItem.ToString();


            switch(filtro)
            {
                //Cargo
                case "Cargo":
                    dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioCargo(Convert.ToInt32(cboxcargo.SelectedValue));
                    break;
                case "Cidade":
                    dgvFuncionario.DataSource = cFuncionario.consultaFuncionarioCidade(Convert.ToString(cboxcidade.SelectedValue));
                    break;
                case "CPF":
                    if(mtboxcpf.Text != "   .   .   -")
                    {

                        dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioCpf(mtboxcpf.Text);
                    }
                    else
                    {
                        
                        MessageBox.Show("Preencher o campo destacado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtboxcpf.BackColor = Color.PaleVioletRed;
                        mtboxcpf.Focus();
                    }

                    break;
                case "Sexo":
                    if(cboxsexo.SelectedItem.ToString() == "Masculino")
                    {
                        dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioSexo("M");
                    }
                    else if(cboxsexo.SelectedItem.ToString() == "Feminino")
                    {
                        dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioSexo("F");
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioSexo("N");
                    }
                    break;
                case "Data de Admissão":
                    //Voltar para Validar a data inicial menor que data final
                    dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioDataCadastro(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));
                    break;
                case"Status":
                    if(rbInativo.Checked)
                    {
                        dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioStatus(0);
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioStatus(1);
                    }
                    break;
                case "Cidade & Sexo":
                    carregarsexocidade();
                    break;

                default:
                    if(string.IsNullOrWhiteSpace(tbnome.Text))
                    {
                        MessageBox.Show("Preencher o campo destacado", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbnome.BackColor = Color.PaleVioletRed;
                        tbnome.Focus();
                    }
                    else
                    {
                        if(rbInicio.Checked)
                        {
                            dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioNomeInicio(tbnome.Text);
                        }
                        else
                        {
                            dgvFuncionario.DataSource = cFuncionario.consultarFuncionarioNomeContem(tbnome.Text);
                        }
                    }

                    break;



          
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Clicar na grid de funcionario e editar ou excluir um funcionario
            //Usar o evento CellClick (Pode clicar em qualquer lugar da celular, nao somente no texto)
            //Usando o evento CellContentClick (TEM QUE CLICAR NO CONTEUDO(texto))

            //Perguntar para usuario se realmente deseja alterar o funcionario selecionado
            if(MessageBox.Show("Deseja alterar ou excluir o funcionário selecionado?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                classFuncionario cfuncionario = new classFuncionario();
                //Instanciar a classe funcionario
                //Instanciar o form funcionario de cadastro - paraq mandar as informaçoes do BD para o form
                fmcfuncionarios objfmcfuncionarios = new fmcfuncionarios();
                //Pegar o funcionario escolhido pelo usuario através da seleção da grid
                cfuncionario.dadosfuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

                //Passar os dados do banco para os elementos do form

                objfmcfuncionarios.tbcodfunc.Text = cfuncionario.cod_funcionario.ToString();
                objfmcfuncionarios.tbnomefuncionario.Text = cfuncionario.nome.ToString();
                objfmcfuncionarios.tbnomesocial.Text = cfuncionario.nome_social.ToString();
                objfmcfuncionarios.dtpnascimento.Value = cfuncionario.data_nascimento.Date;


                // Sexo

                if(cfuncionario.sexo =="M")
                {
                    objfmcfuncionarios.rbmasculino.Checked = true;
                }
                else if(cfuncionario.sexo == "F")
                {
                    objfmcfuncionarios.rbfeminino.Checked = true;
                }
                else
                {
                    objfmcfuncionarios.rbna.Checked = true;
                }

                // Estado civil - combobox - passar variavel declarado no form

                objfmcfuncionarios.estado_civil = cfuncionario.estado_civil;
                objfmcfuncionarios.mtboxcpf.Text = cfuncionario.cpf.ToString();
                objfmcfuncionarios.mtboxrg.Text = cfuncionario.rg.ToString();
                objfmcfuncionarios.tbsalario.Text = cfuncionario.salario.ToString();
                objfmcfuncionarios.data_cadastro = cfuncionario.data_cadastro;
                objfmcfuncionarios.tblogin.Text = cfuncionario.usuario.ToString();
                //tipo acesso

                if(cfuncionario.tipo_acesso ==0)
                {
                    objfmcfuncionarios.tipo_acesso = 0;
                }
                else
                {
                    objfmcfuncionarios.tipo_acesso = 1;
                }
                objfmcfuncionarios.tbsenha.Text = cfuncionario.senha.ToString();
                //Passar variavel declarada no FORM
                objfmcfuncionarios.cargo = cfuncionario.cod_cargo;
                //objfmcfuncionarios.tbfot.Text = cfuncionario.numero.ToString();
                objfmcfuncionarios.mtbtelefonecel.Text = cfuncionario.telefone_celular;
                objfmcfuncionarios.mtboxtelefoneresi.Text = cfuncionario.telefone_residencial.ToString();
                objfmcfuncionarios.tbemail.Text = cfuncionario.email.ToString();
                objfmcfuncionarios.tbendereco.Text = cfuncionario.endereco.ToString();
                objfmcfuncionarios.tbnumero.Text = cfuncionario.numero.ToString();
                objfmcfuncionarios.tbcomplemento.Text = cfuncionario.complemento.ToString();
                objfmcfuncionarios.tbbairro.Text = cfuncionario.bairro.ToString();
                objfmcfuncionarios.tbcidade.Text = cfuncionario.cidade.ToString();
                objfmcfuncionarios.uf = cfuncionario.uf;
                objfmcfuncionarios.mtbcep.Text = cfuncionario.cep.ToString();
                //status
                if(cfuncionario.status == 1)
                {
                    objfmcfuncionarios.rbAtivo.Checked = true;
                }
                else
                {
                    objfmcfuncionarios.rbinativo.Checked = true;
                }


                //passar para a variavel tipo declarada no form de cadastro como ele sera aberto - Atualização
                objfmcfuncionarios.tipo = "Atualização";
                objfmcfuncionarios.ShowDialog();

                //atualizar a grid de consulta

                btPesquisar_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Não há funcionários cadastrados com esses filtros", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboxcidade_SelectedIndexChanged(object sender, EventArgs e)
        {

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
