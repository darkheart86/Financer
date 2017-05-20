using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    
    public partial class form0Login : Form
    {
        
        public form0Login()
        {
            InitializeComponent();

            


            // Set no .text
            textBox2.Text = "";
            // a senha se torna asteriscos
            textBox2.PasswordChar = '*';
            // senha com 14 caracters
            textBox2.MaxLength = 14;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == ("admin")){
                
                if (textBox2.Text == ("admin"))
                {
                    // form principal aparece e o de login some
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("A senha esta incorreta");
                }
               
            }
            else
            {
                MessageBox.Show("O usuário esta incorreto");
            }

            

        }

        private void form0Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
