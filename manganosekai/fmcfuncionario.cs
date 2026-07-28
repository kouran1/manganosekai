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
    public partial class fmcfuncionarios : Form
    {
        public fmcfuncionarios()
        {
            InitializeComponent();
        }



        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void gbsalario_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mtbcep_Leave(object sender, EventArgs e)
        {
            classViaCep.BuscarCep(mtbcep.Text, tbendereco, tbbairro, tbcidade, cbuf, tbnumero, this);
        }
        //Criar variaveis que serão utuluzadas no form de consulta
        //tipo - maneira qyue o form sera aberto
        //outras variaveis no bd  e nãi declaradios no load do form
        public string tipo, estado_civil, uf;
        public int cargo, tipo_acesso;
        public DateTime data_cadastro;


        private void fmcfuncionarios_Load(object sender, EventArgs e)
        {
            //CARREGAR HORARIO E DATA NO SISTEMA

            lbdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); ;

            //Carregar combo

            //Combo Estado
            cbuf.Items.Add("AC");
            cbuf.Items.Add("AL");
            cbuf.Items.Add("AP");
            cbuf.Items.Add("AM");
            cbuf.Items.Add("BA");
            cbuf.Items.Add("CE");
            cbuf.Items.Add("DF");
            cbuf.Items.Add("ES");
            cbuf.Items.Add("GO");
            cbuf.Items.Add("MA");
            cbuf.Items.Add("MT");
            cbuf.Items.Add("MS");
            cbuf.Items.Add("MG");
            cbuf.Items.Add("PA");
            cbuf.Items.Add("PB");
            cbuf.Items.Add("PR");
            cbuf.Items.Add("PE");
            cbuf.Items.Add("PI");
            cbuf.Items.Add("RJ");
            cbuf.Items.Add("RN");
            cbuf.Items.Add("RS");
            cbuf.Items.Add("RO");
            cbuf.Items.Add("RR");
            cbuf.Items.Add("SC");
            cbuf.Items.Add("SP");
            cbuf.Items.Add("SE");
            cbuf.Items.Add("TO");

            //Deixar a opcao selecionado
            cbuf.SelectedItem = "SP";

            //COMBO ESTADO CIVIL
            cbestadocivil.Items.Add("Solteiro(a)");
            cbestadocivil.Items.Add("Casado(a)");
            cbestadocivil.Items.Add("Separado(a)");
            cbestadocivil.Items.Add("Divorciado(a)");
            cbestadocivil.Items.Add("Viuvo(a)");
            cbestadocivil.SelectedIndex = 0;


            //COMBO
            cbacesso.Items.Add("Comum");
            cbacesso.Items.Add("Administrador");
            cbacesso.SelectedIndex = 0;

            //Combo Cargo - Alimentada pelo BD atraves do metodo buscarcargo em classCargo.cs
            //Criar objeto da classe cargo para usar o metodo que vai carregar a combo
            classCargo cCargo = new classCargo();
            //Chamar o metodo que carrega a combo cargo
            cboxcargo.DataSource = cCargo.buscarcargos();
            //O que ser exibido na Combo - nome da coluna no bd
            cboxcargo.DisplayMember = "nome";
            //O que sera armazenado - nome da coluna no BD
            cboxcargo.ValueMember = "cod_cargo";
            //Não deixar nenhum cargo selecionado
            cboxcargo.SelectedIndex = -1;

            if(tipo == "Atualização")
            {
                lbtitulo.Text = "Atualização de funcionario";

                gboxsituacao.Enabled = true;
                btcadastrar.Enabled = false;
                lbdatacadastro.Text = data_cadastro.ToString("dd/MM/yyyy HH:mm");
                cbuf.SelectedItem = uf;
                cbestadocivil.SelectedItem = estado_civil;
                cboxcargo.SelectedValue = cargo;
                if(tipo_acesso == 0)
                {
                    cbacesso.SelectedItem = "Comum";
                }
                else
                {
                    cbacesso.SelectedItem = "Administrador";
                }


            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }


        }
        //Metodo para validar campos obrigatorios no form
        private void CamposObrigatorios()
        {
            tbnomefuncionario.BackColor = Color.PaleVioletRed;
            mtbdatanascimento.BackColor = Color.PaleVioletRed;
            gboxsexo.BackColor = Color.PaleVioletRed;
            mtboxcpf.BackColor = Color.PaleVioletRed;
            gbendereco.BackColor = Color.PaleVioletRed;
            mtbtelefonecel.BackColor = Color.PaleVioletRed;
            gblogin.BackColor = Color.PaleVioletRed;
            cboxcargo.BackColor = Color.PaleVioletRed;
            tbnomefuncionario.Focus();

        }

        //Metodo para limpar todos os campos apos realizar o cadastro
        private void MetodoLimpar()
        {
            tbnomefuncionario.Clear();
            tbnomesocial.Clear();
            mtbdatanascimento.Clear();
            rbmasculino.Checked = true ;
            cbestadocivil.SelectedIndex = 0;
            mtboxcpf.Clear();
            mtboxrg.Clear();
            cboxcargo.SelectedIndex = -1;
            mtboxtelefoneresi.Clear();
            mtbtelefonecel.Clear();
            tbemail.Clear();
            tbsalario.Clear();
            tblogin.Clear();
            tbsenha.Clear();
            cbacesso.SelectedIndex = 0;
            mtbcep.Clear();
            tbendereco.Clear();
            tbnumero.Clear();
            tbcomplemento.Clear();
            tbbairro.Clear();
            cbuf.SelectedItem = "SP";
            lbdatacadastro.Text = DateTime.Now.ToString();
            tbcidade.Clear();
        }




        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {

            classFuncionario cFuncionario = new classFuncionario();


            bool temTelefone = false;

            if (mtboxtelefoneresi.Text != "(  )    -")
            {
                temTelefone = true;
            }
            else if (mtbtelefonecel.Text != "(  )     -")
            {
                temTelefone = true;
            }
            else
            {
                temTelefone = false;
            }

            if (string.IsNullOrWhiteSpace(tbnomefuncionario.Text) || !temTelefone ||mtboxcpf.Text == "   .   .   -" ||mtbtelefonecel.Text == "(  )     -" || string.IsNullOrWhiteSpace(tbendereco.Text) || string.IsNullOrWhiteSpace(tbnumero.Text) || string.IsNullOrWhiteSpace(tbbairro.Text) || string.IsNullOrWhiteSpace(tbcidade.Text) || string.IsNullOrWhiteSpace(tblogin.Text) || string.IsNullOrWhiteSpace(tbsenha.Text) || cboxcargo.SelectedIndex == -1)
            {

                MessageBox.Show("Verificar os campos listados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
            }
            else //Usuario preencheu os campos bonitinho
            {
                //Passar para as propriedades da classe o que foi inserido pelo usuario pelo usuario no FORM
                cFuncionario.nome = tbnomefuncionario.Text;
                cFuncionario.nome_social = tbnomesocial.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(mtbdatanascimento.Text);

                //Sexo
                if (rbmasculino.Checked == true)
                {
                    cFuncionario.sexo = "m";
                }
                else if (rbna.Checked == true) //Sexo nao informado
                {
                    cFuncionario.sexo = "n";
                }
                else 
                {
                    cFuncionario.sexo = "f";
                }

                //estado civil - PEGAR OPCAO ESCOLHIDA PELO USUARIO

                cFuncionario.estado_civil = cbestadocivil.SelectedItem.ToString();
                cFuncionario.cpf = mtboxcpf.Text;
                //RG é campo nao obrigatorio - fazer if para mandar vazio caso o usuario nao preencha
                if(mtboxrg.Text == "  .   .   -")
                {
                    cFuncionario.rg = "";

                }
                else
                {
                    cFuncionario.rg = mtboxrg.Text;
                }

                //SALARIO - CAMPO NUMERICO NAO OBRIGATORIO NO BD - NAO PODE IR VAZIO, FAZIO IF PARA MANDAR 0 CASO NAO PREENCHIDO PELO USUARIO
                if(tbsalario.Text =="")
                {
                    cFuncionario.salario = 0;

                }
                else
                {
                    cFuncionario.salario = Convert.ToDecimal(tbsalario.Text);
                }
                cFuncionario.endereco = tbendereco.Text;
                cFuncionario.numero = Convert.ToInt32(tbnumero.Text);
                cFuncionario.complemento = tbcomplemento.Text;
                cFuncionario.bairro = tbbairro.Text;
                cFuncionario.cidade = tbcidade.Text;
                cFuncionario.uf = cbuf.SelectedItem.ToString();

                //CEP - é mascara e é não obrigatorio
                if(mtbcep.Text == "     -")
                {
                    cFuncionario.cep = "";
                }
                else
                {
                    cFuncionario.cep = mtbcep.Text;
                }

                //TELEFONES
                if(mtboxtelefoneresi.Text== "(  )    -")
                {
                    cFuncionario.telefone_residencial = "";

                }
                else
                {
                    cFuncionario.telefone_residencial = mtboxtelefoneresi.Text;

                }
                //Celular
                if(mtbtelefonecel.Text == "(  )     -")
                {
                    cFuncionario.telefone_celular = "";
                }
                else
                {
                    cFuncionario.telefone_celular = mtbtelefonecel.Text;
                }
                cFuncionario.email = tbemail.Text;
                cFuncionario.usuario = tblogin.Text;
                cFuncionario.senha = tbsenha.Text;
                //TIPO ACESSO
                if(cbacesso.SelectedItem.ToString() == "Comum")
                {
                    cFuncionario.tipo_acesso = 0;
                }
                else
                {
                    cFuncionario.tipo_acesso = 1;
                }

                cFuncionario.foto = "";


                //Codigo cargo - chave estrangeira - usar a propriedade selectedvalue da combobox
                cFuncionario.cod_cargo = Convert.ToInt32(cboxcargo.SelectedValue);

                //Chamar o metodo de cadastro de funcionario da classe funcionario
                int resp = cFuncionario.cadastrarfuncionario();


                //Mostrar o resultado do metodo para o usuario
                //Se deu certo - cadastro realizado 1

                if(resp == 1)
                {
                    MessageBox.Show($"Funcionario: {cFuncionario.nome} cadastrado com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MetodoLimpar();
                }
                //Se não - falha ao cadastrar
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void cboxcargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbdatanascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbnomefuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtboxtelefoneresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void mtbtelefonecel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mtbcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mtboxrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mtboxcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else if (e.KeyChar != 8)
            {
                string texto = tbsalario.Text.Replace(",", "").Replace(".", "") + e.KeyChar;
                if (texto.Length > 6)
                {
                    e.Handled = true;
                }
                else
                {
                    double valor = Convert.ToDouble(texto);
                    tbsalario.Text = (valor / 100).ToString("N2");
                    tbsalario.SelectionStart = tbsalario.Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void mtbdatanascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbdatanascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(!e.IsValidInput)
            {
                MessageBox.Show("Data invalida", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbdatanascimento.Focus();
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();


            bool temTelefone = false;

            if (mtboxtelefoneresi.Text != "(  )    -")
            {
                temTelefone = true;
            }
            else if (mtbtelefonecel.Text != "(  )     -")
            {
                temTelefone = true;
            }
            else
            {
                temTelefone = false;
            }

            if (string.IsNullOrWhiteSpace(tbnomefuncionario.Text) || !temTelefone || mtboxcpf.Text == "   .   .   -" || mtbtelefonecel.Text == "(  )     -" || string.IsNullOrWhiteSpace(tbendereco.Text) || string.IsNullOrWhiteSpace(tbnumero.Text) || string.IsNullOrWhiteSpace(tbbairro.Text) || string.IsNullOrWhiteSpace(tbcidade.Text) || string.IsNullOrWhiteSpace(tblogin.Text) || string.IsNullOrWhiteSpace(tbsenha.Text) || cboxcargo.SelectedIndex == -1)
            {

                MessageBox.Show("Verificar os campos listados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
            }
            else //Usuario preencheu os campos bonitinho
            {
                //Passar para as propriedades da classe o que foi inserido pelo usuario pelo usuario no FORM
                cFuncionario.nome = tbnomefuncionario.Text;
                cFuncionario.nome_social = tbnomesocial.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(mtbdatanascimento.Text);

                //Sexo
                if (rbmasculino.Checked == true)
                {
                    cFuncionario.sexo = "m";
                }
                else if (rbna.Checked == true) //Sexo nao informado
                {
                    cFuncionario.sexo = "n";
                }
                else
                {
                    cFuncionario.sexo = "f";
                }

                //estado civil - PEGAR OPCAO ESCOLHIDA PELO USUARIO

                cFuncionario.estado_civil = cbestadocivil.SelectedItem.ToString();
                cFuncionario.cpf = mtboxcpf.Text;
                //RG é campo nao obrigatorio - fazer if para mandar vazio caso o usuario nao preencha
                if (mtboxrg.Text == "  .   .   -")
                {
                    cFuncionario.rg = "";

                }
                else
                {
                    cFuncionario.rg = mtboxrg.Text;
                }
                //status
                if(rbAtivo.Checked ==true)
                {
                    cFuncionario.status = 1;
                }
                else
                {
                    cFuncionario.status = 0;
                }

                //SALARIO - CAMPO NUMERICO NAO OBRIGATORIO NO BD - NAO PODE IR VAZIO, FAZIO IF PARA MANDAR 0 CASO NAO PREENCHIDO PELO USUARIO
                if (tbsalario.Text == "")
                {
                    cFuncionario.salario = 0;

                }
                else
                {
                    cFuncionario.salario = Convert.ToDecimal(tbsalario.Text);
                }
                cFuncionario.endereco = tbendereco.Text;
                cFuncionario.numero = Convert.ToInt32(tbnumero.Text);
                cFuncionario.complemento = tbcomplemento.Text;
                cFuncionario.bairro = tbbairro.Text;
                cFuncionario.cidade = tbcidade.Text;
                cFuncionario.uf = cbuf.SelectedItem.ToString();

                //CEP - é mascara e é não obrigatorio
                if (mtbcep.Text == "     -")
                {
                    cFuncionario.cep = "";
                }
                else
                {
                    cFuncionario.cep = mtbcep.Text;
                }

                //TELEFONES
                if (mtboxtelefoneresi.Text == "(  )    -")
                {
                    cFuncionario.telefone_residencial = "";

                }
                else
                {
                    cFuncionario.telefone_residencial = mtboxtelefoneresi.Text;

                }
                //Celular
                if (mtbtelefonecel.Text == "(  )     -")
                {
                    cFuncionario.telefone_celular = "";
                }
                else
                {
                    cFuncionario.telefone_celular = mtbtelefonecel.Text;
                }
                cFuncionario.email = tbemail.Text;
                cFuncionario.usuario = tblogin.Text;
                cFuncionario.senha = tbsenha.Text;
                //TIPO ACESSO
                if (cbacesso.SelectedItem.ToString() == "Comum")
                {
                    cFuncionario.tipo_acesso = 0;
                }
                else
                {
                    cFuncionario.tipo_acesso = 1;
                }

                cFuncionario.foto = "";

                //carregar codigo do carro do usuario
                cFuncionario.cod_funcionario = Convert.ToInt32(tbcodfunc.Text);


                //Codigo cargo - chave estrangeira - usar a propriedade selectedvalue da combobox
                cFuncionario.cod_cargo = Convert.ToInt32(cboxcargo.SelectedValue);

                //Chamar o metodo de cadastro de funcionario da classe funcionario
                int resp = cFuncionario.atualizarFuncionario();


                //Mostrar o resultado do metodo para o usuario
                //Se deu certo - atualizar realizado 1

                if (resp == 1)
                {
                    MessageBox.Show($"Funcionario: {cFuncionario.nome} atualizado com sucesso!", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                //Se não - falha ao cadastrar
                else
                {
                    MessageBox.Show("Erro ao atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                }

            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Deseja excluir {tbnomefuncionario.Text}? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFuncionario cfuncionario = new classFuncionario();
                cfuncionario.cod_funcionario = Convert.ToInt32(tbcodfunc.Text);

                int resp = cfuncionario.deletarUsuario();
                if(resp == 1)
                {
                    MessageBox.Show("Funcionario excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void mtbcep_Leave_1(object sender, EventArgs e)
        {
            classViaCep.BuscarCep(mtbcep.Text, tbendereco, tbbairro, tbcidade, cbuf, tbnumero, this);
        }

        private void tbnomesocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtbdatanascimento_Leave(object sender, EventArgs e)
        {
            if (mtbdatanascimento.Text == "  /  /")
            {
                MessageBox.Show("Preencha a data!", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbdatanascimento.Focus();
            }
            else
            {
                //ARRAY
                string[] partes = mtbdatanascimento.Text.Split('/');

                int dia = Convert.ToInt32(partes[0]); // Array dia
                int mes = Convert.ToInt32(partes[1]); // Array mês
                int ano = Convert.ToInt32(partes[2]); // Array ano

                if (dia < 1 || dia > 31 || mes < 1 || mes > 12 || ano < 1900 || ano > DateTime.Now.Year)
                {                                              // ← faltava essa chave
                    MessageBox.Show("Data inválida!", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbdatanascimento.Clear();
                    mtbdatanascimento.Focus();
                }

            }
        }
    }
}
