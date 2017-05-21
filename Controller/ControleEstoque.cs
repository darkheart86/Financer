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
    public class ControleEstoque
    {
        //ModeloEstoque DadosEstoque = new ModeloEstoque();
        //Cria os objetos de conexao ao banco de dados
        ModeloConexao conexao = new ModeloConexao();
        SqlCommand comando = new SqlCommand();

        public ControleEstoque()
        {
            comando.Connection = conexao.objConexao();
        }

        public void Incrementar(ModeloEstoque obj)
        {
           // msg(Buscar(obj.IdAcao).IdAcao.ToString());
            if (Buscar(obj.IdAcao) != null)
            {
                msg("Incrementa");
                Atualizar(obj);
            }
            else
            {

                msg("Cria novo");
                Inserir(obj);

            }

        }
        public void Incrementar(ModeloCompra obj)
        {
          
            Incrementar(this.ConverterCompra(obj));
        }
        //public void Incrementar(ModeloVenda obj)
        //{ }

        public void Decrementar(ModeloEstoque obj)
        {
            int qtdeEmEstoque = Buscar(obj.IdAcao).Quantidade;
            if (obj.Quantidade < qtdeEmEstoque)
            {
                msg("Decremeta");

                obj.Quantidade *= -1;
                obj.ValorAcumulado *= -1;
                Atualizar(obj);
            }
            else
            {
                msg("Você não pode vender unidades do que tem em estoque! \n" +
                    "Unidades em estoque: " + qtdeEmEstoque);      
            }


        }
        public void Decrementar(ModeloCompra obj)
        {
            if (Buscar(obj.CodigoAcao) != null)
            {
                Decrementar(this.ConverterCompra(obj));
            }
            else
            {
                msg("Não existe registro de estoque para a acao");
            }
        }
        //public void Decrementar(ModeloVenda obj)
        //{ }

        public int Quantidade(int codigo)
        {
            ModeloEstoque obj = new ModeloEstoque();

            if (obj != null)
            {
                return obj.Quantidade;
            }
            else
            {
                return 0;
            }
        }

        private void Inserir(ModeloEstoque obj)
        {
            //Define o comando a ser enviado ao SQL
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO ESTOQUE(ACAO,QUANTIDADE,VALOR_ACUMULADO,INATIVO) VALUES(@codAcao,@quantidade,@valorTotal,@inativo)";
            comando.Parameters.AddWithValue("@codAcao", obj.IdAcao);
            comando.Parameters.AddWithValue("@quantidade", obj.Quantidade);
            comando.Parameters.AddWithValue("@valorTotal", obj.ValorAcumulado);
            comando.Parameters.AddWithValue("@inativo", obj.Inativo);

            //Conecta ao SQL e executa o comando
            try
            {
                conexao.Conectar();
                //obj.IdEstoque = Convert.ToInt32(comando.ExecuteScalar());
                comando.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
        private void Atualizar(ModeloEstoque obj)
        { 
            //Define o comando a ser enviado ao SQL
            comando.Parameters.Clear();
            comando.CommandText = "UPDATE ESTOQUE SET QUANTIDADE += @quantidade, VALOR_ACUMULADO += @valorTotal WHERE ACAO = @codAcao";
            comando.Parameters.AddWithValue("@codAcao", obj.IdAcao);
            comando.Parameters.AddWithValue("@quantidade", obj.Quantidade);
            comando.Parameters.AddWithValue("@valorTotal", obj.ValorAcumulado);
            comando.Parameters.AddWithValue("@inativo", obj.Inativo);

            //Conecta ao SQL e executa o comando
            try
            {
                conexao.Conectar();
                //comando.ExecuteNonQuery();
                obj.IdEstoque = Convert.ToInt32(comando.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        public ModeloEstoque Buscar(int codigo)
        {
            ModeloEstoque obj = new ModeloEstoque();

            comando.Parameters.Clear();
            comando.CommandText = "select * from ESTOQUE where ACAO = @cod_acao;";
            comando.Parameters.AddWithValue("@cod_acao", codigo);
            conexao.Conectar();
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                obj.IdAcao = Convert.ToInt32(registro["ACAO"]);
                obj.Quantidade = Convert.ToInt32(registro["QUANTIDADE"]);
                obj.ValorAcumulado = float.Parse(registro["VALOR_ACUMULADO"].ToString());
                obj.Inativo = Convert.ToBoolean(registro["INATIVO"]);
                
                conexao.Desconectar();

                msg(obj.IdAcao.ToString());
                return obj;
            }
            else
            {
                conexao.Desconectar();
                return null;
            }
            
        }
        //public ModeloEstoque Buscar()
        //{
        //    if (this.DadosEstoque.IdAcao != 0)
        //    {
        //        return this.Buscar(this.DadosEstoque.IdAcao);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        ////}

        public DataSet Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dt = new DataSet();
            string strCmd = "SELECT A.ACAO AS 'Ação', B.EMPRESA AS 'Empresa', A.QUANTIDADE AS 'Qtde', A.VALOR_ACUMULADO AS 'Valor total' FROM ESTOQUE A JOIN ACOES B ON A.ACAO = B.ID_ACAO";
            

            //if (Validacao.validarData(dataInicial) == true && Validacao.validarData(dataFinal) == true)
            //{
                comando.Parameters.Clear();
                comando.CommandText = strCmd;
                //comando.Parameters.AddWithValue("@codAcao", codigoDaAcao);
                //comando.Parameters.AddWithValue("@dataInicial", dataInicial);
                //comando.Parameters.AddWithValue("@dataFinal", dataFinal);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            //}
            //else
            //{
            //    return null;
            //}


        }
        public void Listar(DataGridView obj)
        {
            DataSet ds = Listar();

            obj.DataSource = ds;
            obj.DataMember = ds.Tables[0].TableName;
        }
        private ModeloEstoque ConverterCompra(ModeloCompra obj)
        {
            ModeloEstoque opEstoque = new ModeloEstoque();

            opEstoque.IdAcao = obj.CodigoAcao;
            opEstoque.Quantidade = obj.Quantidade;
            opEstoque.ValorAcumulado = obj.ValorCompra;
            opEstoque.Inativo = obj.Inativo;

            return opEstoque;
        }

        //private ModeloEstoque ConverterVenda(ModeloVenda obj)
        //{
        //    ModeloEstoque opEstoque = new ModeloEstoque();

        //    opEstoque.IdAcao = obj.CodigoAcao;
        //    opEstoque.Quantidade = obj.Quantidade;
        //    opEstoque.ValorAcumulado = obj.ValorCompra;
        //    opEstoque.Inativo = obj.Inativo;

        //    return opEstoque;
        //}

        private void msg(string msg)
        {
#if (DEBUG)
            MessageBox.Show(msg);
#endif
        }

    }
}
