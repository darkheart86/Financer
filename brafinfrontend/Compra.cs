using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Model;
using Controller;

namespace brafinfrontend
{
    public partial class Compra : Form
    {
        Thread th4;
        Thread th6;
        Thread th7;
        Thread th8;
        Thread th9;
        Thread th10;
        Thread th11;
        Thread th12;
        Thread th13;

        ControleAcao ctrAcao = new ControleAcao();
        ControleCompra ctrCompra = new ControleCompra();
        ModeloCompra objCompra = new ModeloCompra();
        ModeloEstoque estoque = new ModeloEstoque();

        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            AtualizaForm();
        }

        #region Metodos dos Menus ToolStrip
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th7 = new Thread(opennewform6);
            th7.SetApartmentState(ApartmentState.MTA);
            th7.Start();
        }
        public void opennewform6(object obj)
        {
            Application.Run(new Form1());
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th4 = new Thread(opennewform4);
            th4.SetApartmentState(ApartmentState.MTA);
            th4.Start();
        }
        public void opennewform4(object obj)
        {
            Application.Run(new Venda());
        }
        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th6 = new Thread(opennewform5);
            th6.SetApartmentState(ApartmentState.MTA);
            th6.Start();
        }
        public void opennewform5(object obj)
        {
            Application.Run(new Cadastro());
        }
        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th8 = new Thread(opennewform8);
            th8.SetApartmentState(ApartmentState.MTA);
            th8.Start();
        }
        public void opennewform8(object obj)
        {
            Application.Run(new RelatorioCompra());

        }
        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th9 = new Thread(opennewform9);
            th9.SetApartmentState(ApartmentState.MTA);
            th9.Start();
        }
        public void opennewform9(object obj)
        {
            Application.Run(new RelatorioVenda());

        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th10 = new Thread(opennewform10);
            th10.SetApartmentState(ApartmentState.MTA);
            th10.Start();
        }
        public void opennewform10(object obj)
        {
            Application.Run(new Cadastro());


        }
        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th11 = new Thread(opennewform11);
            th11.SetApartmentState(ApartmentState.MTA);
            th11.Start();
        }
        public void opennewform11(object obj)
        {
            Application.Run(new Compra());

        }
        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th12 = new Thread(opennewform12);
            th12.SetApartmentState(ApartmentState.MTA);
            th12.Start();
        }
        public void opennewform12(object obj)
        {
            Application.Run(new Estoque());

        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th13 = new Thread(opennewform13);
            th13.SetApartmentState(ApartmentState.MTA);
            th13.Start();
        }
        public void opennewform13(object obj)
        {
            Application.Run(new SobreBcs());
        }
        #endregion

        #region Eventos do formulário
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  


        }
        private void cmdComprar_Click(object sender, EventArgs e)
        {
            
            try
            {
                FormToModel(ctrCompra.DadosDaCompra);
                ctrCompra.Inserir();
                MessageBox.Show("Compra " + ctrCompra.DadosDaCompra.CodigoCompra.ToString() + " realizada com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            AtualizaForm();


        }
        private void numQuantidade_ValueChanged(object sender, EventArgs e)
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
            this.txtValorDaAcao.Text = "";
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

            _vcompra = float.TryParse(txtValorDaCompra.Text, out vcompra);
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
                this.txtValorDaCompra.Text = (valorAcao * quantidade).ToString();
            }
            else
            {
                this.txtValorDaCompra.Text = "0";
            }
            
        }
        #endregion             
    }
}