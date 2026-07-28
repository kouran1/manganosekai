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
    public partial class fmconsproduto : Form
    {
        public fmconsproduto()
        {
            InitializeComponent();
        }

        private void fmconsproduto_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Nome do mangá");
            cbOpcoes.Items.Add("Editora");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Autor");
        }
    }
}
