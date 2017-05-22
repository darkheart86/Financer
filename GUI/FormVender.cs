using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;


namespace GUI
{
    public partial class FormVender : Form
    {
        ControleAcao ctrAcao = new ControleAcao();
        ControleCompra ctrCompra = new ControleCompra();
        ModeloCompra objCompra = new ModeloCompra();
        ModeloEstoque estoque = new ModeloEstoque();

        public FormVender()
        {
            InitializeComponent();
        }
       

        private void FormVender_Load(object sender, EventArgs e)
        {
            AtualizaForm();
        }

        #region Eventos do formulário



        private void cmdVender_Click(object sender, EventArgs e)
        {
            try
            {
                FormToModel(ctrCompra.DadosDaCompra);
                ctrCompra.Inserir();
                if (ctrCompra.DadosDaCompra.CodigoCompra != 0)
                {
                    MessageBox.Show("Compra " + ctrCompra.DadosDaCompra.CodigoCompra.ToString() + " realizada com sucesso!");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            AtualizaForm();

        }
        private void txtValorDaAcao_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            AtualizaPrecoTotal();
        }
        private void txtValorDaAcao_TextChanged_1(object sender, EventArgs e)
        {
            AtualizaPrecoTotal();
        }

        private void numQuantidade_ValueChanged_1(object sender, EventArgs e)
        {
            AtualizaPrecoTotal();
        }
        private void numQuantidade_Scroll_1(object sender, ScrollEventArgs e)
        {
            AtualizaPrecoTotal();
        }



        
        #endregion

        #region Metodos para manipulação do formulario
        private void AtualizaCombo()
        {
            ctrAcao.ListarAcoes(cmbAcao, 1);
            cmbAcao.SelectedIndex = -1;
        }

        private void AtualizaForm()
        {
            AtualizaCombo();
            this.numQuantidade.Value = 0;
            this.txtValorDaAcao.Text = "0";
            this.txtData.Text = DateTime.Now.ToShortDateString();
            AtualizaPrecoTotal();


        }
        private void FormToModel(ModeloCompra compra)
        {
            bool _acao = false, _vcompra = false, _qte = false;
            int acao, qte;
            float vcompra;

            if (cmbAcao.SelectedValue != null)
            {
                _acao = Int32.TryParse(cmbAcao.SelectedValue.ToString(), out acao);
            }
            else
            {
                _acao = false;
                acao = 0;
            }

            _vcompra = float.TryParse(txtBruto.Text, out vcompra);
            _qte = Int32.TryParse(numQuantidade.Value.ToString(), out qte);

            if (_acao && _vcompra && _qte)
            {
                compra.Data = txtData.Text;
                compra.CodigoAcao = acao;
                compra.ValorCompra = vcompra;
                compra.Quantidade = qte;
            }
            else
            {
                compra.Clear();
            }

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









        #endregion

        private void txtIR_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
