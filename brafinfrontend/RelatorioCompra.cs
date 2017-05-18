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
    public partial class RelatorioCompra : Form
    {
        Thread th;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;
        Thread th5;
        Thread th6;

        ControleCompra ctrCompra = new ControleCompra();

        public RelatorioCompra()
        {
            InitializeComponent();

        }
        private void RelatorioCompra_Load(object sender, EventArgs e)
        {
#if (DEBUG)
            txtDataFinal.Text = "01/01/2020";
            txtDataInicial.Text = "01/01/1900";
#endif
        }
#region Metodos do Menu Tool Strip
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th1 = new Thread(opennewform1);
            th1.SetApartmentState(ApartmentState.MTA);
            th1.Start();
        }
        public void opennewform1 (object obj)
        {
            Application.Run(new Compra());
        
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.MTA);
            th.Start();
        }
        public void opennewform (object obj)
        {
            Application.Run(new Cadastro());
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th2 = new Thread(opennewform2);
            th2.SetApartmentState(ApartmentState.MTA);
            th2.Start();
        }
        public void opennewform2 (object obj)
        {
            Application.Run(new Venda());
        
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th3 = new Thread(opennewform3);
            th3.SetApartmentState(ApartmentState.MTA);
            th3.Start();
        }
        public void opennewform3 (object obj)
        {
            Application.Run(new RelatorioCompra());
        
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th4 = new Thread(opennewform4);
            th4.SetApartmentState(ApartmentState.MTA);
            th4.Start();
        }
        public void opennewform4 (object obj)
        {
            Application.Run(new RelatorioVenda());
        
             
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th5 = new Thread(opennewform5);
            th5.SetApartmentState(ApartmentState.MTA);
            th5.Start();
        }
        public void opennewform5(object obj)
        {
            Application.Run(new Estoque());
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th6 = new Thread(opennewform6);
            th6.SetApartmentState(ApartmentState.MTA);
            th6.Start();
        }
        public void opennewform6(object obj)
        {
            Application.Run(new SobreBcs());
        }
#endregion
        
        private string Obterdata()
        {
            Point locatieCalender = new Point(150,150);
            MonthCalendar calender = new MonthCalendar();
            calender.Location = locatieCalender;
            calender.Show();
            calender.Visible = true;
            calender.BringToFront();
            calender.Parent = RelatorioCompra.ActiveForm;
            this.Controls.Add(calender);
            string date = calender.SelectionRange.Start.ToShortDateString();
            DateTime dateValue = DateTime.Parse(date);

            string dateForTextbox = dateValue.ToString("dd-MM-yyyy");
            calender.LostFocus += new System.EventHandler(this.ObterdataDispose);
            //calender.Hide();
            return dateForTextbox;
          }
        private void ObterdataDispose(object sender, EventArgs e)
        {
            MessageBox.Show("Lost Focus");
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            ctrCompra.ListarCompras(txtDataInicial.Text, txtDataFinal.Text, 0, dataGridView1);
        }
    }
}
