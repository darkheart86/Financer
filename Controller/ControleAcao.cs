using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using Model;
using System.Data.SqlClient;

namespace Controller
{
    public class ControleAcao : ModeloAcao
    {
        //Cria os objetos de conexao ao banco de dados
        ModeloConexao conexao = new ModeloConexao();
        SqlCommand comando = new SqlCommand();


        public void Inserir(ModeloAcao acao)
        {
            //Define que o comando SQL deve usar a conexao contida em objConexao 
            comando.Connection = conexao.objConexao();

            if (acao.NomeEmpresa != "")
            {
                if (this.BuscarAcao(acao.NomeEmpresa) == null)
                {
                    comando.Parameters.Clear();
                    //Define o comando a ser enviado ao SQL
                    comando.CommandText = "insert into ACOES values (@empresa,@status); select SCOPE_IDENTITY();";
                    comando.Parameters.AddWithValue("@empresa", acao.NomeEmpresa);
                    comando.Parameters.AddWithValue("@status", acao.Inativo);

                    //Conecta ao SQL e executa o comando
                    conexao.Conectar();
                    int numLinhaDoRegistro = Convert.ToInt32(comando.ExecuteScalar());

                    acao.CodigoAcao = numLinhaDoRegistro;
                    conexao.Desconectar();
                }
                else
                {
                    throw new Exception("Já existe uma ação com este nome");
                    //MessageBox.Show("Dá não tiuzao");
                }
            }
            else
            {
                throw new Exception("O nome da empresa não pode estar vazio");
            }
        }

        public DataSet ListarAcoes(int tipo_de_busca)
        {   
            // tipos de busca
            // 0 - Lista todas acões: ativas e inativas
            // 1 - Lista apenas as ações ativas
            // 2 - Lista apenas as ações inativas

            if (tipo_de_busca <= 0 && tipo_de_busca >= 2) tipo_de_busca = 0;
           
            //Define o comando a ser enviado ao SQL
            if (tipo_de_busca == 0) comando.CommandText = "select ID_ACAO, EMPRESA from ACOES;";
            if (tipo_de_busca == 1) comando.CommandText = "select ID_ACAO, EMPRESA from ACOES where INATIVO = 0;";
            if (tipo_de_busca == 2) comando.CommandText = "select ID_ACAO, EMPRESA from ACOES where INATIVO = 1;";

            //Define que o comando SQL deve usar a conexao contida em objConexao
            comando.Connection = conexao.objConexao();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dt = new DataSet();

            
            //comando.CommandText = "select ID_ACAO, EMPRESA from ACOES where INATIVO = 0;";
            //comando.CommandText = "select ID_ACAO, EMPRESA from ACOES;";
            da.SelectCommand = comando;
            da.Fill(dt);
            return dt;


        }
        public DataSet ListarAcoes()
        {

            return this.ListarAcoes(0);
        }
        public void ListarAcoes(DataGridView obj, int tipo_de_busca)
        {
            DataSet dt = new DataSet();
            dt = this.ListarAcoes(tipo_de_busca);

            obj.DataSource = dt;
            obj.DataMember = dt.Tables[0].TableName;


        }
        public void ListarAcoes(DataGridView obj)
        {
            this.ListarAcoes(obj, 0);
        }
        public void ListarAcoes(ListBox obj)
        {
            this.ListarAcoes(obj, 0);
        }
        public void ListarAcoes(ListBox obj, int tipo_de_busca)
        {
            DataSet dt = new DataSet();
            dt = this.ListarAcoes(tipo_de_busca);
            dt.Tables[0].Rows.Add();
            obj.DataSource = dt.Tables[0];
            obj.DisplayMember = "EMPRESA";
            obj.ValueMember = "ID_ACAO";
        }
        public void ListarAcoes(ComboBox obj)
        {
            this.ListarAcoes(obj, 0);
        }
        public void ListarAcoes(ComboBox obj, int tipo_de_busca)
        {
            DataSet dt = new DataSet();
            dt = this.ListarAcoes(tipo_de_busca);
            dt.Tables[0].Rows.Add();
            obj.DataSource = dt.Tables[0];
            obj.DisplayMember = "EMPRESA";
            obj.ValueMember = "ID_ACAO";
        }

        public ModeloAcao BuscarAcao(int codigo)
        {

            ModeloAcao modelo = new ModeloAcao();
            comando.Connection = conexao.objConexao();
            comando.Parameters.Clear();
            comando.CommandText = "select ID_ACAO, EMPRESA, INATIVO from ACOES where ID_ACAO = @cod_acao;";
            comando.Parameters.AddWithValue("@cod_acao", codigo);
            conexao.Conectar();
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodigoAcao = Convert.ToInt32(registro["ID_ACAO"]);
                modelo.NomeEmpresa = Convert.ToString(registro["EMPRESA"]);
                modelo.Inativo = Convert.ToBoolean(registro["INATIVO"]);
            }
            conexao.Desconectar();
            return modelo;

        }
        public ModeloAcao BuscarAcao(string nome)
        {
            ModeloAcao modelo = new ModeloAcao();
            comando.Connection = conexao.objConexao();
            comando.Parameters.Clear();
            comando.CommandText = "select ID_ACAO, EMPRESA, INATIVO from ACOES where EMPRESA = @empresa;";
            comando.Parameters.AddWithValue("@empresa", nome);
            conexao.Conectar();
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodigoAcao = Convert.ToInt32(registro["ID_ACAO"]);
                modelo.NomeEmpresa = Convert.ToString(registro["EMPRESA"]);
                modelo.Inativo = Convert.ToBoolean(registro["INATIVO"]);
                conexao.Desconectar();

                //MessageBox.Show(modelo.CodigoAcao.ToString() + ": " + modelo.NomeEmpresa);
                return modelo;
            }
            else
            {
                conexao.Desconectar();
                return null;
            }
        }

        public void AtualizarAcao(ModeloAcao acao, bool verifica_redundancia)
        //public void AtualizarAcao(ModeloAcao acao, bool verifica_redundancia)
        {
            /*
             *
             * O metodo atualiza ação pode ou não verificar se o nome da ação já existe
             * isso é definido no parametro verifica_redundancia.
             *
             */

            //Define que o comando SQL deve usar a conexao contida em objConexao
            comando.Connection = conexao.objConexao();
            //SqlDataAdapter da = new SqlDataAdapter();

            // Variavel interna temporaria que vou usar na validacao dos parametros
            ModeloAcao _acao = new ModeloAcao();
            //bool verifica_redundancia = true;


            // Limpa os parametros do comando(SqlCommand) para não haver conflito
            comando.Parameters.Clear();
            if (acao.NomeEmpresa != "")
            {
                //Valida o parametro verifica_redundancia 
                if (verifica_redundancia)
                {
                    //Se o comando BuscaAcao nao encontrar a empresa ele retorna null, senão retorna com a Acao (ModeloAcao)
                    _acao = this.BuscarAcao(acao.NomeEmpresa);
                }
                else
                {
                    _acao = null;
                }

                //Se a acao for nula por nao ter encontrado na BuscaAcao ou pelo parametro verifica_redundancia
                if (_acao == null)
                {
                    //Define o comando e os parametros do comando a ser enviado ao SQL
                    comando.Parameters.Clear();
                    comando.CommandText = "UPDATE ACOES SET EMPRESA = @empresa, INATIVO = @status WHERE ID_ACAO = @id";
                    comando.Parameters.AddWithValue("@empresa", acao.NomeEmpresa);
                    comando.Parameters.AddWithValue("@status", acao.Inativo);
                    comando.Parameters.AddWithValue("@id", acao.CodigoAcao);

                    conexao.Conectar();
                    comando.ExecuteNonQuery();
                    conexao.Desconectar();
                }
                else
                {
                    /*
                     * Interrompe o metodo e retorna um erro
                     * Este erro pode ser tratado no front com o comando try, catch
                     */
                     
                    throw new Exception("Já existe uma ação com este nome");
                    
                }
            }
            else
            {
                throw new Exception("O nome da empresa não pode estar vazio");
            }
        }
        public void InativaAcao(int id)
        {
            /* 
             * Já que não vamos usar o DELETE no banco de dados,
             * vamos usar o inativa acao pra fazer algo equivalente.
             * 
             * Ainda não sei se esse metodo realmente sera usado?!
             * Mesmo porque eu teria que criar outro metodo para ativar a acao ou algo do tipo
             *
             */ 
             

            comando.Connection = conexao.objConexao();
            ModeloAcao acao = new ModeloAcao();

            if (id != 0)
            {
                acao = this.BuscarAcao(id);
                if (acao != null)
                {
                    acao.Inativo = true;
                    AtualizarAcao(acao, true);
                }
            }
        }
    }
}
