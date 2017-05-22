using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace GUI
{
    public partial class FormAtualizar : Form
    {
        ModeloAcao objAcao = new ModeloAcao();
        ControleAcao controleAcao = new ControleAcao();

        public FormAtualizar()
        {
            InitializeComponent();
        }


        private void FormAtualizar_Load(object sender, EventArgs e)
        {
            AtualizaCombo();
        }



        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            ControleAcao ctrl = controleAcao;

            if (txtCodigoAcao.Text != "0" & txtCodigoAcao.Text != "")
            {
                objAcao.CodigoAcao = Int32.Parse(txtCodigoAcao.Text);
                objAcao.NomeEmpresa = txtNomeAcao.Text;
                objAcao.Inativo = chkInativo.Checked;

                try
                {
                    ctrl.AtualizarAcao(objAcao, true);
                    MessageBox.Show("Ação ID " + objAcao.CodigoAcao.ToString() + " foi atualizada!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                AtualizaCombo();
            }
        }


        private void cmbAcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControleAcao ctrlAcao = new ControleAcao();
            int fid = 0;
            bool parseOK = false;

            //Tenta converter o VALOR selecionao em cmbAcoes para inteiro e atribui o valor em fid
            if (cmbAcoes.SelectedIndex != -1)
            {
                parseOK = Int32.TryParse(cmbAcoes.SelectedValue.ToString(), out fid);
            }

            //Se a conversao funcionar atualiza os campos do formulario...
            if (parseOK)
            {

                objAcao = ctrlAcao.BuscarAcao(fid);

                txtCodigoAcao.Text = objAcao.CodigoAcao.ToString();
                txtNomeAcao.Text = objAcao.NomeEmpresa;
                chkInativo.Checked = objAcao.Inativo;

            }
            // Senão limpa os campos
            else
            {
                LimpaForm();
            }
        }
        private void LimpaForm()
        {
            txtCodigoAcao.Text = "";
            txtNomeAcao.Text = "";
            chkInativo.Checked = false;
        }



        private void AtualizaCombo()
        {

            controleAcao.ListarAcoes(cmbAcoes, 0);
            cmbAcoes.SelectedIndex = -1;
        }

        private void txtCodigoAcao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeAcao_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
    }

