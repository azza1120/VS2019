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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            onLoad();

        }

        private void onLoad()
        {
            int index = Form2.lb.SelectedIndex;
            String name;
            String location;
            int quantity;
            float price;
            int serial;

            name = Form2.lb.Items[index].Split(':')[0];
            location = Form2.lb.Items[index].Split(':')[1];
            quantity = int.Parse(Form2.lb.Items[index].Split(':')[3]);
            price = float.Parse(items[index].Split(':')[2]);
            serial = int.Parse(items[index].Split(':')[4]);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //ADD CODE HERE TO SAVE CHANGES AND DELETE OLD ENTRY
        }
    }
}
