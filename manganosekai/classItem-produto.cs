using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manganosekai
{
    class item_produto
    {
        public item_produto()
        {
            cod_produto = 0;
            qntd_item = 0;
            valor_item = 0;
            valor_total_item = 0;
            cod_venda = 0;
        }

        public int cod_produto { get; set; }
        public int qntd_item { get; set; }
        public decimal valor_item { get; set; }
        public decimal valor_total_item { get; set; }
        public int cod_venda { get; set; }

        //Metodo 

        public bool CadastrarItemProduto()
        {
            string sql = $"INSERT INTO item_produto VALUES(0,{cod_produto}, {qntd_item}, {valor_item.ToString().Replace(",",".")},{valor_total_item.ToString().Replace(",", ".")}, {cod_venda})";

            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(sql);

            if(resp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
