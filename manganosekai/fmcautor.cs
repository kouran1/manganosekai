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
    public partial class fmcautor : Form
    {

        public fmcautor()
        {
            InitializeComponent();

            cboxnacionalidade.Items.Add("Japonês");
            cboxnacionalidade.Items.Add("Americano");
            cboxnacionalidade.Items.Add("Coreano");
            cboxnacionalidade.SelectedIndex = 0;

            lbdata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        }
        public string tipo, nacionalidade;
        public DateTime data_cadastro;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            classAutor cAutor = new classAutor();

            if(string.IsNullOrWhiteSpace(tbnomeautor.Text))
            {
                MessageBox.Show("Preencher o campo", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbnomeautor.ForeColor = Color.PaleVioletRed;
                tbnomeautor.Focus();
            }
            else
            {
                cAutor.nome = tbnomeautor.Text;
                cAutor.descricao = tbdescricao.Text;
                cAutor.nacionalidade = cboxnacionalidade.SelectedItem.ToString();

                //Chamar metodo cadastrar da classe cargo
                int resp = cAutor.cadastrarautor();

                if (resp == 1)
                {
                    MessageBox.Show($"Autor: {cAutor.nome} Cadastrado com sucesso", "Manga no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbnomeautor.Clear();
                    tbdescricao.Clear();
                    tbnomeautor.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void fmcautor_Load(object sender, EventArgs e)
        {
            if (tipo == "Atualização")
            {
                lbtitulo.Text = "Atualização de autor";
                cboxnacionalidade.SelectedItem = nacionalidade;
                gboxsituacao.Enabled = true;
                btcadastrar.Enabled = false;
                lbdata.Text = data_cadastro.ToString("dd/MM/yyyy HH:mm");

            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classAutor cAutor = new classAutor();

            if (string.IsNullOrWhiteSpace(tbnomeautor.Text))
            {
                MessageBox.Show("Preencher o campo", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbnomeautor.ForeColor = Color.PaleVioletRed;
                tbnomeautor.Focus();
            }
            else
            {
                cAutor.nome = tbnomeautor.Text;
                cAutor.descricao = tbdescricao.Text;
                cAutor.nacionalidade = cboxnacionalidade.SelectedItem.ToString();
                cAutor.cod_autor = Convert.ToInt32(tbcodigoautor.Text);
                if(rbativo.Checked == true)
                {
                    cAutor.status = 1;
                }
                else
                {
                    cAutor.status = 0;
                }
                int resp = cAutor.atualizarautor();

                if (resp == 1)
                {
                    MessageBox.Show($"Autor: {cAutor.nome} atualizado com sucesso", "Manga no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbnomeautor.Clear();
                    tbdescricao.Clear();
                    tbnomeautor.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir o(a) {tbnomeautor.Text}? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classAutor cAutor = new classAutor();
                cAutor.cod_autor = Convert.ToInt32(tbcodigoautor.Text);

                int resp = cAutor.deletarautor();
                if (resp == 1)
                {
                    MessageBox.Show("Autor(a) excluida com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Descricao_Enter(object sender, EventArgs e)
        {

        }

        private void tbnomeautor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
