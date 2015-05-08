using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            
            string username = txtBoxUsername.Text;
            string password = txtBoxPasword.Text;

            if (username == "staff" && password == "fish")
            {
                secondForm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Error, Invalid Username or Password");
            }


            
           
            

        }
    }
}
