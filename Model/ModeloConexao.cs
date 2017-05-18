using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    public class ModeloConexao
    {
        private string _strdeConexao;
        private SqlConnection _ConexaoSql = new SqlConnection();

        public ModeloConexao()
        {
            this._strdeConexao = "Data Source = tcp:ibta.ddns.net; Initial Catalog = PROJETO_IBTA_NOVO; User ID = sa; Password = penedo";
            this._ConexaoSql = new SqlConnection(_strdeConexao);
        }

        public SqlConnection objConexao()
        {
            return this._ConexaoSql;
        }

        public void Conectar()
        {
            this._ConexaoSql.Open();
        }
        public void Desconectar()
        {
            this._ConexaoSql.Close();
        }

    }
}
