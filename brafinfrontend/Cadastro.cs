using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace brafinfrontend
{
    
    public partial class Cadastro : Form
    {
        Thread th7;
        Thread th8;
        Thread th11;
        Thread th12;
        Thread th13;
        Thread th14;
        Thread th15;
        Thread th16;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th8 = new Thread(opennewform7);
            th8.SetApartmentState(ApartmentState.MTA);
            th8.Start();
        }
        public void opennewform7(object obj)
        {
            Application.Run(new Compra());
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th11 = new Thread(opennewform11);
            th11.SetApartmentState(ApartmentState.MTA);
            th11.Start();
        }
        public void opennewform11(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th12 = new Thread(opennewform12);
            th12.SetApartmentState(ApartmentState.MTA);
            th12.Start();
        }
        public void opennewform12(object obj)
        {
            Application.Run(new Venda());
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             this.Close();
            th13 = new Thread(opennewform13);
            th13.SetApartmentState(ApartmentState.MTA);
            th13.Start();
        }
        public void opennewform13(object obj)
        {
            Application.Run(new RelatorioCompra());
       
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Close();
            th14 = new Thread(opennewform14);
            th14.SetApartmentState(ApartmentState.MTA);
            th14.Start();
        }
        public void opennewform14(object obj)
        {
            Application.Run(new RelatorioVenda());
       
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th15 = new Thread(opennewform15);
            th15.SetApartmentState(ApartmentState.MTA);
            th15.Start();
        }
        public void opennewform15(object obj)
        {
            Application.Run(new SobreBcs());
       
       
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th16 = new Thread(opennewform16);
            th16.SetApartmentState(ApartmentState.MTA);
            th16.Start();
        }
        public void opennewform16(object obj)
        {
            Application.Run(new Estoque());
       
        }
    }
}
