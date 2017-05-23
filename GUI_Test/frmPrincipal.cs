using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_Test
{
    public partial class frmPrincipal : Form
    {
        #region Custom Button
        public partial class CustomBorderForm : Form
        {
            const int WM_NCPAINT = 0x85;

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr GetWindowDC(IntPtr hwnd);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern void DisableProcessWindowsGhosting();

            [DllImport("UxTheme.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

            protected override void OnHandleCreated(EventArgs e)
            {
                SetWindowTheme(this.Handle, "", "");
                base.OnHandleCreated(e);
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                switch (m.Msg)
                {
                    case WM_NCPAINT:
                        {
                            IntPtr hdc = GetWindowDC(m.HWnd);
                            using (Graphics g = Graphics.FromHdc(hdc))
                            {
                                g.FillEllipse(Brushes.Red, new Rectangle((Width - 20) / 2, 8, 20, 20));
                            }
                            int r = ReleaseDC(m.HWnd, hdc);
                        }
                        break;
                }
            }
        }
        #endregion

        public frmPrincipal()
        {
            //DisableProcessWindowsGhosting();
            InitializeComponent();
        }
        private void mnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuAtualizarAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmAtualizaAcao"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmAtualizaAcao wAtualizaAcao = new frmAtualizaAcao(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wAtualizaAcao.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wAtualizaAcao.Show();
                }


            }
            catch { }
        }
        private void mnuCadastrarAcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmCadastrarAcao"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmCadastrarAcao wCadastrarAcao = new frmCadastrarAcao(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wCadastrarAcao.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wCadastrarAcao.Show();
                }


            }
            catch { }
        }
        private void mnuRelCompras_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmRelCompras"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmRelCompras wRelCompras = new frmRelCompras(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wRelCompras.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wRelCompras.Show();
                }
            }
            catch { }
        }
        private void mnuComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmComprar"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmComprar wfrmComprar = new frmComprar(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wfrmComprar.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wfrmComprar.Show();
                }
            }
            catch { }
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmMsgBox"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmMsgBox wSobre = new frmMsgBox(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wSobre.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wSobre.Show();
                }
            }
            catch { }
        }
        private void mnuEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmRelEstoque"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmRelEstoque wRelEstoque = new frmRelEstoque(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wRelEstoque.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wRelEstoque.Show();
                }
            }
            catch { }
        }
        private void cmnuCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);

        }
        private void cmnuMinimizarTodas_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                foreach (Form childForm in this.ParentForm.MdiChildren)
                {
                    childForm.WindowState = FormWindowState.Minimized;
                }

            }
        }
        private void mnuVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmVender"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmVender wVender = new frmVender(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wVender.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wVender.Show();
                }
            }
            catch { }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmThisIs"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmThisIs wfrmThisIs = new frmThisIs(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wfrmThisIs.TopMost = true;
                    wfrmThisIs.StartPosition = FormStartPosition.Manual;
                    wfrmThisIs.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - wfrmThisIs.Width,
                                           Screen.PrimaryScreen.WorkingArea.Height - wfrmThisIs.Height);

                    

                    wfrmThisIs.Show();


                }
            }
            catch { }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void mnuVendas_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmRelVendas"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    frmRelVendas wRelVendas = new frmRelVendas(); //Cria novo objeto winConsultaAcoes baseado no frmConsultaAcoes
                    wRelVendas.MdiParent = this;
                    //wAtualizaAcao.WindowState = FormWindowState.Maximized;
                    wRelVendas.Show();
                }
            }
            catch { }
        }
    }
}
