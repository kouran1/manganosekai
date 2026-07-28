using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classEditora
    {
        public classEditora()
        {
            int cod_editora = 0;
            string nome = null;
            string descricao = null;
            int status = 0;
            data_cadastro = DateTime.Now;
        }
        
        public int cod_editora { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }


        public int cadastrareditora()
        {
            string sql_editora = $"INSERT INTO editora VALUES(0,'{nome}','{descricao}', 1,NOW())";

            classConexao objconexao = new classConexao();

            return objconexao.ExecutaQuery(sql_editora);
        }
        public DataTable buscareditora()
        {
            string sql = "SELECT cod_editora, nome FROM editora WHERE status = 1 ORDER BY nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public int atualizareditora()
        {

            string sql = $"UPDATE editora SET nome = '{nome}', descricao = '{descricao}', status= {status} WHERE cod_editora = {cod_editora}";
            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }
        public int deleteeditora()
        {

            string sql = $"DELETE FROM editora WHERE cod_editora = {cod_editora}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }
        public DataTable buscarEditoras()
        {
            string sql = "SELECT cod_editora, nome, descricao, data_cadastro, status FROM editora WHERE status = 1 ORDER BY nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarEditoraNomeContem(string nomec)
        {

            string sql = $"SELECT cod_editora AS Codigo, nome AS Nome, status AS Status, descricao AS 'Descrição', data_cadastro AS 'Data de Cadastro' FROM editora WHERE nome LIKE '%{nomec}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarEditoraNomeInicio(string nomei)
        {

            string sql = $"SELECT cod_editora AS Codigo, nome AS Nome, status AS Status, descricao AS 'Descrição', data_cadastro AS 'Data de Cadastro' FROM editora WHERE  nome LIKE  '{nomei}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarEditoraData(DateTime dtcadastro)
        {

            string sql = $"SELECT cod_editora AS Codigo, nome AS Nome, status AS Status, descricao AS 'Descrição', data_cadastro AS 'Data de Cadastro' FROM editora WHERE data_cadastro = '{dtcadastro.ToString("yyyy-MM-dd")}'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarEditoraStatus(int status)
        {

            string sql = $"SELECT cod_editora AS Codigo, nome AS Nome, status AS Status, descricao AS 'Descrição', data_cadastro AS 'Data de Cadastro' FROM editora WHERE  status = {status}";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public bool dadoseditora(int cod)
        {
            string sql = $"SELECT * FROM editora WHERE cod_editora = {cod}";
            classConexao cConexao = new classConexao();

            //Montar o data table que recebera todos os dados escolhido pelo usuario
            DataTable dt = cConexao.RetornaDados(sql);

            //Se a consulta der certo
            if (dt.Rows.Count > 0)
            {

                cod_editora = Convert.ToInt32(dt.Rows[0]["cod_editora"]);
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
