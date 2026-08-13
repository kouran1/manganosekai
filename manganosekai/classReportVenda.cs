using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classReportVenda
    {

        //COnstrutor
        public classReportVenda()
        {
            cod_venda = 0;
            data_venda = DateTime.Now;
            forma_pagamento = null;
            desconto = 0;
            valor_total = 0;
            cod_funcionario = 0;
            cod_cliente = 0;
            observacao = null;

            //Item produto
            cod_produto = 0;
            qntd_item = 0;
            valor_item = 0;
            valor_total_item = 0;
            cod_venda = 0;

            //Editora
            cod_editora = 0;

        }
        public int cod_item_produto { get; set; }
        public int cod_venda { get; set; }
        public DateTime data_venda { get; set; }
        public string forma_pagamento { get; set; }
        public decimal desconto { get; set; }
        public decimal valor_total { get; set; }
        public int cod_funcionario { get; set; }
        public int cod_cliente { get; set; }
        public string observacao { get; set; }

        //Item produto
        public int cod_produto { get; set; }
        public int qntd_item { get; set; }
        public decimal valor_item { get; set; }
        public decimal valor_total_item { get; set; }

        public int cod_editora { get; set; }

        public DataTable ReportVendaDetalhadaData(DateTime dataini, DateTime datafim )
        {
            string sql = $"SELECT editora.nome 'cod_editora', produto.titulo 'cod_produto', item_produto.qntd_item, item_produto.valor_item, item_produto.valor_total_item, venda.cod_venda, venda.data_venda, venda.forma_pagamento, venda.desconto, venda.valor_total, IFNULL(cliente.nome, 'Não informado') 'cod_cliente', IFNULL(funcionario.nome, 'Venda Web') 'cod_funcionario' FROM editora JOIN produto ON editora.cod_editora = produto.cod_editora JOIN item_produto ON item_produto.cod_produto = produto.cod_produto JOIN venda ON venda.cod_venda = item_produto.cod_venda LEFT JOIN cliente ON cliente.cod_cliente = venda.cod_cliente LEFT JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario WHERE CAST(venda.data_venda AS DATE) BETWEEN '{dataini.ToString("yyyy-MM-dd")}' AND '{datafim.ToString("yyyy-MM-dd")}' ORDER BY venda.data_venda;";


            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);


        }
        public DataTable ReportPeriodoCliente(DateTime dataini, DateTime datafim, int cliente)
        {
            string sql = $"SELECT editora.nome 'cod_editora', produto.titulo 'cod_produto', item_produto.qntd_item, item_produto.valor_item, item_produto.valor_total_item, venda.cod_venda, venda.data_venda, venda.forma_pagamento, venda.desconto, venda.valor_total, IFNULL(cliente.nome, 'Não informado') 'cod_cliente', IFNULL(funcionario.nome, 'Venda Web') 'cod_funcionario' FROM editora JOIN produto ON editora.cod_editora = produto.cod_editora JOIN item_produto ON item_produto.cod_produto = produto.cod_produto JOIN venda ON venda.cod_venda = item_produto.cod_venda LEFT JOIN cliente ON cliente.cod_cliente = venda.cod_cliente LEFT JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario WHERE CAST(venda.data_venda AS DATE) BETWEEN '{dataini.ToString("yyyy-MM-dd")}' AND '{datafim.ToString("yyyy-MM-dd")}' AND cliente.cod_cliente = {cliente} ORDER BY venda.data_venda;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);


        }
        public DataTable ReportPeriodoFuncionario(DateTime dataini, DateTime datafim, int func)
        {
            string sql = $"SELECT editora.nome 'cod_editora', produto.titulo 'cod_produto', item_produto.qntd_item, item_produto.valor_item, item_produto.valor_total_item, venda.cod_venda, venda.data_venda, venda.forma_pagamento, venda.desconto, venda.valor_total, IFNULL(cliente.nome, 'Não informado') 'cod_cliente', IFNULL(funcionario.nome, 'Venda Web') 'cod_funcionario' FROM editora JOIN produto ON editora.cod_editora = produto.cod_editora JOIN item_produto ON item_produto.cod_produto = produto.cod_produto JOIN venda ON venda.cod_venda = item_produto.cod_venda LEFT JOIN cliente ON cliente.cod_cliente = venda.cod_cliente LEFT JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario WHERE CAST(venda.data_venda AS DATE) BETWEEN '{dataini.ToString("yyyy-MM-dd")}' AND '{datafim.ToString("yyyy-MM-dd")}' AND funcionario.cod_funcionario = {func} ORDER BY venda.data_venda;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);


        }
        public DataTable ReportVendaCliente( int cliente)
        {
            string sql = $"SELECT editora.nome 'cod_editora', produto.titulo 'cod_produto', item_produto.qntd_item, item_produto.valor_item, item_produto.valor_total_item, venda.cod_venda, venda.data_venda, venda.forma_pagamento, venda.desconto, venda.valor_total, IFNULL(cliente.nome, 'Não informado') 'cod_cliente', IFNULL(funcionario.nome, 'Venda Web') 'cod_funcionario' FROM editora JOIN produto ON editora.cod_editora = produto.cod_editora JOIN item_produto ON item_produto.cod_produto = produto.cod_produto JOIN venda ON venda.cod_venda = item_produto.cod_venda LEFT JOIN cliente ON cliente.cod_cliente = venda.cod_cliente LEFT JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario WHERE cliente.cod_cliente = {cliente} ORDER BY venda.data_venda;";


            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);


        }
        public DataTable ReportVendaFuncionario(int func)
        {
            string sql = $"SELECT editora.nome 'cod_editora', produto.titulo 'cod_produto', item_produto.qntd_item, item_produto.valor_item, item_produto.valor_total_item, venda.cod_venda, venda.data_venda, venda.forma_pagamento, venda.desconto, venda.valor_total, IFNULL(cliente.nome, 'Não informado') 'cod_cliente', IFNULL(funcionario.nome, 'Venda Web') 'cod_funcionario' FROM editora JOIN produto ON editora.cod_editora = produto.cod_editora JOIN item_produto ON item_produto.cod_produto = produto.cod_produto JOIN venda ON venda.cod_venda = item_produto.cod_venda LEFT JOIN cliente ON cliente.cod_cliente = venda.cod_cliente LEFT JOIN funcionario ON funcionario.cod_funcionario = venda.cod_funcionario WHERE funcionario.cod_funcionario = {func} ORDER BY venda.data_venda;";


            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);


        }


    }

}
