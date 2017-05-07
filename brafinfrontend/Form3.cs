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
    public partial class Form3 : Form
    {
        Thread th6;

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th6 = new Thread(opennewform5);
            th6.SetApartmentState(ApartmentState.MTA);
            th6.Start();
        }
        public void opennewform5 (object obj)
            {
                Application.Run(new Usuario());
        }
    }
}
