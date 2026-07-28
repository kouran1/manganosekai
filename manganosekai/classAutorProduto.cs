using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace manganosekai
{
    class classAutorProduto
    {
        public classAutorProduto()
        {
            cod_produto = 0;
            cod_autor = 0;
        }
        public int cod_produto { get; set; }
        public int cod_autor{ get; set; }

        public int cadastrarAutorProduto()
        {
            string sql = $"INSERT INTO autor_produto VALUES({cod_produto},{cod_autor})";
            classConexao objconexao = new classConexao();
            return objconexao.ExecutaQueryID(sql);
        }
    }
}
