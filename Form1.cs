namespace Lesso3._1
{
    public partial class Form1 : Form
    {
        public  string productName { get; set; }

        public  string originCountry { get; set; }

        public  string productCost { get; set; }
        public Form1(string name,string country, string cost)
        {
            InitializeComponent();
            this.productName = name;
            MessageBox.Show("Test");
            MessageBox.Show("Test");
            MessageBox.Show("Test");
            MessageBox.Show("Test");
            MessageBox.Show("Test");
            this.originCountry = country;
            this.productCost = cost;
            listform1.Items.Add(name);
            listform1.Items.Add(country);
            listform1.Items.Add(cost);
        }

        private void editproduct_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            var itemss = "";
            if (listform1.SelectedItem != frm.product_name.Text && listform1.SelectedItem != frm.product_cost.Text && listform1.SelectedItem != frm.origin_country.Text) { 
            
                listform1.SelectedItems.Clear();
                listform1.Items.Add(frm.product_name.Text);
            
            
            
            }
        }

        private void removeproduct_Click(object sender, EventArgs e)
        {
            listform1.Items.Remove(listform1.SelectedItem);
        }
    }
}