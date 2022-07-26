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
    public partial class RemoveCustomer_Customer : Form
    {
        public RemoveCustomer_Customer()
        {
            InitializeComponent();
        }

        private void RemoveCustomer_Customer_Load(object sender, EventArgs e)
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
            UpdateCustomer_Customer add = new UpdateCustomer_Customer();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveCustomer_Customer add = new RemoveCustomer_Customer();
            add.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
