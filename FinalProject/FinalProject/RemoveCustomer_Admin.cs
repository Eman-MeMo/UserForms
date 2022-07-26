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
    public partial class RemoveCustomer_Admin : Form
    {
        public RemoveCustomer_Admin()
        {
            InitializeComponent();
        }

        private void RemoveCustomer_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.marketDataSet.CUSTOMER);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "insert into CUSTOMER (CUSTOMERNAME,CUSTOMERADDRESS,PASSWORD,TELEPHONE_NUM) values ('yomn','giza','123',145)";
            sqlCommand.CommandText = "DELETE FROM CUSTOMER WHERE CUSTOMERNAME = '" + textBox1.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The Customer has been deleted successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.marketDataSet.CUSTOMER);

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
