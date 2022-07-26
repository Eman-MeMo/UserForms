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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.marketDataSet.CUSTOMER);

        }

        private void Save_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog= market;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "insert into CUSTOMER values('" + CustomerName.Text + "','" + CustomerAddress.Text + "','" + CustomerPass.Text + "','0','" + CTelep.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("The Customer Account has been created successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.marketDataSet.CUSTOMER);

        }
    }
}
