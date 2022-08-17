using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesso3._1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void canselbtn_Click(object sender, EventArgs e)
        {
            product_cost.Text = "";
            product_name.Text = "";
            origin_country.Text = "";
            
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(product_name.Text,product_cost.Text,origin_country.Text);
            frm.Text = product_name.Text;
            frm.Text = product_cost.Text;
            frm.Text = origin_country.Text;
            frm.ShowDialog();

        }
    }
}
