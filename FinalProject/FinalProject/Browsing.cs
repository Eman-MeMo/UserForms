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
    public partial class Browsing : Form
    {
        public Browsing()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog= market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select PRODUCTNAME, PRODUCTPRICE, QUANTITY, CATEGORYNAME FROM PRODUCT, CATEGORY WHERE PRODUCT.CATEGORYID = CATEGORY.CATEGORYID  AND PRODUCTNAME = '" + name.Text + "'", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
