using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace brafinfrontend
{
    public partial class Form1 : Form
    {
        Thread th;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;
        Thread th5;
        Thread th13;
        Thread th6;
        Thread th7;
        Thread th8;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th8 = new Thread(opennewform8);
            th8.SetApartmentState(ApartmentState.MTA);
            th8.Start();
            
        }
        private void opennewform8 (object obj)
        {
            Application.Run(new Estoque());
        
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th2 = new Thread(opennewform);
            th2.SetApartmentState(ApartmentState.MTA);
            th2.Start();
            
        }
        private void opennewform (object obj)
        {
            Application.Run(new Compra());
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.MTA);
            th.Start();
        }
        public void opennewform1 (object obj)
        {
            Application.Run(new Venda());
        }

        private void sobreNósToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th13 = new Thread(opennewform13);
            th13.SetApartmentState(ApartmentState.MTA);
            th13.Start();
        }
        private void opennewform13(object obj)
        {
            Application.Run(new SobreBcs());
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th3 = new Thread(opennewform2);
            th3.SetApartmentState(ApartmentState.MTA);
            th3.Start();

        }
        private void opennewform2(object obj)
        {
        Application.Run(new Cadastro());
        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th4 = new Thread(opennewform2);
            th4.SetApartmentState(ApartmentState.MTA);
            th4.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        class RoundedButton : Form
        {
            GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f; GraphicsPath GraphPath = new GraphicsPath(); GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90); GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y); GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90); GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2); GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90); GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height); GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90); GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2); GraphPath.CloseFigure(); return GraphPath;
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e); RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height); GraphicsPath GraphPath = GetRoundPath(Rect, 1); this.Region = new Region(GraphPath); using (Pen pen = new Pen(Color.CadetBlue, 1.75f)) { pen.Alignment = PenAlignment.Inset; e.Graphics.DrawPath(pen, GraphPath); }
            }
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th5 = new Thread(opennewform4);
            th5.SetApartmentState(ApartmentState.MTA);
            th5.Start();
        }
        private void opennewform4(object obj)
        {
            Application.Run(new Form3());
        }

        private void vendaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            th6 = new Thread(opennewform6);
            th6.SetApartmentState(ApartmentState.MTA);
            th6.Start();
        }
        private void opennewform6(object obj)
        {
            Application.Run(new RelatorioVenda());
        }

        private void compraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            th7 = new Thread(opennewform7);
            th7.SetApartmentState(ApartmentState.MTA);
            th7.Start();

        }
        private void opennewform7(object obj)
        {
            Application.Run(new RelatorioCompra());
        }

    }
}
