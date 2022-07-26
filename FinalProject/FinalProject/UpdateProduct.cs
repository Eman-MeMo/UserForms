using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog= market;Integrated Security=True");
            SqlCommand Mycomand1 = new SqlCommand();
            SqlCommand Mycomand2 = new SqlCommand();
            SqlCommand Mycomand3 = new SqlCommand();
            SqlCommand Mycomand4 = new SqlCommand();
            Mycomand1.Connection = con;
            Mycomand2.Connection = con;
            Mycomand3.Connection = con;
            Mycomand4.Connection = con;
            con.Open();
            Mycomand1.CommandText = "update PRODUCT set PRODUCTNAME = N'" + textBox2.Text + "' Where PRODUCTID ='" + textBox1.Text + "'";
            Mycomand2.CommandText = "update PRODUCT set CATEGORYID = " + textBox3.Text + " Where PRODUCTID ='" + textBox1.Text + "'";
            Mycomand3.CommandText = "update PRODUCT set QUANTITY = " + textBox4.Text + " Where PRODUCTID ='" + textBox1.Text + "'";
            Mycomand4.CommandText = "update PRODUCT set PRODUCTPRICE = " + textBox5.Text + " Where PRODUCTID ='" + textBox1.Text + "'";


            Mycomand1.ExecuteNonQuery();
            Mycomand2.ExecuteNonQuery();
            Mycomand3.ExecuteNonQuery();
            Mycomand4.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Alhamdallah");
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.marketDataSet.PRODUCT);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.Fill(this.marketDataSet.PRODUCT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCustomer_Admin add = new UpdateCustomer_Admin();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveCustomer_Admin add = new RemoveCustomer_Admin();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveProduct add = new RemoveProduct();
            add.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateProduct add = new UpdateProduct();
            add.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Qauries add = new Qauries();
            add.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Shows add = new Shows();
            add.Show();
            this.Hide();
        }
    }
}
