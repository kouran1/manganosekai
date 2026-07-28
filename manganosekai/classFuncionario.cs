using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace manganosekai
{
    class classFuncionario
    {
        //Metodo Construtor
        //O metodo construtor precisa ter o mesmo nome da classe criada
        public classFuncionario()
        {
            cod_funcionario = 0;
            nome = null;
            nome_social = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            estado_civil = null;
            cpf = null;
            rg = null;
            salario = 0;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            uf = null;
            cep = null;
            telefone_residencial = null;
            telefone_celular = null;
            email = null;
            status = 0;
            data_cadastro = DateTime.Now;
            usuario = null;
            senha = null;
            tipo_acesso = 0;
            foto = null;
            cod_cargo = 0;
     
        }
        //Propriedades

        public int cod_funcionario { get; set; }
        public string nome { get; set; }

        public string nome_social { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public decimal salario { get; set; }
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
        public string usuario { get; set; }
        public string senha { get; set; }
        public int tipo_acesso { get; set; }
        public string foto { get; set; }
        public int cod_cargo { get; set; }

        //METODOS
        //CADASTRAR FUNCIONARIO
        //CAMPO DATE : propriedade.ToString("yyyy-MM-dd")
        //CAMPOS DECIMAL: propriedade.ToString().Replace("," , ".")
        // NÃO PODE MANDAR ASPAS SIMPLES CAMPOS DO TIPO BIT

        public int cadastrarfuncionario()
        {
            string sql = $"INSERT INTO funcionario VALUES(0,'{nome}','{nome_social}','{data_nascimento.ToString("yyy-MM-dd")}','{sexo}','{estado_civil}','{cpf}','{rg}', '{salario.ToString().Replace(",", ".")}','{endereco}',{numero},'{complemento}', '{bairro}','{cidade}', '{uf}', '{cep}', '{telefone_residencial}', '{telefone_celular}','{email}',1, NOW(), '{usuario}','{senha}',{tipo_acesso},'{foto}',{cod_cargo});";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }
        /* Filtros: Nome(INICIO e CONTEM), CARGO, CIDADE, SEXO, CPF, DATA ADMISSÃO, E STATUS*/ /*Campos exibidos na consulta: CODIGO FUNCIONÁRIO, NOME, CPF, DATA NASCIMENTO, CIDADE, SEXO, CARGO E CELULAR*/

        // CONSULTA DE FUNCIONARIO POR CIDADE 

        public DataTable consultaFuncionarioCidade(string cidade)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '{cidade}' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarFuncionarioCargo(int cargo)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cod_cargo = {cargo} ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarFuncionarioSexo(string sexo)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '{sexo}' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable consultarFuncionarioCpf(string cpf)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cpf = '{cpf}' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //Consulta de funcionario por nome inicio
        public DataTable consultarFuncionarioNomeInicio(string nomei)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '{nomei}%' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //Consulta de funcionario por nome (contém)
        public DataTable consultarFuncionarioNomeContem(string nomec)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '%{nomec}%' ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //Consulta de funcionario por data cadastro (admissao)
        public DataTable consultarFuncionarioDataCadastro(DateTime datai, DateTime dataf)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND CAST(funcionario.data_cadastro AS DATE) BETWEEN '{datai.ToString("yyyy-MM-dd")}' AND '{dataf.ToString("yyyy-MM-dd")}'  ORDER BY funcionario.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        //Consulta de funcionario por status    
        public DataTable consultarFuncionarioStatus(int status)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = {status};";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        //Consultar por sexo cidade
        public DataTable ConsultarFuncionarioCidadeSexo(string sexo, string cidadesx)
        {
            string sql = $"SELECT funcionario.cod_funcionario 'COD', funcionario.nome 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Nascimento', funcionario.cidade 'Cidade', funcionario.sexo 'Sexo' , cargo.nome 'Cargo', funcionario.telefone_celular 'Celular' FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.cidade = '{cidadesx}' AND funcionario.sexo = '{sexo}' ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //Reports - relatórios

        //Aniversariante do mês
         public DataTable ReportFuncionarioBirthdayMonth(int mes)
         {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND MONTH(funcionario.data_nascimento) = {mes} ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
         }


        // Por idade

        public DataTable ReportFuncionariosIdade(int idadei, int idadef)
        {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status =  1 AND TIMESTAMPDIFF(YEAR, funcionario.data_nascimento, NOW()) BETWEEN {idadei} AND {idadef} ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //Por cargo
        public DataTable ReportFuncionarioCargo(int cargo)
        {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cod_cargo  = {cargo} ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportFuncionarioCidade(string cidade)
        {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '{cidade}' ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable carregarVendedor()
        {
            string sql = $"SELECT funcionario.nome, funcionario.cod_funcionario FROM funcionario JOIN cargo ON cargo.cod_cargo = funcionario.cod_cargo WHERE funcionario.status = 1 AND cargo.nome LIKE '%vendedor%' ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportFuncionarioDataAdmissao(DateTime datai, DateTime dataf)
        {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND  CAST(funcionario.data_cadastro AS DATE) BETWEEN '{datai.ToString("yyyy-MM-dd")}' AND '{dataf.ToString("yyyy-MM-dd")}'  ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportFuncionarioSexo(string sexo)
        {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '{sexo}' ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
        public DataTable ReportFuncionarioStatus(int status)
        {
            string sql = $"SELECT funcionario.nome, funcionario.cpf, funcionario.telefone_celular, funcionario.data_nascimento, funcionario.sexo, cargo.nome 'cod_cargo', funcionario.cidade, funcionario.data_cadastro FROM funcionario JOIN cargo ON funcionario.cod_cargo = cargo.cod_cargo WHERE funcionario.status = {status} ORDER BY funcionario.nome";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        // Login do sistema

        public bool loginUser(string user, string password)
        {
            string sql = $"SELECT funcionario.usuario, funcionario.senha,funcionario.tipo_acesso,funcionario.status FROM funcionario WHERE status = 1 AND funcionario.usuario = '{user}' AND funcionario.senha = '{password}';";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(sql);

            if (dt.Rows.Count > 0)
            {
                usuario = Convert.ToString(dt.Rows[0]["usuario"]);
                senha = Convert.ToString(dt.Rows[0]["senha"]);
                return true;
            }
            else
            {
                return false;
            }
        }



        //Metodo para buscar todos os dados do funcionario selecionado pelo usuario no form de consulta </>

        public bool dadosfuncionario(int cod)
        {
            string sql = $"SELECT * FROM funcionario WHERE cod_funcionario = {cod}";

            classConexao cConexao = new classConexao();

            //Montar o data table que recebera todos os dados escolhido pelo usuario
            DataTable dt = cConexao.RetornaDados(sql);

            //Se a consulta der certo
            if(dt.Rows.Count >0)
            {
                //Exibir todos os campos da tabela funcionario
                cod_funcionario = Convert.ToInt32(dt.Rows[0]["cod_funcionario"]);
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                salario = Convert.ToDecimal(dt.Rows[0]["salario"]);
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
                usuario = Convert.ToString(dt.Rows[0]["usuario"]);
                senha = Convert.ToString(dt.Rows[0]["senha"]);
                tipo_acesso = Convert.ToInt32(dt.Rows[0]["tipo_acesso"]);
                //foto = Convert.ToString(dt.Rows[0]["foto"]);
                cod_cargo = Convert.ToInt32(dt.Rows[0]["cod_cargo"]);

                return true;

            }


            else
            {
    
                
                return false;
            }
        }

        //Metodo para atualizar funcionario
        public int atualizarFuncionario()
        {
            string sql = $"UPDATE funcionario SET nome = '{nome}', nome_social = '{nome_social}',data_nascimento = '{data_nascimento.ToString("yyy-MM-dd")}', sexo ='{sexo}',estado_civil ='{estado_civil}', cpf ='{cpf}', rg ='{rg}', salario = '{salario.ToString().Replace(",", ".")}', endereco ='{endereco}',numero = {numero}, complemento = '{complemento}', bairro='{bairro}', cidade ='{cidade}',uf = '{uf}',cep = '{cep}', telefone_residencial = '{telefone_residencial}', telefone_celular ='{telefone_celular}',email ='{email}', status = {status}, usuario ='{usuario}', senha ='{senha}', tipo_acesso ={tipo_acesso},foto ='{foto}',cod_cargo = {cod_cargo} WHERE cod_funcionario = {cod_funcionario}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        //Metodo para deletar usuario
        public int deletarUsuario()
        {
            string sql = $"DELETE FROM funcionario WHERE cod_funcionario = {cod_funcionario}";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(sql);
        }

        public DataTable buscarcidade()
        {
            string sql = $"SELECT DISTINCT cidade FROM funcionario WHERE status = 1 ORDER BY cidade";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }
    }
}
