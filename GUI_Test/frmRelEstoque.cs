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
    public partial class frmRelEstoque : Form
    {
        ControleCompra ctrCompra = new ControleCompra();
        ControleEstoque ctrEstoque = new ControleEstoque();

        public frmRelEstoque()
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
            ctrEstoque.Listar(dataGridView);
            //dataGridView.Rows[0].Frozen = true;
        }

        private void frmRelCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) this.cmdPesquisar_Click(sender, e);
            //if (e.KeyChar == (char)27) txtEmpresa.Clear();
        }

        private void gprControles_Enter(object sender, EventArgs e)
        {
            //chtEstoque.Titles.Add("Estoque");
            //chtEstoque.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            //chtEstoque.Series[0].Name = "Nova";
            //chtEstoque.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //chtEstoque.ChartAreas[0].Area3DStyle.Enable3D = true;

            //DataSet ds = ctrEstoque.Listar();
            //chtEstoque.DataSource = ds.Tables[0].TableName;
            //chtEstoque.Series[0].XValueMember = "Empresa";
            //chtEstoque.Series[0].YValueMembers = "Valor total";


        }
    }
}
