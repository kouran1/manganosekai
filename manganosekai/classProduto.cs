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
            nome_autor = null;
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
        public string nome_autor { get; set; }

        public int cadastrarproduto()
        {
            string sql_produto = $"INSERT INTO produto VALUES(0,'{titulo}','{volume}','{foto}','{data_lancamento.ToString("yyyy-MM-dd")}','{resumo}','{descricao}','{qntd_estoque}','{preco_custo.ToString().Replace(",", ".")}','{lucro.ToString().Replace(",", ".")}','{preco_venda.ToString().Replace(",", ".")}','{ifpromocao}','{percentualpromocao.ToString().Replace(",", ".")}','{precopromocao.ToString().Replace(",", ".")}',1,NOW(),'{cod_categoria}','{cod_editora}', '{imagem1}', '{imagem2}', '{imagem3}', '{imagem4}')";
            classConexao objconexao = new classConexao();
            return objconexao.ExecutaQuery(sql_produto);

            
        }
        public int atualizarProduto()
        {
            string sql = $"UPDATE produto SET titulo ='{titulo}', volume = {volume}, data_lancamento = '{data_lancamento.ToString("yyyy-MM-dd")}', resumo = '{resumo}', descricao = '{descricao}', qntd_estoque = '{qntd_estoque}', preco_custo = '{preco_custo.ToString().Replace(",", ".")}', lucro = '{lucro.ToString().Replace(",", ".")}', preco_venda = '{preco_venda.ToString().Replace(",", ".")}', ifpromocao = {ifpromocao}, percentualpromocao = '{percentualpromocao.ToString().Replace(",", ".")}', precopromocao = '{precopromocao.ToString().Replace(",", ".")}', status = {status}, data_cadastro = '{data_cadastro.ToString("yyyy-MM-dd HH:mm:ss")}', cod_categoria = {cod_categoria}, cod_editora = {cod_editora} WHERE cod_produto = {cod_produto}";

            classConexao objConexao = new classConexao();
            return objConexao.ExecutaQuery(sql);
        }

        public int deletarproduto()
        {
            string sql_autor = $"DELETE FROM autor_produto WHERE cod_produto = {cod_produto}";
            string sql_produto = $"DELETE FROM produto WHERE cod_produto = {cod_produto}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaTransacao(sql_autor, sql_produto);
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

        public int removerautorproduto()
        {
            string sql = $"DELETE FROM autor_produto WHERE cod_produto = {cod_produto}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        public DataTable buscarautorproduto(int codigo)
        {
            string sql = $"SELECT cod_autor FROM autor_produto WHERE cod_produto = {codigo}";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable buscarEditoraRelatorio()
        {
            string sql = "SELECT DISTINCT editora.cod_editora, editora.nome FROM editora JOIN produto ON produto.cod_editora = editora.cod_editora WHERE editora.status = 1 AND produto.status = 1 ORDER BY editora.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable buscarCategoriaRelatorio()
        {
            string sql = "SELECT DISTINCT categoria.cod_categoria, categoria.nome FROM categoria JOIN produto ON produto.cod_categoria = categoria.cod_categoria WHERE categoria.status = 1 AND produto.status = 1 ORDER BY categoria.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable buscarAutorRelatorio()
        {
            string sql = "SELECT DISTINCT autor.cod_autor AS Código, autor.nome AS Autor FROM autor JOIN autor_produto ON autor_produto.cod_autor = autor.cod_autor JOIN produto ON produto.cod_produto = autor_produto.cod_produto WHERE autor.status = 1 AND produto.status = 1 ORDER BY autor.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }


        public DataTable ReportProdutoEditora(int editora)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, editora.nome, produto.cod_produto, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND editora.cod_editora = {editora} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoCategoria(int categoria)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento,produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND categoria.cod_categoria = {categoria} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoAutor(int autor)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND autor.cod_autor = {autor} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarProduto(int cod)
        {
            string sql = $"SELECT produto.cod_produto AS 'Código', produto.titulo AS Titulo, produto.volume AS Volume, editora.nome AS Editora, categoria.nome AS Categoria, GROUP_CONCAT( autor.nome SEPARATOR '/' ) AS Autor, produto.qntd_estoque AS 'qntd_estoque', produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND  produto.cod_produto = {cod} GROUP BY produto.cod_produto";
            classConexao cConexao = new classConexao();

            
           
            return cConexao.RetornaDados(sql);

        }

        //Metodos de Consultas

        public DataTable consultarProdutoTitulo(string titulo)
        {
            string sql = $"SELECT produto.cod_produto AS Código, produto.titulo AS Titulo, produto.volume AS Volume, categoria.nome AS Categoria, GROUP_CONCAT(autor.nome SEPARATOR '/') AS Autor, editora.nome AS Editora, produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN editora ON produto.cod_editora = editora.cod_editora JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.titulo LIKE '%{titulo}%' GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }
        public DataTable consultarProdutoEditora(int codigo)
        {
            string sql = $"SELECT produto.cod_produto AS Código, produto.titulo AS Titulo, produto.volume AS Volume, categoria.nome AS Categoria, GROUP_CONCAT(autor.nome SEPARATOR '/') AS Autor, editora.nome AS Editora, produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN editora ON produto.cod_editora = editora.cod_editora JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND editora.cod_editora = {codigo} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }
        public DataTable consultaProdutoCategoria(int codigo)
        {
            string sql = $"SELECT produto.cod_produto AS Código, produto.titulo AS Titulo, produto.volume AS Volume, categoria.nome AS Categoria, GROUP_CONCAT(autor.nome SEPARATOR '/') AS Autor, editora.nome AS Editora, produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN editora ON produto.cod_editora = editora.cod_editora JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND categoria.cod_categoria = {codigo} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }
        public DataTable consultaProdutoAutor(int codigo)
        {
            string sql = $"SELECT produto.cod_produto AS Código, produto.titulo AS Titulo, produto.volume AS Volume, categoria.nome AS Categoria, GROUP_CONCAT(autor.nome SEPARATOR '/') AS Autor, editora.nome AS Editora, produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN editora ON produto.cod_editora = editora.cod_editora JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND autor.cod_autor = {codigo} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultaProdutoStatus(int status)
        {
            string sql = $"SELECT produto.cod_produto AS Código, produto.titulo AS Titulo, produto.volume AS Volume, categoria.nome AS Categoria, GROUP_CONCAT(autor.nome SEPARATOR '/') AS Autor, editora.nome AS Editora, produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN editora ON produto.cod_editora = editora.cod_editora JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = {status} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }
        public DataTable consultarProdutoAno(int ano)
        {
            string sql = $"SELECT produto.cod_produto AS Código, produto.titulo AS Titulo, produto.volume AS Volume, categoria.nome AS Categoria, GROUP_CONCAT(autor.nome SEPARATOR '/') AS Autor, editora.nome AS Editora, produto.data_cadastro AS 'Data de Cadastro' FROM produto JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN editora ON produto.cod_editora = editora.cod_editora JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND YEAR(produto.data_lancamento) = {ano} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }
        public DataTable consultarProdutoVenda(string nome)
        {
            string sql = $"SELECT produto.cod_produto AS 'Código', produto.titulo AS Titulo, produto.volume AS Volume, editora.nome AS Editora, categoria.nome AS Categoria, GROUP_CONCAT( autor.nome SEPARATOR '/' ) AS Autor, produto.qntd_estoque AS 'Quantidade em estoque' FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.titulo LIKE '%{nome}%' GROUP BY produto.cod_produto";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);

        }
        public DataTable ReportProdutoPrecoVenda(decimal precoi, decimal precof)
        {
            string precoInicial = precoi.ToString().Replace(",", ".");
            string precoFinal = precof.ToString().Replace(",", ".");
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.preco_venda BETWEEN {precoInicial} AND {precoFinal} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoEstoque(int estoquei, int estoquef)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.qntd_estoque BETWEEN {estoquei}  AND {estoquef} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoDataLancamento(DateTime datai, DateTime dataf)
        {
            string sql = $"SELECT produto.titulo, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, produto.qntd_estoque, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = 1 AND produto.data_lancamento BETWEEN DATE('{datai.ToString("yyyy-MM-dd")}') AND DATE('{dataf.ToString("yyyy-MM-dd")}') GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportProdutoStatus(int status)
        {
            string sql = $"SELECT produto.titulo, produto.qntd_estoque, produto.volume, produto.data_lancamento, produto.cod_produto, editora.nome, categoria.nome, produto.preco_venda, GROUP_CONCAT(autor.nome SEPARATOR '/') AS nome_autor FROM produto JOIN editora ON produto.cod_editora = editora.cod_editora JOIN categoria ON produto.cod_categoria = categoria.cod_categoria JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.status = {status} GROUP BY produto.cod_produto ORDER BY produto.cod_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public bool atualizaEstoque(int qntd, int cod)
        {
            string query = $"UPDATE produto SET qntd_estoque = {qntd} WHERE cod_produto = {cod}";
            classConexao cConexao = new classConexao();
            int resp = cConexao.ExecutaQuery(query);

            if(resp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public bool dadosProduto(int cod)
        {
            string sql = $"SELECT produto.*, autor_produto.cod_autor, autor.nome as nome_autor FROM produto LEFT JOIN autor_produto ON produto.cod_produto = autor_produto.cod_produto LEFT JOIN autor ON autor_produto.cod_autor = autor.cod_autor WHERE produto.cod_produto = {cod};";
            classConexao cConexao = new classConexao();

            //Montar o data table que recebera todos os dados escolhido pelo usuario
            DataTable dt = cConexao.RetornaDados(sql);

            //Se a consulta der certo
            if (dt.Rows.Count > 0)
            {

                cod_produto = Convert.ToInt32(dt.Rows[0]["cod_produto"]);
                titulo = Convert.ToString(dt.Rows[0]["titulo"]);
                volume = Convert.ToInt32(dt.Rows[0]["volume"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                data_lancamento = Convert.ToDateTime(dt.Rows[0]["data_lancamento"]);
                resumo = Convert.ToString(dt.Rows[0]["resumo"]);
                descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                qntd_estoque = Convert.ToInt32(dt.Rows[0]["qntd_estoque"]);
                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);
                lucro = Convert.ToDecimal(dt.Rows[0]["lucro"]);
                preco_venda = Convert.ToDecimal(dt.Rows[0]["preco_venda"]);
                ifpromocao = Convert.ToInt32(dt.Rows[0]["ifpromocao"]);
                percentualpromocao = Convert.ToDecimal(dt.Rows[0]["percentualpromocao"]);
                precopromocao = Convert.ToDecimal(dt.Rows[0]["precopromocao"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                cod_categoria = Convert.ToInt32(dt.Rows[0]["cod_categoria"]);
                cod_editora = Convert.ToInt32(dt.Rows[0]["cod_editora"]);
                cod_autor = Convert.ToInt32(dt.Rows[0]["cod_autor"]);
                nome_autor = Convert.ToString(dt.Rows[0]["nome_autor"]);
                imagem1 = Convert.ToString(dt.Rows[0]["imagem1"]);
                imagem2 = Convert.ToString(dt.Rows[0]["imagem2"]);
                imagem3 = Convert.ToString(dt.Rows[0]["imagem3"]);
                imagem1 = Convert.ToString(dt.Rows[0]["imagem4"]);

                return true;
            }
            else
            {
                return false;
            }
        }
        public string BuscarNomeProd(int cod)
        {
            string sql = $"SELECT titulo FROM produto WHERE cod_produto = {cod}";
            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);
            if(dt.Rows.Count > 0)
            {
                titulo = dt.Rows[0]["titulo"].ToString();
            }
            return titulo;
        }



    }
}
