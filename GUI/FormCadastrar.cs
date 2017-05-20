using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace GUI
{
    public partial class FormCadastrar : Form
    {
        ControleAcao ctrlAcao = new ControleAcao();
        public FormCadastrar()
        {
            InitializeComponent();
        }
       
        private void lblACAO_Click(object sender, EventArgs e)
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
                txtEmpresa.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            //lblID.Text = acao.CodigoAcao.ToString();

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtEmpresa.Text = "";
            txtEmpresa.Focus();
        }

      

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.cmdCadastrar.PerformClick();
            }
        }
    }
 }

