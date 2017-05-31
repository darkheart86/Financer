using System;
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
    public class ControleVenda
    {
        //Cria os objetos de conexao ao banco de dados
        ModeloConexao conexao = new ModeloConexao();
        SqlCommand comando = new SqlCommand();
        public ModeloVenda DadosDaVenda = new ModeloVenda();
        private ControleEstoque Estoque = new ControleEstoque();
        public EstilosDGView Estilos = new EstilosDGView();

        
        public ControleVenda()
        {
            //Define que o comando SQL deve usar a conexao contida em objConexao 
            comando.Connection = conexao.objConexao();
        }

        public void Inserir(ModeloVenda venda)
        {   // Sobrecarga 1 - Metodo principal
            // Recebe de parametro um objeto do tipo "ModeloVenda"
            // Verifica se os dados são validos e insere do Banco de dados

            comando.Parameters.Clear();
            if (ValidarDadosVenda(venda) == true)
            {
                //venda.LucroLiquido = venda.ValorVendaLiquida - (Estoque.ValorMedio(venda.CodigoAcao) * venda.Quantidade);
                //Define o comando a ser enviado ao SQL
                comando.CommandText = "insert into VENDAS values(@codAcao, @valordaacao, @valorvendabruta, @lucrobruto, @ir, @ircalculado, @lucroliquido, @quantidade, @data, @inativo);" +
                "select SCOPE_IDENTITY();";
                comando.Parameters.AddWithValue("@codAcao", venda.CodigoAcao);
                comando.Parameters.AddWithValue("@valorvendabruta", venda.ValorVendaBruta);
                comando.Parameters.AddWithValue("@valordaacao", venda.ValorMedioDeEstoque);
                comando.Parameters.AddWithValue("@lucrobruto", venda.LucroBruto);
                comando.Parameters.AddWithValue("@ir", venda.PorcentagemIR);
                comando.Parameters.AddWithValue("@ircalculado", venda.IRCalculado);
                comando.Parameters.AddWithValue("@lucroliquido", venda.LucroLiquido);
                comando.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                comando.Parameters.AddWithValue("@data", venda.Data);
                comando.Parameters.AddWithValue("@inativo", venda.Inativo);

                //Conecta ao SQL e executa o comando
                conexao.Conectar();
                int numLinhaDoRegistro = Convert.ToInt32(comando.ExecuteScalar());
                venda.CodigoVenda = numLinhaDoRegistro;
                conexao.Desconectar();

                Estoque.Decrementar(venda);
            }
        }
        public void Inserir()
        {
            //Sobrecarga 2 
            // 
            Inserir(this.DadosDaVenda);
        }
        public bool Inserir(int codigoAcao, float valorTotalDaVenda, int quantidade, string dataDaVenda, bool inativo)
        {
            //DadosDaVenda.CodigoVenda;
            DadosDaVenda.CodigoAcao = codigoAcao;
            //DadosDaVenda.ValorVendaBruta = valorTotalDaVenda;
            DadosDaVenda.Data = dataDaVenda;
            DadosDaVenda.Quantidade = quantidade;
            DadosDaVenda.Inativo = inativo;

            try
            {
                Inserir();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                DadosDaVenda.Clear();
                return false;
            }
        }


        public DataSet      ListarVendas(string dataInicial, string dataFinal, int codigoDaAcao )
        {   
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dt = new DataSet();
            string strCmd = "";


            if (codigoDaAcao == 0)
            {

                //strCmd= "SELECT * FROM COMPRAS WHERE DATA_COMPRA > @dataInicial AND DATA_COMPRA < @dataFinal";
                strCmd = "SELECT A.ID_VENDA AS 'ID Venda', A.DATA_VENDA as 'Data',A.ACAO as 'Ação' ,B.EMPRESA as 'Empresa',A.QUANTIDADE as 'Qtde'," +
                "A.VALOR_VENDA as 'Venda', A.IR as 'IR', A.IR_CALCULADO as 'IR_calculado', A.LUCRO as 'Lucro'" +
                "FROM VENDAS A JOIN ACOES B ON A.ACAO = B.ID_ACAO where DATA_VENDA >= @datainicial and DATA_VENDA <= @datafinal";

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
        public DataSet      ListarVendas(string dataInicial, string dataFinal)
        {
            return ListarVendas(dataInicial, dataFinal,0); 
        }
        public void         ListarVendas(string dataInicial, string dataFinal, int codigoDaAcao, DataGridView obj)
        {
            DataSet ds = ListarVendas(dataInicial, dataFinal,codigoDaAcao);

            
            int qtdeTotal = 0;
            float mediaTotal = 0;
            float vendaTotal = 0;
            float irTotal = 0;
            float irCalcTotal = 0;
            float lucroTotal = 0;

            if (ds.Tables[0].Rows.Count > 0)
            {                
                qtdeTotal = int.Parse(ds.Tables[0].Compute("Sum(Qtde)", "").ToString());
                mediaTotal = float.Parse(ds.Tables[0].Compute("Sum(Média)", "").ToString());
                vendaTotal = float.Parse(ds.Tables[0].Compute("Sum(Venda)", "").ToString());
                irTotal = float.Parse(ds.Tables[0].Compute("Sum(IR)", "").ToString());
                irCalcTotal = float.Parse(ds.Tables[0].Compute("Sum(IR_calculado)", "").ToString());
                lucroTotal = float.Parse(ds.Tables[0].Compute("Sum(Lucro)", "").ToString());
            }

            EstilosDGView Estilos = new EstilosDGView();

            ds.Tables[0].Rows.Add(null, null, null, "Total: ", qtdeTotal,mediaTotal,vendaTotal,irTotal,irCalcTotal,lucroTotal );

            obj.DataSource = ds;
            obj.DataMember = ds.Tables[0].TableName;
            //MessageBox.Show(precoTotal.ToString());
            obj.Rows[obj.Rows.Count - 1].DefaultCellStyle = Estilos.LinhaFinal;






        }

        public ModeloVenda  BuscarVenda(int id)
        {
            return null;
        }
        public void         AtualizarVenda()
        {

        }
        private bool        ValidarDadosVenda(ModeloVenda venda)
        {
            string strErro = "";
            bool Ok = true;
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4})");

            if (venda.CodigoAcao == 0)
            {
                strErro += ("\nCódigo de ação inválido ");
                Ok = false;
            }
            
            if (venda.Quantidade <= 0)
            {
                strErro += ("\nQuantidade tem que ser maior que 0 ");
                Ok = false;
            }

            if (venda.Quantidade > Estoque.Quantidade(venda.CodigoAcao))
            {
                strErro += ("\nQuantidade insulficiente em estoque ");
                Ok = false;
            }

            if ((r.Match(venda.Data).Success == false))
            {
                strErro += ("\nData invalida, use dd/mm/aaaa ");
                Ok = false;
            }
            if (!Ok) MessageBox.Show(strErro);
            return Ok;

        }
       
        
        //public void     Estornar(ModeloVenda venda)
        //{

        //}
        //public void     Estornar(int id_venda)
        //{

        //}


    }
}
