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

        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
