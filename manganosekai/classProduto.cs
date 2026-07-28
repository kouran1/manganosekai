using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classProduto
    {
        public classProduto()
        {
            cod_produto = 0;
            titulo = null;
            volume = 0;
            foto = null;
            data_lancamento = DateTime.Now;
            resumo = null;
            descricao = null;
            qntd_estoque = 0;
            preco_custo = 0;
            lucro = 0;
            preco_venda = 0;
            ifpromocao = 0;
            percentualpromocao = 0;
            precopromocao = 0;
            status = 0;
            data_cadastro = DateTime.Now;
            cod_categoria = 0;
            cod_editora = 0;
            cod_autor = 0;
            imagem1 = null;
            imagem2 = null;
            imagem3 = null;
            imagem4 = null;
        }

        public int cod_produto { get; set; }
        public string titulo { get; set; }
        public int volume { get; set; }
        public string foto { get; set; }
        public DateTime data_lancamento { get; set; }
        public DateTime data_cadastro { get; set; }
        public string resumo { get; set; }
        public string descricao { get; set; }
        public int qntd_estoque { get; set; }
        public decimal preco_custo { get; set; }
        public decimal lucro { get; set; }
        public decimal preco_venda { get; set; }
        public int ifpromocao { get; set; }
        public decimal percentualpromocao { get; set; }
        public decimal precopromocao { get; set; }
        public int status { get; set; }
        public int cod_categoria { get; set; }
        public int cod_editora { get; set; }
        public int cod_autor { get; set; }
        public string imagem1 { get; set; }
        public string imagem2 { get; set; }
        public string imagem3 { get; set; }
        public string imagem4 { get; set; }

        public int cadastrarproduto()
        {
            string sql_produto = $"INSERT INTO produto VALUES(0,'{titulo}','{volume}','{foto}','{data_lancamento.ToString("yyyy-MM-dd")}','{resumo}','{descricao}','{qntd_estoque}','{preco_custo.ToString().Replace(",", ".")}','{lucro.ToString().Replace(",", ".")}','{preco_venda.ToString().Replace(",", ".")}','{ifpromocao}','{percentualpromocao.ToString().Replace(",", ".")}','{precopromocao.ToString().Replace(",", ".")}',1,NOW(),'{cod_categoria}','{cod_editora}', '{imagem1}', '{imagem2}', '{imagem3}', '{imagem4}')";
            classConexao objconexao = new classConexao();
            return objconexao.ExecutaQuery(sql_produto);

            
        }

        public int ultimoid()
        {
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQueryID("SELECT LAST_INSERT_ID()");
        }

        public int cadastrarAutorProduto()
        {
            string sql_autorproduto = $"INSERT INTO autor_produto VALUES ({cod_produto},{cod_autor})";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql_autorproduto);
        }


        public DataTable ReportProdutoEditora(int editora)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, editora.nome, produto.cod_produto, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND editora.cod_editora = {editora} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoCategoria(int categoria)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento,produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND categoria.cod_categoria = {categoria} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoAutor(int autor)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND autor.cod_autor = {autor} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoPrecoVenda(decimal precoi, decimal precof)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.preco_venda BETWEEN {precoi} AND {precof} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoEstoque(int estoquei, int estoquef)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.qntd_estoque BETWEEN {estoquei}  AND {estoquef} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoDataLancamento(DateTime datai, DateTime dataf)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.data_lancamento BETWEEN DATE('{datai.ToString("yyyy-MM-dd")}') AND DATE('{dataf.ToString("yyyy-MM-dd")}') GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoStatus(int status)
        {
            string sql = $"SELECT produto.titulo, produto.qntd_estoque, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, GROUP_CONCAT(autor.nome SEPARATOR '/') AS cod_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = {status} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }



    }
}
