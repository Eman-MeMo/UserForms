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
    public partial class Show2 : Form
    {
        public Show2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-P876LA1\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM PRODUCT WHERE QUANTITY < 100", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void Show2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.marketDataSet.PRODUCT);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shows add = new Shows();
            add.Show();
            this.Hide();
        }
    }
}
