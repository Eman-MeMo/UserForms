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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name, user_password;
            user_name = textBox1.Text;
            user_password = textBox2.Text;

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog= market;Integrated Security=True"); ;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();


            SqlDataReader datareader;

            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("No checkbox selected");
                return;
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("You Must Select one of them, Not All");
                return;
            }

            if (checkBox1.Checked == true)
            {
                String query = "select * from ADMIN where" + "'" + user_name + "'" + "= ADMINNAME and " + "'" + user_password + "'" + " = PASSWWORD ";

                sqlCommand = new SqlCommand(query, sqlConnection);
                datareader = sqlCommand.ExecuteReader();
                if (datareader.Read())
                {
                    MessageBox.Show("LOGIN Successfly");
                    AddProduct add = new AddProduct();
                    add.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("You Must SIGN UP First, Please");
                }
            }

            if (checkBox2.Checked == true)
            {
                String query = "select * from CUSTOMER where " + "'" + user_name + "'" + " = CUSTOMERNAME and " + "'" + user_password + "'" + " = PASSWORD ";

                sqlCommand = new SqlCommand(query, sqlConnection);
                datareader = sqlCommand.ExecuteReader();
                if (datareader.Read())
                {
                    MessageBox.Show("LOGIN Successfly");
                    UpdateCustomer_Customer add = new UpdateCustomer_Customer();
                    add.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You Must SIGN UP First, Please");
                }
            }
            sqlConnection.Close();
        }
    }
}
