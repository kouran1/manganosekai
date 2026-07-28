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
    public partial class fmccliente : Form
    {
        private void MetodoLimpar()
        {
            tbnomecliente.Clear();
            tbnomesocial.Clear();
            mtbdatanascimento.Clear();
            rbmasculino.Checked = true;
            mtboxcpf.Clear();
            mtboxrg.Clear();
            mtboxtelefoneresi.Clear();
            mtbtelefonecel.Clear();
            tbemail.Clear();
            mtbcep.Clear();
            tbendereco.Clear();
            tbnumero.Clear();
            tbcomplemento.Clear();
            tbbairro.Clear();
            cbuf.SelectedItem = "SP";
            lbdatacadastro.Text = DateTime.Now.ToString();
            tbcidade.Clear();
        }
        public fmccliente()
        {
            InitializeComponent();
            lbdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

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

            if (string.IsNullOrWhiteSpace(tbnomecliente.Text) || mtbdatanascimento.Text == "  /  /" || mtboxcpf.Text == "   .   .   -" || !temTelefone || string.IsNullOrWhiteSpace(tbendereco.Text) || string.IsNullOrWhiteSpace(tbnumero.Text) || string.IsNullOrWhiteSpace(tbbairro.Text) || string.IsNullOrWhiteSpace(tbcidade.Text) || cbuf.SelectedIndex == -1 )
            {
                MessageBox.Show("Preencher os campos destacados", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnomecliente.ForeColor = Color.PaleVioletRed;
                mtbdatanascimento.ForeColor = Color.PaleVioletRed;
                mtboxcpf.ForeColor = Color.PaleVioletRed;
                mtbtelefonecel.ForeColor = Color.PaleVioletRed;
                tbnumero.ForeColor = Color.PaleVioletRed;
                tbbairro.ForeColor = Color.PaleVioletRed;
                tbcidade.ForeColor = Color.PaleVioletRed;
                tbendereco.ForeColor = Color.PaleVioletRed;
                tbnomecliente.Focus();
                
            }
            else
            {
                cCliente.nome = tbnomecliente.Text;
                cCliente.nome_social = tbnomesocial.Text;
                if (mtboxcpf.Text == "  .   .   -")
                {
                    cCliente.cpf= "";

                }
                else
                {
                    cCliente.cpf = mtboxcpf.Text;
                }
                if (mtboxrg.Text == "  .   .   -")
                {
                    cCliente.rg = "";

                }
                else
                {
                    cCliente.rg = mtboxrg.Text;
                }


                cCliente.data_nascimento = Convert.ToDateTime(mtbdatanascimento.Text);

                //Sexo
                if (rbmasculino.Checked == true)
                {
                    cCliente.sexo = "m";
                }
                else if (rbna.Checked == true) //Sexo nao informado
                {
                    cCliente.sexo = "n";
                }
                else
                {
                    cCliente.sexo = "f";
                }

                if (mtboxtelefoneresi.Text == "(  )    -")
                {
                    cCliente.telefone_residencial = "";

                }
                else
                {
                    cCliente.telefone_residencial = mtboxtelefoneresi.Text;
                }

                if(mtbtelefonecel.Text == "(  )     -")
                {
                    cCliente.telefone_celular = "";
                }
                else
                {
                    cCliente.telefone_celular = mtbtelefonecel.Text;
                }

                cCliente.email = tbemail.Text;

                if(mtbcep.Text == "     -")
                {
                    cCliente.cep = "";
                }
                else
                {
                    cCliente.cep = mtbcep.Text;

                }

                cCliente.endereco = tbendereco.Text;
                cCliente.numero = Convert.ToInt32(tbnumero.Text);
                cCliente.complemento = tbcomplemento.Text;
                cCliente.bairro = tbbairro.Text;
                cCliente.cidade = tbcidade.Text;
                cCliente.uf = cbuf.SelectedItem.ToString();

                //Cadastro

                int resp = cCliente.cadastrarcliente();

                if(resp == 1)
                {
                    MessageBox.Show($"Cliente: {cCliente.nome} cadastrado com sucesso! ", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MetodoLimpar();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }






            }
        }
        public string tipo, uf;
        public DateTime data_cadastro;

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fmccliente_Load(object sender, EventArgs e)
        {
            cbuf.Items.Add("SP");
            cbuf.Items.Add("MG");
            cbuf.Items.Add("RJ");
            lbdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");


            if (tipo == "Atualização")
            {
                toolStripStatusLabel1.Text = "Atualização de funcionario";

                gboxsituacao.Enabled = true;
                btcadastrar.Enabled = false;
                lbdatacadastro.Text = data_cadastro.ToString("dd/MM/yyyy HH:mm");
                cbuf.SelectedItem = uf;


            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }
        }

        private void mtbdatanascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data invalida", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbdatanascimento.Focus();
            }
        }

        private void mtbcep_Leave(object sender, EventArgs e)
        {
            classViaCep.BuscarCep(mtbcep.Text, tbendereco, tbbairro, tbcidade, cbuf, tbnumero, this);
        }

        private void tbnomecliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbnomesocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

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

            if (string.IsNullOrWhiteSpace(tbnomecliente.Text) || mtbdatanascimento.Text == "  /  /" || mtboxcpf.Text == "   .   .   -" || !temTelefone || string.IsNullOrWhiteSpace(tbendereco.Text) || string.IsNullOrWhiteSpace(tbnumero.Text) || string.IsNullOrWhiteSpace(tbbairro.Text) || string.IsNullOrWhiteSpace(tbcidade.Text) || cbuf.SelectedIndex == -1)
            {
                MessageBox.Show("Preencher os campos destacados", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnomecliente.ForeColor = Color.PaleVioletRed;
                mtbdatanascimento.ForeColor = Color.PaleVioletRed;
                mtboxcpf.ForeColor = Color.PaleVioletRed;
                mtbtelefonecel.ForeColor = Color.PaleVioletRed;
                tbnumero.ForeColor = Color.PaleVioletRed;
                tbbairro.ForeColor = Color.PaleVioletRed;
                tbcidade.ForeColor = Color.PaleVioletRed;
                tbendereco.ForeColor = Color.PaleVioletRed;
                tbnomecliente.Focus();
                

            }
            else
            {
                cCliente.nome = tbnomecliente.Text;
                cCliente.nome_social = tbnomesocial.Text;
                if (mtboxcpf.Text == "  .   .   -")
                {
                    cCliente.cpf = "";

                }
                else
                {
                    cCliente.cpf = mtboxcpf.Text;
                }
                if (mtboxrg.Text == "  .   .   -")
                {
                    cCliente.rg = "";

                }
                else
                {
                    cCliente.rg = mtboxrg.Text;
                }


                cCliente.data_nascimento = Convert.ToDateTime(mtbdatanascimento.Text);

                //Sexo
                if (rbmasculino.Checked == true)
                {
                    cCliente.sexo = "M";
                }
                else if (rbna.Checked == true) //Sexo nao informado
                {
                    cCliente.sexo = "N";
                }
                else
                {
                    cCliente.sexo = "F";
                }

                if (mtboxtelefoneresi.Text == "(  )    -")
                {
                    cCliente.telefone_residencial = "";

                }
                else
                {
                    cCliente.telefone_residencial = mtboxtelefoneresi.Text;
                }

                if (mtbtelefonecel.Text == "(  )     -")
                {
                    cCliente.telefone_celular = "";
                }
                else
                {
                    cCliente.telefone_celular = mtbtelefonecel.Text;
                }

                cCliente.email = tbemail.Text;

                if (mtbcep.Text == "     -")
                {
                    cCliente.cep = "";
                }
                else
                {
                    cCliente.cep = mtbcep.Text;

                }
                cCliente.endereco = tbendereco.Text;
                cCliente.numero = Convert.ToInt32(tbnumero.Text);
                cCliente.complemento = tbcomplemento.Text;
                cCliente.bairro = tbbairro.Text;
                cCliente.cidade = tbcidade.Text;
                cCliente.uf = cbuf.SelectedItem.ToString();
                if(rbAtivo.Checked == true)
                {
                    cCliente.status = 1;
                }
                else
                {
                    cCliente.status = 0;
                }
                cCliente.data_cadastro = Convert.ToDateTime(lbdatacadastro.Text);
                cCliente.cod_cliente = Convert.ToInt32(tbcod.Text);

                int resp = cCliente.atualizarcliente();

                if (resp == 1)
                {
                    MessageBox.Show($"Cliente: {cCliente.nome} atualizado com sucesso! ", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MetodoLimpar();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao atualizar", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o cliente selecionado","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCliente cCliente = new classCliente();
                cCliente.cod_cliente = Convert.ToInt32(tbcod.Text);
                int resp = cCliente.deletarcliente();
                if (resp == 1)
                {
                    MessageBox.Show("Cliente excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                {                                             
                    MessageBox.Show("Data inválida!", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbdatanascimento.Clear();
                    mtbdatanascimento.Focus();
                }

            }
        }
    }
}
