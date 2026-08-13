using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classCliente
    {
        public classCliente()
        {
            int cod_cliente = 0;
            string nome = null;
            string nome_social = null;
            data_nascimento = DateTime.Now;
            string sexo = null;
            string cpf = null;
            string rg = null;
            string endereco = null;
            int numero = 0;
            string complemento = null;
            string bairro = null;
            string cidade = null;
            string uf = null;
            string cep = null;
            string telefone_residencial = null;
            string telefone_celular = null;
            string email = null;
            int status = 0;
            data_cadastro = DateTime.Now;
        }

        public int cod_cliente { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string telefone_residencial { get; set; }
        public string telefone_celular { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }



        public int cadastrarcliente()
        {
            
            string sql_cliente = $"INSERT INTO cliente VALUES(0,'{nome}','{nome_social}','{data_nascimento.ToString("yyyy/MM/dd")}','{sexo}','{cpf}','{rg}','{endereco}','{numero}','{complemento}','{bairro}','{cidade}','{uf}','{cep}','{telefone_residencial}','{telefone_celular}','{email}', 1, NOW())";

            classConexao objconexao = new classConexao();

            return objconexao.ExecutaQuery(sql_cliente);
        }
        public int atualizarcliente()
        {
            string sql = $"UPDATE cliente SET nome = '{nome}', nome_social = '{nome_social}',data_nascimento = '{data_nascimento.ToString("yyyy/MM/dd")}', sexo = '{sexo}',cpf = '{cpf}', rg = '{rg}', endereco = '{endereco}', numero = {numero}, complemento = '{complemento}',bairro = '{bairro}',cidade = '{cidade}', uf = '{uf}', cep = '{cep}',telefone_residencial = '{telefone_residencial}',telefone_celular = '{telefone_celular}', email = '{email}', status = {status} WHERE cod_cliente = {cod_cliente}";
            classConexao objconexao = new classConexao();

            return objconexao.ExecutaQuery(sql);
        }
        public int deletarcliente()
        {
            string sql = $"DELETE FROM cliente WHERE cod_cliente = {cod_cliente}";
            classConexao objconexao = new classConexao();

            return objconexao.ExecutaQuery(sql);

        }

        public DataTable buscarCidade()
        {
            string sql = $"SELECT DISTINCT cidade FROM cliente GROUP BY cidade";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        //Consultas
        public DataTable consultarClienteNomeIni(string nomei)
        {
            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE nome LIKE '{nomei}%'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));

        }
        public DataTable consultarClienteNomeContem(string nomec)
        {
            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE nome LIKE '%{nomec}%'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));
        }
        public DataTable consultarClienteSexo(string sexo)
        {
            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE sexo = '{sexo}'";

            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));
        }
        public DataTable consultarClienteCidade(string cidade)
        {
            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE cidade = '{cidade}'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));
        }
        public DataTable consultarClienteEmail(string email)
        {

            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE email = '{email}'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));

        }
        public DataTable consultarClienteTelCelular(string telefonec)
        {

            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE telefone_celular = '{telefonec}'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));

        }
        public DataTable consultarClienteData(DateTime datac)
        {

            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE DATE (data_cadastro) = '{datac.ToString("yyyy-MM-dd")}'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));

        }
        public DataTable consultarClienteStatus(int status)
        {

            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE status = {status}";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));

        }
        public DataTable ReportClienteStatus(int status)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = {status}";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClienteNomeC(string nomec)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND nome LIKE '%{nomec}%'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClienteIni(string nomeini)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND nome LIKE '{nomeini}%'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClientSexo(string sexo)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND sexo = '{sexo}'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClienteCidade(string cidade)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND cidade = '{cidade}'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClienteEmail(string email)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND email = '{email}'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClienteDataCadastro(DateTime dataCadastro)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND DATE(data_cadastro) = '{dataCadastro.ToString("yyyy-MM-dd")}'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClienteTelCel(string celular)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND telefone_celular = '{celular}'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }
        public DataTable ReportClientCPF(string cpf)
        {
            string sql = $"SELECT cod_cliente, nome, data_nascimento, sexo, cpf, cidade, telefone_celular, email FROM cliente WHERE status = 1 AND cpf = '{cpf}'";
            classConexao cConexao = new classConexao();
            return tratarSexoRelatorio(cConexao.RetornaDados(sql));
        }

        private DataTable tratarSexoRelatorio(DataTable dt)
        {
            if (dt != null)
            {
                dt.Columns["sexo"].MaxLength = 20;

                foreach (DataRow linha in dt.Rows)
                {
                    if (linha["sexo"].ToString().ToUpper() == "M")
                    {
                        linha["sexo"] = "Masculino";
                    }
                    else
                    {
                        if (linha["sexo"].ToString().ToUpper() == "F")
                        {
                            linha["sexo"] = "Feminino";
                        }
                        else
                        {
                            linha["sexo"] = "Não informado";
                        }
                    }
                }
            }

            return dt;
        }

        private DataTable tratarSexoConsulta(DataTable dt)
        {
            if (dt != null)
            {
                if (dt.Columns.Contains("Sexo"))
                {
                    dt.Columns["Sexo"].MaxLength = 20;

                    foreach (DataRow linha in dt.Rows)
                    {
                        if (linha["Sexo"].ToString().ToUpper() == "M")
                        {
                            linha["Sexo"] = "Masculino";
                        }
                        else
                        {
                            if (linha["Sexo"].ToString().ToUpper() == "F")
                            {
                                linha["Sexo"] = "Feminino";
                            }
                            else
                            {
                                linha["Sexo"] = "Não informado";
                            }
                        }
                    }
                }
            }

            return dt;
        }


        public DataTable consultarClienteCpf(string cpf)
         {

            string sql = $"SELECT cod_cliente AS Codigo, nome AS Nome, data_nascimento AS 'Data de Nascimento', sexo AS Sexo, cpf AS CPF, cidade AS Cidade, uf AS Estado,telefone_residencial AS 'Tel. Residencial', telefone_celular AS 'Tel. Celular', email AS Email, status AS Status, data_cadastro AS 'Data de Cadastro' FROM cliente WHERE cpf = '{cpf}'";
            classConexao cConexao = new classConexao();
            return tratarSexoConsulta(cConexao.RetornaDados(sql));

         }
        public DataTable consultarClienteVenda(string nome)
        {
            string sql = $"SELECT cod_cliente as Código, nome AS Nome, cpf AS CPF from cliente WHERE nome LIKE '%{nome}%' and status = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        
        public bool dadoscliente(int cod)
        {
            string sql = $"SELECT * FROM cliente WHERE cod_cliente = {cod}";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            if (dt.Rows.Count > 0)
            {
                cod_cliente = Convert.ToInt32(dt.Rows[0]["cod_cliente"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                uf = Convert.ToString(dt.Rows[0]["uf"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                telefone_residencial = Convert.ToString(dt.Rows[0]["telefone_residencial"]);
                telefone_celular = Convert.ToString(dt.Rows[0]["telefone_celular"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
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
