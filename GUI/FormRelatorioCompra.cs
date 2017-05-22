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
    public partial class FormRelatorioCompra : Form
    {
        ControleCompra ctrCompra = new ControleCompra();
        public FormRelatorioCompra()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaCompras_Load(object sender, EventArgs e)
        {

        }

        

        private void frmRelCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) this.cmdPesquisar_Click_1(sender, e);
            //if (e.KeyChar == (char)27) txtEmpresa.Clear();
        }

        private void cmdPesquisar_Click_1(object sender, EventArgs e)
        {
            if (dtpDataInicial.Text != "" && dtpDataFinal.Text != "")
            {
                try
                {
                    ctrCompra.ListarCompras(dtpDataInicial.Text, dtpDataFinal.Text, 0, dataGridView);
                }
                catch
                { }

            }
        }
    }
}
