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
            tbeditora.MaxLength = 40;
            tbdescricao.MaxLength = 120;
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
                    MessageBox.Show($"Editora: {cEditora.nome} cadastrada com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }  

        //MOVIMENTAÇÃO
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
                    MessageBox.Show($"Editora: {cEditora.nome} atualizada com sucesso", "Mangá no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbeditora.Clear();
                    tbdescricao.Clear();
                    tbeditora.Focus();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a editora", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}
