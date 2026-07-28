using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classAutor
    {
        //Classe construtor
        public classAutor()
        {
            cod_autor = 0;
            nome = null;
            nacionalidade = null;
            descricao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //Propriedade
        public int cod_autor { get; set; }
        public string nome { get; set; }
        public string nacionalidade { get; set; }
        public string descricao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set;}

        public int cadastrarautor()
        {
            string comando_sql = $"INSERT INTO autor VALUES (0, '{nome}','{nacionalidade}', '{descricao}', 1, NOW())";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(comando_sql);

        }
        public int atualizarautor()
        {
            string sql = $"UPDATE autor SET nome='{nome}', nacionalidade =  '{nacionalidade}', descricao ='{descricao}', status = {status} WHERE cod_autor = {cod_autor}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }
        public int deletarautor()
        {

            string sql = $"DELETE FROM autor WHERE cod_autor = {cod_autor}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        //Consultas
        public DataTable buscarautor()
        {
            string sql = "SELECT cod_autor, nome FROM autor WHERE status = 1 ORDER BY nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarAutorNomeContem(string nomec)
        {

            string sql = $"SELECT cod_autor, nome, nacionalidade, descricao, status, data_cadastro FROM autor WHERE nome LIKE '%{nomec}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarAutorNomeInicio(string nomei)
        {

            string sql = $"SELECT cod_autor, nome, nacionalidade, descricao, status, data_cadastro FROM autor WHERE nome LIKE '{nomei}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarAutorData(DateTime dtcadastro)
        {

            string sql = $"SELECT cod_autor, nome, nacionalidade, descricao, status, data_cadastro FROM autor WHERE data_cadastro = '{dtcadastro.ToString("yyyy-MM-dd")}'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarAutorStatus(int status)
        {

            string sql = $"SELECT cod_autor, nome, nacionalidade, descricao, status, data_cadastro FROM autor WHERE status = {status}";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public bool dadosautor(int cod)
        {
            string sql = $"SELECT * FROM autor WHERE cod_autor = {cod}";
            classConexao cConexao = new classConexao();

            //Montar o data table que recebera todos os dados escolhido pelo usuario
            DataTable dt = cConexao.RetornaDados(sql);

            //Se a consulta der certo
            if (dt.Rows.Count > 0)
            {

                cod_autor = Convert.ToInt32(dt.Rows[0]["cod_autor"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                nacionalidade = Convert.ToString(dt.Rows[0]["nacionalidade"]);
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
