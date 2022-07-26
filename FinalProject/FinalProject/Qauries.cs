using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Qauries : Form
    {
        public Qauries()
        {
            InitializeComponent();
        }

        private void Qauries_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            UpdateCustomer_Admin add = new UpdateCustomer_Admin();
            add.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RemoveCustomer_Admin add = new RemoveCustomer_Admin();
            add.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            AddProduct add = new AddProduct();
            add.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RemoveProduct add = new RemoveProduct();
            add.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateProduct add = new UpdateProduct();
            add.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Qauries add = new Qauries();
            add.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter x = new SqlDataAdapter("select Distinct product.PRODUCTNAME from PRODUCT left join purchase on product.productid = purchase.productid where PRODUCT.PRODUCTID  not in (select purchase.PRODUCTID from purchase where month(PURCHASE.TDATE) =  " + textBox1.Text + "and year(PURCHASE.TDATE) = year(GETDATE()))", sqlConnection);
            DataTable y = new DataTable();
            x.Fill(y);
            dataGridView1.DataSource = y;
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter x = new SqlDataAdapter("select PRODUCT.PRODUCTNAME,COUNT(PURCHASE.PRODUCTID) AS COUNTER FROM PURCHASE INNER JOIN PRODUCT ON PURCHASE.PRODUCTID = PRODUCT.PRODUCTID group by PURCHASE.PRODUCTID, PRODUCT.PRODUCTNAME HAVING  COUNT(PURCHASE.PRODUCTID) >= ALL(select COUNT(PURCHASE.PRODUCTID) FROM PURCHASE group by PURCHASE.PRODUCTID)", sqlConnection);
            DataTable y = new DataTable();
            x.Fill(y);
            dataGridView1.DataSource = y;
            sqlConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter x = new SqlDataAdapter("SELECT distinct CATEGORYNAME From PRODUCT, CATEGORY where CATEGORY.CATEGORYID = (select PRODUCT.CATEGORYID from PRODUCT where PRODUCT.PRODUCTID = ( SELECT max(PURCHASE.PRODUCTID) FROM PURCHASE )); ", sqlConnection);
            DataTable y = new DataTable();
            x.Fill(y);
            dataGridView1.DataSource = y;
            sqlConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True"); ;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            string sql = "select PRODUCTNAME, (PRODUCT.PRODUCTID) ,CATEGORYID,PRODUCTPRICE,QUANTITY,COUNT(PURCHASE.PRODUCTID) AS Byers from CUSTOMER , PURCHASE, PRODUCT where CUSTOMER.CUSTOMERNAME = PURCHASE.CUSTOMERNAME and PURCHASE.PRODUCTID = PRODUCT.PRODUCTID group by PRODUCT.PRODUCTID,CATEGORYID,PRODUCTPRICE,QUANTITY,PRODUCTNAME ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter x = new SqlDataAdapter("select distinct CUSTOMER.CUSTOMERNAME from CUSTOMER left join purchase on CUSTOMER.CUSTOMERNAME = purchase.CUSTOMERNAME where CUSTOMER.CUSTOMERNAME  not in (select purchase.CUSTOMERNAME from purchase where year(PURCHASE.TDATE) = year(GETDATE()) - 1)", sqlConnection);
            DataTable y = new DataTable();
            x.Fill(y);
            dataGridView1.DataSource = y;
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter x = new SqlDataAdapter("SELECT TOP 1 CUSTOMERNAME, COUNT(CUSTOMERNAME) AS HIGHESTPURCHASE FROM PURCHASE WHERE YEAR(TDATE) * 12 + MONTH(TDATE) = YEAR(GETDATE()) * 12 + MONTH(GETDATE()) GROUP BY CUSTOMERNAME ORDER BY HIGHESTPURCHASE desc", sqlConnection);
            DataTable y = new DataTable();
            x.Fill(y);
            dataGridView1.DataSource = y;
            sqlConnection.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Shows add = new Shows();
            add.Show();
            this.Hide();
        }
    }
}
