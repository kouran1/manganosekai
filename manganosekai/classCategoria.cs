using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classCategoria
    {
        public classCategoria()
        {
            cod_categoria = 0;
            nome = null;
            descricao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }
        public int cod_categoria { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }

        public int cadastrarcategoria()
        {
            string sql = $"INSERT INTO categoria VALUES(0,'{nome}','{descricao}', 1, NOW())";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);

        }
        public int atualizarcategoria()
        {
            string sql = $"UPDATE categoria SET nome ='{nome}', descricao = '{descricao}', status = {status} WHERE cod_categoria = {cod_categoria}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }
        public int deletecategoria()
        {
            string sql = $"DELETE FROM categoria WHERE cod_categoria= {cod_categoria}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        public DataTable buscarcategoria()
        {
            string sql = "SELECT cod_categoria, nome  FROM categoria WHERE status = 1 ORDER BY nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public DataTable consultarCategoriaNomeContem(string nomec)
        {

            string sql = $"SELECT categoria.cod_categoria AS Codigo, categoria.nome AS categoria, categoria.status AS Status, categoria.descricao as Descricao, categoria.data_cadastro AS 'Data Cadastro' FROM categoria  WHERE Nome LIKE '%{nomec}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCategoriaNomeInicio(string nomei)
        {

            string sql = $"SELECT categoria.cod_categoria AS Codigo, categoria.nome AS categoria, categoria.status AS Status, categoria.descricao as Descricao, categoria.data_cadastro AS 'Data Cadastro' FROM categoria  WHERE Nome LIKE  '{nomei}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCategoriaData(DateTime dtcadastro)
        {

            string sql = $"SELECT categoria.cod_categoria AS Codigo, categoria.nome AS categoria, categoria.status AS Status, categoria.descricao as Descricao, categoria.data_cadastro AS 'Data Cadastro' FROM categoria  WHERE DATE(categoria.data_cadastro) = '{dtcadastro.ToString("yyyy-MM-dd")}'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCategoriaStatus(int status)
        {

            string sql = $"SELECT categoria.cod_categoria AS Codigo, categoria.nome AS categoria, categoria.status AS Status, categoria.descricao as Descricao, categoria.data_cadastro AS 'Data Cadastro' FROM categoria  WHERE status = {status}";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        public bool dadoscategoria(int cod)
        {
            string sql = $"SELECT * FROM categoria WHERE cod_categoria = {cod}";
            classConexao cConexao = new classConexao();

            //Montar o data table que recebera todos os dados escolhido pelo usuario
            DataTable dt = cConexao.RetornaDados(sql);

            //Se a consulta der certo
            if (dt.Rows.Count > 0)
            {
       
                cod_categoria = Convert.ToInt32(dt.Rows[0]["cod_categoria"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
