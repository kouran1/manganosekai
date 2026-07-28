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
    public partial class fmcceditora : Form
    {
        public fmcceditora()
        {
            InitializeComponent();
            lbdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        public string tipo;
        public DateTime data_cadastro;

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            classEditora cEditora = new classEditora();

            if (string.IsNullOrWhiteSpace(tbeditora.Text))
            {
                MessageBox.Show("Preencher o campo mencionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbeditora.BackColor = Color.PaleVioletRed;
            }
            else
            {
                
                cEditora.nome = tbeditora.Text;
                cEditora.descricao = tbdescricao.Text;

                
                int resp = cEditora.cadastrareditora();

                if (resp == 1)
                {
                    MessageBox.Show($"Editora: {cEditora.nome} Cadastrado com sucesso", "Manga no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbeditora.Clear();
                    tbdescricao.Clear();
                    tbeditora.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a editora", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmcceditora_Load(object sender, EventArgs e)
        {
            lbdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            if(tipo == "Atualização")
            {
                toolStripStatusLabel1.Text = "Atualização de editora";
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classEditora cEditora = new classEditora();

            if (string.IsNullOrWhiteSpace(tbeditora.Text))
            {
                MessageBox.Show("Preencher o campo mencionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbeditora.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cEditora.cod_editora = Convert.ToInt32(tbcodigoeditora.Text);
                cEditora.nome = tbeditora.Text;
                cEditora.descricao = tbdescricao.Text;
                if (rbativo.Checked == true)
                {
                    cEditora.status = 1;
                }
                else
                {
                    cEditora.status = 0;
                }



                int resp = cEditora.atualizareditora();

                if (resp == 1)
                {
                    MessageBox.Show($"Editora: {cEditora.nome} atualizado com sucesso", "Manga no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbeditora.Clear();
                    tbdescricao.Clear();
                    tbeditora.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a editora", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}
