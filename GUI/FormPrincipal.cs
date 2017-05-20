using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }
      

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
               
            }
        }

        

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            FormCriadores fcriadores = new FormCriadores();
            fcriadores.MdiParent = this;
            fcriadores.Show();
            pictureFundo.Visible = false;
            pictureLogo.Visible = false;
        }

        

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            FormCadastrar fcadastrar = new FormCadastrar();
            fcadastrar.MdiParent = this;
            fcadastrar.Show();
            pictureFundo.Visible = false;
            pictureLogo.Visible = false;

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (Application.OpenForms["FormAtualizar"] == null) // Previne que crie mais de 1 instancia da mesma janela
                {
                    FormAtualizar fatualizar = new FormAtualizar();
                    fatualizar.MdiParent = this;
                    fatualizar.Show();
                    pictureFundo.Visible = false;
                    pictureLogo.Visible = false;
                }


            }
            catch { }
           
            
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            FormComprar fcomprar = new FormComprar();
            fcomprar.MdiParent = this;
            fcomprar.Show();
            pictureFundo.Visible = false;
            pictureLogo.Visible = false;
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            FormVender fvender = new FormVender();
            fvender.MdiParent = this;
            fvender.Show();
            pictureFundo.Visible = false;
            pictureLogo.Visible = false;

        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            FormCadastrar fcadastrar = new FormCadastrar();
            fcadastrar.MdiParent = this;
            fcadastrar.Show();
            pictureFundo.Visible = false;
            pictureLogo.Visible = false;
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            FormComprar fcomprar = new FormComprar();
            fcomprar.MdiParent = this;
            fcomprar.Show();
            pictureFundo.Visible = false;
            pictureLogo.Visible = false;
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja fechar o form atual?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                FecharFormulariosFilhos();
                FormVender fvender = new FormVender();
                fvender.MdiParent = this;
                fvender.Show();
                pictureFundo.Visible = false;
                pictureLogo.Visible = false;
            }
            else
            {

            }

            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o form atual?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                FecharFormulariosFilhos();
                FormRelatorioCompra frelatorio = new FormRelatorioCompra();
                frelatorio.MdiParent = this;
                frelatorio.Show();
                pictureFundo.Visible = false;
                pictureLogo.Visible = false;
            }
            else
            {

            }
        }
        
    }
}
