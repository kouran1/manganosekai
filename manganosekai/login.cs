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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
                
            tb_password.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_user.Text) || string.IsNullOrWhiteSpace(tb_password.Text))
            {
                MessageBox.Show("Por favor insira uma credencial válida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                classFuncionario cFuncionario = new classFuncionario();

                if (cFuncionario.loginUser(tb_user.Text, tb_password.Text))
                {
                    fmcprincipal fprincipal = new fmcprincipal();
                    fprincipal.statuslbmensagem.Text = $"Bem vindo, {tb_user.Text.ToUpper()}";
                    fprincipal.Show();
                    this.Hide();

                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_password.Clear();
                    tb_user.BackColor = Color.PaleVioletRed;
                    tb_password.BackColor = Color.PaleVioletRed;
                }
            }
           
        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

    

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
