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
    public partial class fmccargo : Form
    {
        public fmccargo()
        {
            InitializeComponent();
            lbdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            tbcargo.MaxLength = 40;
            tbobservacao.MaxLength = 100;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public string tipo;
        public DateTime data_cadastro;

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            //Criar objeto da classe cargo para usar proprieades e metodos da classe
            classCargo cCargo = new classCargo();

            //Verificar se todos os campos obrigatorios estao preenchidos

            if (string.IsNullOrWhiteSpace(tbcargo.Text))
            {
                MessageBox.Show("Preencher o campo mencionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcargo.BackColor = Color.PaleVioletRed;
            }
            else
            {
                //Passar para as propriedades da classe o conteudo de todos os elementos do form que o usuario pode preencher
                cCargo.nome = tbcargo.Text;
                cCargo.observacao = tbobservacao.Text;

                //Chamar metodo cadastrar da classe cargo
                int resp = cCargo.cadastrarcargo();

                if(resp == 1)
                {
                    MessageBox.Show($"Cargo: {cCargo.nome} cadastrado com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcargo.Clear();
                    tbobservacao.Clear();
                    tbcargo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

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


        private void fmccargo_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização")
            {
                toolStripStatusLabel1.Text = "Atualização de funcionario";

                gboxsituacao.Enabled = true;
                btcadastrar.Enabled = false;
                lbdatacadastro.Text = data_cadastro.ToString("dd/MM/yyyy HH:mm");

            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            //Criar objeto da classe cargo para usar proprieades e metodos da classe
            classCargo cCargo = new classCargo();

            //Verificar se todos os campos obrigatorios estao preenchidos

            if (string.IsNullOrWhiteSpace(tbcargo.Text))
            {
                MessageBox.Show("Preencher o campo mencionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcargo.BackColor = Color.PaleVioletRed;
            }
            else
            {

                cCargo.nome = tbcargo.Text;

                if(rbativo.Checked == true)
                {
                    cCargo.status = 1;
                }
                else
                {
                    cCargo.status = 0;
                }
                cCargo.observacao = tbobservacao.Text;
                cCargo.cod_cargo = Convert.ToInt32(tbcodigocargo.Text);

                int resp = cCargo.atualizarcargo();


                //Mostrar o resultado do metodo para o usuario
                //Se deu certo - atualizar realizado 1

                if (resp == 1)
                {
                    MessageBox.Show($"Cargo: {cCargo.nome} atualizado com sucesso!", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (MessageBox.Show($"Deseja excluir o cargo {tbcargo.Text}? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCargo cCargo = new classCargo();
                cCargo.cod_cargo = Convert.ToInt32(tbcodigocargo.Text);

                int resp = cCargo.deletarcargo();
                if (resp == 1)
                {
                    MessageBox.Show("Cargo excluído com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void lbdatacadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
