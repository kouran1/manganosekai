using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace manganosekai
{
    class classCargo
    {
        //Construtor da classe - inicializar todas as propriedades da classe
        //O metodo construtor precisa ter o mesmo nome da classe criada

        public classCargo()
        {
            cod_cargo = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //Propriedades da Classe: Ler e armazenar os dados que serão enviados ao bd ou retornados do bd
        //Mesmo nome e tipo de dado dos campos do bd
        //Atalho Para Criar a Propriedade do C# PROP Tab Tab

        public int cod_cargo { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }

        //Metodos - ações do sisema

        // Criar Metodo: Encapsulamento (private/public) Tipo de retorno
        // (int/string/bool) nome do metodo parametro () - Condições

        public int cadastrarcargo()
        {
            // Variavel para Armazernar o Comando que será executado pelo banco pelo bd
            string comando_sql = "INSERT INTO cargo VALUES(0, '"+ nome + "', '" + observacao + "', 1, NOW() );";

            string comando_teste = $"INSERT INTO cargo VALUES(0,'{nome}','{observacao}', 1, NOW() );";

            // Criar Objeto da Classe conexão para usar metodo executaquery
            classConexao cConexao = new classConexao();

            // Definir o returno do metodo - chamando o metdo da classe
            //conexão que vai executar o comando no BD e retornar o resultado - 0 se deu erro - 1 se deu certo
            return cConexao.ExecutaQuery(comando_teste);
        }
        public int atualizarcargo()
        {

            string sql = $"UPDATE cargo SET nome = '{nome}', observacao = '{observacao}', status= {status} WHERE cod_cargo = {cod_cargo}";
            classConexao cConexao = new classConexao();       

            return cConexao.ExecutaQuery(sql);
        }
        public int deletarcargo()
        {

            string sql = $"DELETE FROM cargo WHERE cod_cargo = {cod_cargo}";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }


        public DataTable buscarcargos()
        {
            string sql = "SELECT cod_cargo, nome FROM cargo WHERE status = 1 ORDER BY nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCargoNomeContem(string nomec)
        {

            string sql = $"SELECT cargo.cod_cargo, cargo.nome, cargo.status, cargo.observacao, cargo.data_cadastro FROM cargo WHERE cargo.nome LIKE '%{nomec}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCargoNomeInicio(string nomei)
        {

            string sql = $"SELECT cargo.cod_cargo, cargo.nome, cargo.status, cargo.observacao, cargo.data_cadastro FROM cargo WHERE cargo.nome LIKE  '{nomei}%'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCargoData(DateTime dtcadastro)
        {

            string sql = $"SELECT cargo.cod_cargo, cargo.nome, cargo.status, cargo.observacao, cargo.data_cadastro FROM cargo WHERE DATE(cargo.data_cadastro) = '{dtcadastro.ToString("yyyy-MM-dd")}'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarCargoStatus(int status)
        {

            string sql = $"SELECT cargo.cod_cargo as Codigo, cargo.nome AS Cargo , cargo.status as Status, cargo.observacao as Observacao, cargo.data_cadastro AS 'Data de Cadastro' FROM cargo WHERE status = {status}";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public bool dadoscargo(int cod)
        {
            string sql = $"SELECT * FROM cargo WHERE cod_cargo = {cod}";
            classConexao cConexao = new classConexao();

            //Montar o data table que recebera todos os dados escolhido pelo usuario
            DataTable dt = cConexao.RetornaDados(sql);

            //Se a consulta der certo
            if (dt.Rows.Count > 0)
            {
       
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
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
