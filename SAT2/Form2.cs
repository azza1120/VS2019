using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SAT2
{
    public partial class Form2 : Form
    {
        private List<String> items = new List<String>();

        public Form2()
        {
            InitializeComponent();
            loadFromFile();

            foreach (String s in items)
            {
                String[] split = s.Split(':');
                listBox1.Items.Add(split[0]);

            }
        }


        public void loadFromFile()
        {

            string stock_location = "C:\\Users\\har0051\\Documents\\Visual Studio 2013\\Projects\\SAT2\\Stock.txt";
            foreach (String s in System.IO.File.ReadAllLines(stock_location))
            {
                items.Add(s);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            SearchTxtBox.Clear();
        }


        Form3 addForm = new Form3();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            //Changes the labels at the bottom to show the correct info for each item.
            if (items.Count > 0)
            {
                //Sets variables
                int index = listBox1.SelectedIndex;
                String name;
                String location;
                int quantity;
                float price;
                int serial;
                float pricepass;
                int quantitypass;
                int serialpass;
                int corrupt = 0;
                //SCRIPT TO PREVENT READ ERRORS
                bool priceverifer = float.TryParse(items[index].Split(':')[2], out pricepass);
                bool quantityverifer = int.TryParse(items[index].Split(':')[3], out quantitypass);
                bool serialverifer = int.TryParse(items[index].Split(':')[4], out serialpass);

                if (priceverifer == false)
                {
                    corrupt = 1;
                }
                else if (quantityverifer == false)
                {
                    corrupt = 1;
                }
                else if (serialverifer == false)
                {
                    corrupt = 1;
                }
                else if (string.IsNullOrWhiteSpace(items[index].Split(':')[0]))
                {
                    corrupt = 1;
                }
                else if (string.IsNullOrWhiteSpace(items[index].Split(':')[1]))
                {
                    corrupt = 1;
                }

                if (corrupt == 0)
                {
                    //Gets all of the Stock Information from stock.txt
                    
                    name = items[index].Split(':')[0];
                    location = items[index].Split(':')[1];
                    quantity = int.Parse(items[index].Split(':')[3]);
                    price = float.Parse(items[index].Split(':')[2]);
                    serial = int.Parse(items[index].Split(':')[4]);
                    //Code to be added
                    //String type = items[index].Split(':')[1];

                    //Sets all of the Labels to the correct Data.
                    StockLevelLabel.Text = quantity.ToString();
                    fishnamelabel.Text = name;
                    LocationLabel.Text = "Location: " + location;
                    PriceLabel.Text = price.ToString();
                    SerialNumberLabel.Text = "Serial no. " + serial.ToString();
                    //Code to be added
                    //typeLabel.Text = type;
                }
                else
                {
                    MessageBox.Show("Database Read Error!");


                }


            }
        }

        public void Refresh()
        {
            loadFromFile();
            //Broken Script
            //listBox1_SelectedIndexChanged(object sender, EventArgs e);



        }

        private void btnRemove_Click(object sender, EventArgs e)
{
    //Deletes item from text file "Stock"
            string FileName = "C:\\Users\\har0051\\Documents\\Visual Studio 2013\\Projects\\SAT2\\Stock.txt";
            int LineNumber = listBox1.SelectedIndex;

            if (!File.Exists(FileName))
            {
                throw new FileNotFoundException("File not found.", FileName);
            }
            if (LineNumber < 0)
            {
                MessageBox.Show("Please select item.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Acts as last resort beofre perminally deleting item.
                DialogResult dialog1 = MessageBox.Show("Are you sure you want to permanently delete item?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog1 == DialogResult.Yes)
                {
                    List<string> lst = File.ReadAllLines(FileName).ToList();
                    lst.RemoveAt(LineNumber);
                    File.WriteAllLines(FileName, lst.ToArray());
                    //opens stock form - acts as a refresher.
                    Form2 NO = new Form2();
                    NO.Show();
                    this.Hide(); 
                }
                else 
                {
                }
            }

        }
    }
}




        //}



