#define MEDIA_NORMAL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Controller;



namespace GUI_Test
{
    public partial class frmVender : Form
    {
        #region Global
        ControleAcao ctrAcao = new ControleAcao();
        //ControleCompra ctrCompra = new ControleCompra();
        ControleVenda ctrVenda = new ControleVenda();
        ControleEstoque ctrEstoque = new ControleEstoque();

        //ModeloCompra objCompra = new ModeloCompra();
        ModeloEstoque objEstoque = new ModeloEstoque();
        ModeloVenda objVenda = new ModeloVenda();
        #endregion

        #region Construct e EventLoad
        public frmVender()
        {
            InitializeComponent();
        }
        private void frmComprar_Load(object sender, EventArgs e)
        {
            LimpaForm();
        }
        #endregion

        #region Eventos do formulário


        private void cmbAcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefineDadosBasicosDaVenda();
            DefineValorDeVendaDaAcao();
            ExibeQteEstoque();
        }

        private void txtValorDaAcao_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumeros(sender, e);
        }
        private void txtValorDaAcao_TextChanged(object sender, EventArgs e)
        {
            DefineValorDeVendaDaAcao();
            ExibirTodos();
        }
        private void txtValorDaAcao_Leave(object sender, EventArgs e)
        {
            if (txtValorDaAcao.Text == "") txtValorDaAcao.Text = "0";
        }

        private void txtIR_KeyPress(object sender, KeyPressEventArgs e)
        {
            SomenteNumeros(sender, e);
        }
        private void txtIR_TextChanged(object sender, EventArgs e)
        {
            if (txtIR.Text == "") txtIR.Text = "0";
            DefineIR();
            
            ExibirTodos();
        }
             
        private void txtBruto_TextChanged(object sender, EventArgs e)
        {
            ////ctrVenda.DadosDaVenda.ValorVendaBruta = float.Parse(txtBruto.Text);
            //DefineIR();
            //ExibirIRCalculado();
            //ExibirVendaLiquida();


        }
        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            ctrVenda.DadosDaVenda.Data = txtData.Text;
        }


        private void cmdVender_Click(object sender, EventArgs e)
        {
            ShowModelo();
            ctrVenda.Inserir();
            LimpaForm();
        }
        private void cmdEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmRelEstoque"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmRelEstoque wRelEstoque = new frmRelEstoque(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wRelEstoque.MdiParent = this.ParentForm;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wRelEstoque.Show();
                }
            }
            catch { }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            DefineQtde();
            DefineValorMedioAcao();
            ExibirTodos();
           
            
            

        }
        private void numQuantidade_Scroll(object sender, ScrollEventArgs e)
        {
            DefineQtde();
            DefineValorMedioAcao();
            ExibirTodos();
            
        }

        #endregion

        #region Metodos para manipulação do formulario

        private void DefineDadosBasicosDaVenda()
        {
            /* Define os dados basico da venda:
             *          ID da acao
             *          Valor medio da acao
             */

            int idDaAcao = 0;
            bool _sucesso;

            // Trecho abaixo tenta converter o valor selecionado no cmbAcao para inteiro se o valor selecionado não for nulo
            if (cmbAcao.SelectedValue != null)
            {
                _sucesso = Int32.TryParse(cmbAcao.SelectedValue.ToString(), out idDaAcao);
            }

            ctrVenda.DadosDaVenda.CodigoAcao = idDaAcao;
            DefineValorMedioAcao();
        }
        private void DefineValorDeVendaDaAcao()
        {
            float ValorDeVendaDaAcao = 0;
            string txtValorDeVendaDaAcao = txtValorDaAcao.Text;

            bool _sucesso;

            // Trecho abaixo tenta converter o valor selecionado no txtValorDeVendaDaAcao para inteiro se o valor selecionado não for nulo
            if (txtValorDeVendaDaAcao !="")
            {
                _sucesso = float.TryParse(txtValorDeVendaDaAcao, out ValorDeVendaDaAcao);
            }
            
            ctrVenda.DadosDaVenda.ValorVendaAcao = ValorDeVendaDaAcao;
            DefineValorMedioAcao();
        }
        private void DefineQtde()
        {

            int.TryParse(numQuantidade.Value.ToString(), out int quantidade);
            ctrVenda.DadosDaVenda.Quantidade = quantidade;
            //ExibeValorMedio();

        }
        private void DefineIR()
        {
            float ir = 0;
            float.TryParse(txtIR.Text, out ir);
            ctrVenda.DadosDaVenda.PorcentagemIR = ir;

        }
        private void DefineValorMedioAcao()
        {
            int idDaAcao = ctrVenda.DadosDaVenda.CodigoAcao;

            //ctrVenda.DadosDaVenda.ValorMedioDeEstoque = ctrEstoque.ValorMedio(idDaAcao);


            if (ctrVenda.DadosDaVenda.Quantidade > 0)
            {
                ctrVenda.DadosDaVenda.ValorMedioDeEstoque = ctrEstoque.ValorAcumulado(idDaAcao) / ctrVenda.DadosDaVenda.Quantidade;
            }
            else
            {
                ctrVenda.DadosDaVenda.ValorMedioDeEstoque = 0;
            }

            ExibeValorMedio();
        }

        private void ExibirTodos()
        {
            ExibeValorMedio();
            ExibirIRCalculado();
            ExibirVendaLiquida();
            ExbirVendaBruta();
            ExibirLucro();
        }
        private void ExibeValorMedio()
        {
            string strValorMedioDaAcao = ctrVenda.DadosDaVenda.ValorMedioDeEstoque.ToString();
            txtValorMedio.Text = strValorMedioDaAcao;
            
                    //int idAcao = ctrVenda.DadosDaVenda.CodigoAcao;



                    ////MessageBox.Show("Exb: " + idAcao.ToString());
                    //if (idAcao > 0)
                    //{

                    //    txtValorMedio.Text = ctrEstoque.ValorMedio(idAcao).ToString();

                    //}
                    //else
                    //{
                    //    txtValorMedio.Text = "0";
                    //}

                    ////////////////////////////////////////////////////////
                    ////MessageBox.Show("Exb: " + idAcao.ToString());
                    //if (idAcao > 0)
                    //{
                    //    valorMedio = ctrEstoque.ValorMedio(idAcao) * -1;
                    //    if (valorMedio < 0) valorMedio = 0;
                    //    txtValorMedio.Text = valorMedio.ToString();
                    //    //MessageBox.Show(valorMedio.ToString());

                    //}
                    //else
                    //{
                    //    txtValorMedio.Text = "0";
                    //}


        }
        private void ExibeValorAcao()
        {
            txtValorDaAcao.Text = ctrVenda.DadosDaVenda.ValorVendaAcao.ToString();
        }
        private void ExibeQteEstoque()
        {
            int idAcao = ctrVenda.DadosDaVenda.CodigoAcao;
            int qteEstoque;
            if (idAcao > 0)
            {
                qteEstoque = ctrEstoque.Quantidade(idAcao);
                numQuantidade.Maximum = qteEstoque;
                numQuantidade.Value = qteEstoque;
                //MessageBox.Show(valorMedio.ToString());

            }
            else
            {
                numQuantidade.Maximum = 0;
            }
        }
        private void ExibirIRCalculado()
        {
            txtIrTotal.Text = ctrVenda.DadosDaVenda.IRCalculado.ToString();
        }
        private void ExibirVendaLiquida()
        {
            txtLiquido.Text = ctrVenda.DadosDaVenda.ValorVendaLiquida.ToString();
        }
        private void ExbirVendaBruta()
        {
            txtBruto.Text = ctrVenda.DadosDaVenda.ValorVendaBruta.ToString();
        }
        private void ExibirLucro()
        {
            txtLucro.Text = ctrVenda.DadosDaVenda.LucroLiquido.ToString();
        }

        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1) && ((sender as TextBox).TextLength > 0))
            {
                e.Handled = true;
            }
        }
        private void ShowModelo()
        {
            ModeloVenda dv = ctrVenda.DadosDaVenda;
            string idacao = dv.CodigoAcao.ToString();
            string idvenda = dv.CodigoVenda.ToString();
            string vacao = dv.ValorVendaAcao.ToString();
            string vendab = dv.ValorVendaBruta.ToString();
            string vendal = dv.ValorVendaLiquida.ToString();
            string lucrob = dv.LucroBruto.ToString();
            string lucrol = dv.LucroLiquido.ToString();
            string percir = dv.PorcentagemIR.ToString();
            string ircalc = dv.IRCalculado.ToString();
            string vacaoest = dv.ValorMedioDeEstoque.ToString();          
            string qte = dv.Quantidade.ToString();
            string data = dv.Data.ToString();
            string IVV = dv.IVV.ToString();
            string inativo = dv.Inativo.ToString();

            string model = "\n Código da ação: " + idacao +
                            "\n Código da venda: " + idvenda +
                            "\n Valor de venda da ação: " + vacao +
                            "\n Venda bruta: " + vendab +
                            "\n Venda liquida: " + vendal +
                            "\n Lucro Bruto: " + lucrob +
                            "\n Lucro Liquido: " + lucrol +
                            "\n IR%: " + percir +
                            "\n IR calculado:" + ircalc +
                            "\n Valor médio da ação:" +vacaoest+
                            "\nqte: " + qte +
                            "\ndata: " + data +
                            "\n Investimento na venda:"+IVV+
                            "\n Inativo: " + inativo;
                           
                           

            MessageBox.Show(model);
        }
        private void LimpaForm()
        {
            AtualizaCombo();
            ctrVenda.DadosDaVenda.Clear();
            ExibeValorAcao();
            ExibirTodos();
            //this.numQuantidade.Value = 0;
            //this.txtValorDaAcao.Text = "0";
            //this.txtData.Text = DateTime.Now.ToShortDateString();


        }
        private void AtualizaCombo()
        {
            ctrAcao.ListarAcoes(cmbAcao, 1);
            cmbAcao.SelectedIndex = -1;
        }
        private void FormToModel(ModeloVenda venda)
        {

            //bool _acao = false, _vcompra = false, _qte = false;
            //int acao, qte;
            //float vcompra;

            //if (cmbAcao.SelectedValue != null)
            //{
            //    _acao = Int32.TryParse(cmbAcao.SelectedValue.ToString(), out acao);
            //}
            //else
            //{
            //    _acao = false;
            //    acao = 0;
            //}

            //_vcompra = float.TryParse(txtBruto.Text, out vcompra);
            //_qte = Int32.TryParse(numQuantidade.Value.ToString(), out qte);

            //if (_acao && _vcompra && _qte)
            //{
            //    compra.Data = txtData.Text;
            //    compra.CodigoAcao = acao;
            //    compra.ValorCompra = vcompra;
            //    compra.Quantidade = qte;
            //}
            //else
            //{
            //    compra.Clear();
            //}

#region Teste

            //MessageBox.Show(
            //    "Acao: " + compra.CodigoAcao.ToString() + 
            //    "\nValor da compra: " + compra.ValorCompra.ToString() + 
            //    "\nQuantidade: "+compra.Quantidade.ToString()+
            //    "\nData: "+compra.Data.ToString()
            //    );

#endregion
        }






        #endregion

        private void grpVendas_MouseHover(object sender, EventArgs e)
        {
            ShowModelo();
        }
    }

}
