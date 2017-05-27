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
    public partial class frmRelVendas : Form
    {
        ControleVenda ctrVenda = new ControleVenda();

        public frmRelVendas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaCompras_Load(object sender, EventArgs e)
        {

        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            if(dtpDataInicial.Text != "" && dtpDataFinal.Text != "" )
            {
                try
                {
                    ctrVenda.ListarVendas(dtpDataInicial.Text, dtpDataFinal.Text,0,dataGridView);
                }
                catch
                { }

            }
           
        }

        private void frmRelCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) this.cmdPesquisar_Click(sender, e);
            //if (e.KeyChar == (char)27) txtEmpresa.Clear();
        }
    }
}
