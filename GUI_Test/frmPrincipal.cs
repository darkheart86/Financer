using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Test
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
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
    }
}
