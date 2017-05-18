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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControleAcao acao = new ControleAcao();
            acao.ListarAcoes(listBox1);
            acao.ListarAcoes(comboBox1);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedValue.ToString();
            textBox2.Text = listBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = comboBox1.SelectedValue.ToString();
            textBox3.Text = comboBox1.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
