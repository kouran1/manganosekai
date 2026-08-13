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
    public partial class fmcprincipal : Form
    {
        public fmcprincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }


        public int tipo_acesso;
        


        private void fmcprincipal_Load(object sender, EventArgs e)
        {
            if(tipo_acesso == 0)
            {
                menucadcargo.Enabled = false;
                menucadfuncionario.Enabled = false;
                tslTipoAcesso.Text = $"Tipo de Acesso: Comum";
            }
            else
            {
                tslTipoAcesso.Text = $"Tipo de Acesso: Administrador";
            }

            

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menucadcargo_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<fmccargo>().Count()>0)
            {
                MessageBox.Show("Cadastro de cargos já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //CRIAR OBJETO DO FORM QUE SERÁ ABERTTO PARA USAR OS METODOS, DEPOIS INSTANCIAR O OBJETO (DAR VIDA A ESSE OBJETO)
                fmccargo objfmcCargo = new fmccargo();
                objfmcCargo.Show();

            }
           
        }

        private void menucadfuncionario_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<fmcfuncionarios>().Count() > 0)
            {
                MessageBox.Show("Cadastro de funcionários já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                fmcfuncionarios objfmcFuncionarios = new fmcfuncionarios();
                objfmcFuncionarios.Show();
            }
            
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            statuslbdata.Text = DateTime.Now.ToShortDateString();
            statuslbhora.Text = DateTime.Now.ToShortTimeString();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmcautor objautor = new fmcautor();
            objautor.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmccategoria objcategoria = new fmccategoria();
            objcategoria.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmcceditora objeditora = new fmcceditora();
            objeditora.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmccliente objcliente = new fmccliente();
            objcliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmcproduto objproduto = new fmcproduto();
            objproduto.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<fmconsfuncionario>().Count() > 0)
            {
                MessageBox.Show("Consulta de funcionários já está aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                fmconsfuncionario objconsfunc = new fmconsfuncionario();
                objconsfunc.Show();
            }
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmconscargo objconscargo = new fmconscargo();
            objconscargo.Show();
        }

        private void editoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmconseditora objeditora = new fmconseditora();
            objeditora.Show();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmconscategoria objcategoria = new fmconscategoria();
            objcategoria.Show();
        }

        private void autorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmconsautor objautor = new fmconsautor();
            objautor.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmconscliente objcliente = new fmconscliente();
            objcliente.Show();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFuncionario>().Count() > 0)
            {
                MessageBox.Show("Relatório de funcionários já está aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                formRelFuncionario objrelfuncionario = new formRelFuncionario();
                objrelfuncionario.Show();
            }
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmconsproduto formConsProduto = new fmconsproduto();
            formConsProduto.Show();
            
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formRelProduto objrelProduto = new formRelProduto();
            objrelProduto.Show();
        }

        private void menuVendas_Click(object sender, EventArgs e)
        {
            formVenda52 cVenda = new formVenda52();
            cVenda.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRelVendaDetalhada formrelvendad = new formRelVendaDetalhada();
            formrelvendad.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formRelCliente objRelCliente = new formRelCliente();
            objRelCliente.Show();
        }
    }
}
