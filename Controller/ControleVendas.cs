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
                strCmd = "SELECT A.LANCAMENTO_COMPRA AS 'ID Venda', A.DATA_COMPRA as 'Data',A.ACAO as 'Ação' ,B.EMPRESA as 'Empresa',A.QUANTIDADE as 'Qtde', A.VALOR_COMPRA as 'Total' FROM COMPRAS A JOIN ACOES B ON A.ACAO = B.ID_ACAO where DATA_COMPRA > @dataInicial and DATA_COMPRA<@dataFinal";
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
        public void         ListarVendas(string dataInicial, string dataFinal, int codigoDaAcao, DataGridView objetoAlvo)
        {
            DataSet ds = new DataSet();
                        
            ds = this.ListarVendas(dataInicial, dataFinal);
            float precoTotal =float.Parse(ds.Tables[0].Compute("Sum(Total)", "").ToString());
            int qtdeTotal = int.Parse(ds.Tables[0].Compute("Sum(Qtde)", "").ToString());

            ds.Tables[0].Rows.Add(null, null, null,"Total", qtdeTotal, precoTotal);

            objetoAlvo.DataSource = ds;
            objetoAlvo.DataMember = ds.Tables[0].TableName;
            //MessageBox.Show(precoTotal.ToString());
            objetoAlvo.Rows[objetoAlvo.Rows.Count - 1].DefaultCellStyle = Estilos.LinhaFinal;




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
