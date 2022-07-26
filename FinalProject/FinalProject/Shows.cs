using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Shows : Form
    {
        public Shows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show1 add = new Show1();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show2 add = new Show2();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show3 add = new Show3();
            add.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
            this.Hide();
        }
    }
}
