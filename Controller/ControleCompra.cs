﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Text.RegularExpressions;
using Model;
using System.Data.SqlClient;

namespace Controller
{
    public class ControleCompra
    {
        //Cria os objetos de conexao ao banco de dados
        ModeloConexao conexao = new ModeloConexao();
        SqlCommand comando = new SqlCommand();
        public ModeloCompra DadosDaCompra = new ModeloCompra();
        private ControleEstoque Estoque = new ControleEstoque();



        public ControleCompra()
        {
            //Define que o comando SQL deve usar a conexao contida em objConexao 
            comando.Connection = conexao.objConexao();
        }

        public void Inserir(ModeloCompra compra)
        {   // Sobrecarga 1 - Metodo principal
            // Recebe de parametro um objeto do tipo "ModeloCompra"
            // Verifica se os dados são validos e insere do Banco de dados

            comando.Parameters.Clear();
            if (ValidarDadosCompra(compra) == true)
            {
                //Define o comando a ser enviado ao SQL
                comando.CommandText = "insert into COMPRAS values(@codAcao, @valorcompra, @data, @quantidade, @inativo); select SCOPE_IDENTITY();";
                comando.Parameters.AddWithValue("@codAcao", compra.CodigoAcao);
                comando.Parameters.AddWithValue("@valorcompra", compra.ValorCompra);
                //Preciso ver um jeito de validar que o valor de data seja uma data :)
                comando.Parameters.AddWithValue("@data", compra.Data);
                comando.Parameters.AddWithValue("@quantidade", compra.Quantidade);
                comando.Parameters.AddWithValue("@inativo", compra.Inativo);

                //Conecta ao SQL e executa o comando
                conexao.Conectar();
                int numLinhaDoRegistro = Convert.ToInt32(comando.ExecuteScalar());
                compra.CodigoCompra = numLinhaDoRegistro;
                conexao.Desconectar();

                Estoque.Decrementar(compra);
            }
        }
        public void Inserir()
        {
            //Sobrecarga 2 
            // 
            Inserir(this.DadosDaCompra);
        }
        public bool Inserir(int codigoAcao, float valorTotalDaCompra, int quantidade, string dataDaCompra, bool inativo)
        {
            //DadosDaCompra.CodigoCompra;
            DadosDaCompra.CodigoAcao = codigoAcao;
            DadosDaCompra.ValorCompra = valorTotalDaCompra;
            DadosDaCompra.Data = dataDaCompra;
            DadosDaCompra.Quantidade = quantidade;
            DadosDaCompra.Inativo = inativo;

            try
            {
                Inserir();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                DadosDaCompra.Clear();
                return false;
            }
        }


        public DataSet      ListarCompras(string dataInicial, string dataFinal, int codigoDaAcao )
        {   
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dt = new DataSet();
            string strCmd = "";


            if (codigoDaAcao == 0)
            {

                //strCmd= "SELECT * FROM COMPRAS WHERE DATA_COMPRA > @dataInicial AND DATA_COMPRA < @dataFinal";
                strCmd = "SELECT A.LANCAMENTO_COMPRA,A.ACAO as CODIGO_DA_ACAO,B.EMPRESA,A.VALOR_COMPRA, A.DATA_COMPRA,A.QUANTIDADE,A.INATIVO as COMPRA_INATIVA,B.INATIVO as ACAO_INATIVA FROM COMPRAS A JOIN ACOES B ON A.ACAO = B.ID_ACAO where DATA_COMPRA > @dataInicial and DATA_COMPRA<@dataFinal";
            }
            else
            {
                strCmd = "SELECT * FROM COMPRAS WHERE DATA_COMPRA > @dataInicial AND DATA_COMPRA < @dataFinal AND ACAO = @codAcao ";
            }

            if (Validacao.validarData(dataInicial) == true && Validacao.validarData(dataFinal)== true)
            {
                comando.Parameters.Clear();
                comando.CommandText = strCmd;
                comando.Parameters.AddWithValue("@codAcao", codigoDaAcao);
                comando.Parameters.AddWithValue("@dataInicial", dataInicial);
                comando.Parameters.AddWithValue("@dataFinal", dataFinal);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            else
            {
                return null;
            }
            

        }
        public DataSet      ListarCompras(string dataInicial, string dataFinal)
        {
            return ListarCompras(dataInicial, dataFinal,0); 
        }
        public void         ListarCompras(string dataInicial, string dataFinal, int codigoDaAcao, DataGridView objetoAlvo)
        {
            DataSet ds = new DataSet();

            ds = this.ListarCompras(dataInicial, dataFinal);
            objetoAlvo.DataSource = ds;
            objetoAlvo.DataMember = ds.Tables[0].TableName;

        }

        public ModeloCompra BuscarCompra(int id)
        {
            return null;
        }
        public void         AtualizarCompra()
        {

        }
        private bool        ValidarDadosCompra(ModeloCompra compra)
        {
            string strErro = "";
            bool Ok = true;
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4})");

            if (compra.CodigoAcao == 0)
            {
                strErro += ("\nCódigo de ação inválido ");
                Ok = false;
            }
            
            if (compra.Quantidade <= 0)
            {
                strErro += ("\nQuantidade tem que ser maior que 0 ");
                Ok = false;
            }
            if ((r.Match(compra.Data).Success == false))
            {
                strErro += ("\nData invalida, use dd/mm/aaaa ");
                Ok = false;
            }
            if (!Ok) MessageBox.Show(strErro);
            return Ok;

        }
       

        public void     NoEstoque(ModeloCompra compra)
        {

        }
        public void     Estornar(ModeloCompra compra)
        {

        }
        public void     Estornar(int id_compra)
        {

        }

        public void     ValorMedio(int id)
        {

        }
        public void     ValorMedio()
        {

        }
        
    }
}