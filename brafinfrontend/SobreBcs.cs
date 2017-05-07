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
    public partial class SobreBcs : Form
    {
        Thread th;
        public SobreBcs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.MTA);
            th.Start();
        }
        public void opennewform(object obj)
        {
            Application.Run(new Form1());
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
