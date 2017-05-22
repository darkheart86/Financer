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

namespace GUI
{
    public partial class FormRelatorioEstoque : Form
    {
        ControleCompra ctrCompra = new ControleCompra();
        ControleEstoque ctrEstoque = new ControleEstoque();

        public FormRelatorioEstoque()
        {
            InitializeComponent();
        }

        

      

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            ctrEstoque.Listar(dataGridView);
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
