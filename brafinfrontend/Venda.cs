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
    public partial class Venda : Form
    {
        Thread th3;
        Thread th7;
        Thread th9;
        Thread th10;
        Thread th14;
        Thread th15;
        Thread th16;
        Thread th17;

        public Venda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th9 = new Thread(opennewform9);
            th9.SetApartmentState(ApartmentState.MTA);
            th9.Start();
        }
        private void opennewform9(object obj)
        {
            Application.Run(new Venda());

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th3 = new Thread(opennewform3);
            th3.SetApartmentState(ApartmentState.MTA);
            th3.Start();
        }
        private void opennewform3 (object obj)
    {
           Application.Run(new Compra());

    }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

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

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th14 = new Thread(opennewform14);
            th14.SetApartmentState(ApartmentState.MTA);
            th14.Start();
        }
        public void opennewform14(object obj)
        {
            Application.Run(new SobreBcs());

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th15 = new Thread(opennewform15);
            th15.SetApartmentState(ApartmentState.MTA);
            th15.Start();
        }
        public void opennewform15(object obj)
        {
            Application.Run(new RelatorioCompra());

                }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th16 = new Thread(opennewform16);
            th16.SetApartmentState(ApartmentState.MTA);
            th16.Start();
        }
        public void opennewform16(object obj)
        {
            Application.Run(new RelatorioVenda());

                
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th17 = new Thread(opennewform17);
            th17.SetApartmentState(ApartmentState.MTA);
            th17.Start();
        }
        public void opennewform17(object obj)
        {
            Application.Run(new Estoque());
        }
        
    }
}
