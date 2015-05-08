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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
            
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            
            //Hides add box and clears all of the text boxes
            this.Hide();
            txtBoxFishName.Clear();
            txtBoxLocation.Clear();
            txtBoxPrice.Clear();
            txtBoxQuantity.Clear();
            txtBoxSerial.Clear();
            Form2 secondForm = new Form2();
            secondForm.Show();
            

            
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string file_name = "C:\\Users\\har0051\\Documents\\Visual Studio 2013\\Projects\\SAT2\\Stock.txt";
            /* Code that Verifies that Price, Quantity and Serial are Ints and that Fish Name and Location
               Contain Text */
            int proceed = 1;
            int pass;
            int pass2;
            int pass3;
            bool txtBoxPriceVerified = int.TryParse(txtBoxPrice.Text,out pass);
            bool txtBoxQuantityVerified = int.TryParse(txtBoxQuantity.Text,out pass2);
            bool txtBoxSerialVerifed = int.TryParse(txtBoxSerial.Text, out pass3);
           
            if (txtBoxPriceVerified == false)
            {
                MessageBox.Show("Error!, Price must be a Number");
                proceed = 0;
            }
            else { }
            if (txtBoxQuantityVerified == false)
            {
                MessageBox.Show("Error!, Quantity must be a Number");
                proceed = 0;
            }
            else { }
            if (txtBoxSerialVerifed == false)
            {
                MessageBox.Show("Error!, Serial must be a Number");
                proceed = 0;
            }
            else { }
            if (string.IsNullOrWhiteSpace(txtBoxFishName.Text))
            {
                MessageBox.Show("Error!, Please Enter Fish Name");
                proceed = 0;
            }
            else { }
            if (string.IsNullOrWhiteSpace(txtBoxLocation.Text))
            {
                MessageBox.Show("Error!, Please Enter Location");
                proceed = 0;
            }

            if (proceed == 1)
            {
                System.IO.StreamWriter file;
                file = new System.IO.StreamWriter(file_name, true);

                //saves text from textbox ToolBar to file
                file.Write(Environment.NewLine + txtBoxFishName.Text + ":");
                file.Write(txtBoxLocation.Text + ":");
                file.Write(txtBoxPrice.Text + ":");
                file.Write(txtBoxQuantity.Text + ":");
                file.Write(txtBoxSerial.Text);
                file.Close();

                //clears all of the text boxes
                
                txtBoxFishName.Clear();
                txtBoxLocation.Clear();
                txtBoxPrice.Clear();
                txtBoxQuantity.Clear();
                txtBoxSerial.Clear();

                //Refreshs the Database
                //var mainform = Application.OpenForms.OfType<Form2>().Single();
                //mainform.Refresh();

                //Asks the user if they would like to add another item to the database
                DialogResult dialog1 = MessageBox.Show("Item Added to Database" + Environment.NewLine + "Want to add another?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog1 == DialogResult.No)
                {   //Hides this form and Reopens form 2
                    this.Hide();
                    Form2 secondForm = new Form2();
                    secondForm.Show();
                }
                    


                
                
            }
            else { }

            


        }

       
    }
}
