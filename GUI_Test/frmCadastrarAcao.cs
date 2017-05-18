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
    public partial class frmCadastrarAcao : Form
    {
        ControleAcao ctrlAcao = new ControleAcao();

        public frmCadastrarAcao()
        {
            InitializeComponent();
        }

        private void frmCadastrarAcao_Load(object sender, EventArgs e)
        {

        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            ControleAcao acao = new ControleAcao();
            acao.NomeEmpresa = txtEmpresa.Text;
            try
            {
                acao.Inserir(acao);
                MessageBox.Show("Ação " + acao.CodigoAcao.ToString() + " cadastrada com sucesso!");
                lblID.Text = acao.CodigoAcao.ToString();
                //txtEmpresa.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                txtEmpresa.Clear();
                lblID.Text = "ID";
            }

           
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) this.cmdCadastrar_Click(sender, e);
            if (e.KeyChar == (char)27) txtEmpresa.Clear();
        }
    }
}
