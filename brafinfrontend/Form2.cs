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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            Thread t = new Thread(new ThreadStart(brafinfrontend1));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void brafinfrontend1()
        {
            Application.Run(new Form1());

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
