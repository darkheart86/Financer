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
        ControleCompra ctrCompra = new ControleCompra();
        ControleVenda ctrVenda = new ControleVenda();
        ControleEstoque crtEstoque = new ControleEstoque();

        ModeloCompra objCompra = new ModeloCompra();
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

        private void cmdVender_Click(object sender, EventArgs e)
        {
            ShowModelo();
            ctrVenda.Inserir();
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

        private void cmbAcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAcao=0;
            bool _acao;
            if (cmbAcao.SelectedValue != null)
            {
                _acao = Int32.TryParse(cmbAcao.SelectedValue.ToString(), out idAcao);
            }

            ctrVenda.DadosDaVenda.CodigoAcao = idAcao;
            ExibeValorMedio();
            ExibeQteEstoque();
        }
        private void txtValorDaAcao_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizaPrecoTotal();
        }
        private void txtValorDaAcao_TextChanged(object sender, EventArgs e)
        {
            if (txtValorDaAcao.Text == "") txtValorDaAcao.Text = "0";
            AtualizaPrecoTotal();
        }
        private void txtIR_KeyPress(object sender, KeyPressEventArgs e)
        {            
            DefineIR();
            ExibirIRCalculado();
            ExibirValorLiquido();
        }
        private void txtIR_TextChanged(object sender, EventArgs e)
        {
            if (txtIR.Text == "") txtIR.Text = "0";
            DefineIR();
            ExibirIRCalculado();
            ExibirValorLiquido();
        }
        private void txtBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrVenda.DadosDaVenda.ValorVendaBruta = float.Parse(txtBruto.Text);
        }
        private void txtBruto_TextChanged(object sender, EventArgs e)
        {
            ctrVenda.DadosDaVenda.ValorVendaBruta = float.Parse(txtBruto.Text);
            DefineIR();
            ExibirIRCalculado();
            ExibirValorLiquido();


        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            DefineQtde();
            AtualizaPrecoTotal();
        }
        private void numQuantidade_Scroll(object sender, ScrollEventArgs e)
        {
            DefineQtde(); 
            AtualizaPrecoTotal();
        }

        
        #endregion

        #region Metodos para manipulação do formulario
        private void AtualizaCombo()
        {
            ctrAcao.ListarAcoes(cmbAcao, 1);
            cmbAcao.SelectedIndex = -1;
        }
        
        private void LimpaForm()
        {
            AtualizaCombo();
            this.numQuantidade.Value = 0;
            this.txtValorDaAcao.Text = "0";
            this.txtData.Text = DateTime.Now.ToShortDateString();
            AtualizaPrecoTotal();
            DefineIR();
            ExibirIRCalculado();


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
        private void AtualizaPrecoTotal()
        {
            bool valor, qte;
            float valorAcao;
            int quantidade;

            valor = float.TryParse(txtValorDaAcao.Text, out valorAcao);
            qte = Int32.TryParse(numQuantidade.Value.ToString(), out quantidade);
            if (valor && qte)
            {
                this.txtBruto.Text = (valorAcao * quantidade).ToString();
            }
            else
            {
                this.txtBruto.Text = "0";
            }

        }
        private void AtualizaPrecoTotal(object sender, EventArgs e)
        {
            AtualizaPrecoTotal();
        }

       

        private void ExibeValorMedio()
        {
            int idAcao = ctrVenda.DadosDaVenda.CodigoAcao;
            float valorMedio;

            //MessageBox.Show("Exb: " + idAcao.ToString());
            if (idAcao > 0)
            {
                valorMedio = crtEstoque.ValorMedio(idAcao) *-1;
                if (valorMedio < 0) valorMedio = 0;
                txtValorMedio.Text = valorMedio.ToString();
                //MessageBox.Show(valorMedio.ToString());

            }
            else
            {
                txtValorMedio.Text = "0";
            }
             
                
        }
        private void ExibeQteEstoque()
        {
            int idAcao = ctrVenda.DadosDaVenda.CodigoAcao;
            int qteEstoque;
            if (idAcao > 0)
            {
                qteEstoque = crtEstoque.Quantidade(idAcao);
                numQuantidade.Maximum = qteEstoque;
                numQuantidade.Value = qteEstoque;
                //MessageBox.Show(valorMedio.ToString());

            }
            else
            {
                numQuantidade.Maximum = 0;
            }
        }
        private void DefineQtde()
        {
          
            int.TryParse(numQuantidade.Value.ToString(), out int quantidade);
            ctrVenda.DadosDaVenda.Quantidade = quantidade;

        }

        private void DefineIR()
        {
            int ir = 0;
            int.TryParse(txtIR.Text, out ir);
            ctrVenda.DadosDaVenda.PorcentagemIR = ir;

        }
        private void ExibirIRCalculado()
        {
            txtIrTotal.Text = ctrVenda.DadosDaVenda.IRCalculado.ToString();
        }
        private void ExibirValorLiquido()
        {
            txtLiquido.Text = ctrVenda.DadosDaVenda.ValorVendaLiquida.ToString();
        }
        private void ShowModelo()
        {
            ModeloVenda dv = ctrVenda.DadosDaVenda;
            string idacao = dv.CodigoAcao.ToString();
            string idvenda = dv.CodigoVenda.ToString();
            string data = dv.Data.ToString();
            string inativo = dv.Inativo.ToString();
            string ircalc = dv.IRCalculado.ToString();
            string lucrob = dv.LucroBruto.ToString();
            string lucrol = dv.LucroLiquido.ToString();
            string percir = dv.PorcentagemIR.ToString();
            string qte = dv.Quantidade.ToString();
            string vendab = dv.ValorVendaBruta.ToString();
            string vendal = dv.ValorVendaLiquida.ToString();

            string model = "\nacao: " + idacao +
                            "\nvenda: " + idvenda +
                            "\ndata: " + data +
                             "\nqte: " + qte +
                            "\nvendaB: " + vendab +
                            "\nvendaL: " + vendal +
                            "\nlucroB " + lucrob +
                            "\nlucrol" + lucrol +
                            "\nIR%: " + percir +
                            "\nIR calc:" + ircalc;

            MessageBox.Show(model);
        }










        #endregion

        private void txtValorMedio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
