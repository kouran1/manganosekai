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
    public partial class fmccategoria : Form
    {
        public fmccategoria()
        {
            InitializeComponent();
            lbdata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        public string tipo;

        public DateTime data_cadastro;


        private void btcadastrar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();

            if(string.IsNullOrWhiteSpace(tbcategoria.Text))
            {
                MessageBox.Show("Preencher o campo selecionado", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcategoria.ForeColor = Color.PaleVioletRed;
                tbcategoria.Focus();
            }
            else
            {
                cCategoria.nome = tbcategoria.Text;
                cCategoria.descricao = tboxdescricao.Text;

                int resp = cCategoria.cadastrarcategoria();

                if(resp == 1)
                {
                    MessageBox.Show($"Categoria: {cCategoria.nome} Cadastrado com sucesso", "Manga no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcategoria.Clear();
                    tboxdescricao.Clear();
                    tbcategoria.Focus();

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
         
            }

        }
       

        private void fmccategoria_Load(object sender, EventArgs e)
        {

            lbdata.Text = DateTime.Now.ToString();
            if(tipo == "Atualização")
            {
                label1.Text = "Atualização de categoria";

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

        private void lbdata_Click(object sender, EventArgs e)
        {

        }

        private void tbcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();

            if (string.IsNullOrWhiteSpace(tbcategoria.Text))
            {
                MessageBox.Show("Preencher o campo selecionado", "Mangá No Sekai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbcategoria.ForeColor = Color.PaleVioletRed;
                tbcategoria.Focus();
            }
            else
            {
                cCategoria.nome = tbcategoria.Text;
                cCategoria.descricao = tboxdescricao.Text;
                cCategoria.cod_categoria = Convert.ToInt32(tbcodcategoria.Text);
                if(rbativo.Checked == true)
                {
                    cCategoria.status = 1;
                }
                else
                {
                    cCategoria.status = 0;
                }

                int resp = cCategoria.atualizarcategoria();

                if (resp == 1)
                {
                    MessageBox.Show($"Categoria: {cCategoria.nome} atualizada com sucesso", "Manga no Sekai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcategoria.Clear();
                    tboxdescricao.Clear();
                    tbcategoria.Focus();

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir {tbcategoria.Text}? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCategoria cCategoria = new classCategoria();
                cCategoria.cod_categoria = Convert.ToInt32(tbcodcategoria.Text);

                int resp = cCategoria.deletecategoria();
                if (resp == 1)
                {
                    MessageBox.Show("Categoria excluida com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
