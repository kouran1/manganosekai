using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classVenda
    {
        public classVenda()
        {
            cod_venda = 0;
            data_venda = DateTime.Now;
            forma_pagamento = null;
            desconto = 0;
            valor_total = 0;
            cod_funcionario = 0;
            cod_cliente = 0;
            observacao = null;
        }
        public int cod_venda { get; set; }
        public DateTime data_venda { get; set; }
        public string forma_pagamento { get; set; }
        public decimal desconto { get; set; }
        public decimal valor_total { get; set; }
        public int cod_funcionario { get; set; }
        public int cod_cliente { get; set; }
        public string observacao { get; set; }


        //Metodo de cadastro de venda (CLASSCONEXAO.EXECUTAQUERYID) vai executar o comando do DB usando o metodo executescalar (Para retornar a ultima venda gerada no sistema)

        public bool CadastrarVenda()
        {
            string sql = $"INSERT INTO venda VALUES(0,NOW(),'{forma_pagamento}',{desconto.ToString().Replace(",",".")}, {valor_total.ToString().Replace(",",",")},'{observacao}',{cod_cliente},{cod_funcionario});SELECT LAST_INSERT_ID()";
            classConexao cConexao = new classConexao();

            cod_venda = 0;
            cod_venda = cConexao.ExecutaQueryID(sql);

            if(cod_venda != 0)
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
