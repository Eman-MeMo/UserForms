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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn add = new SignIn();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp add = new SignUp();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Browsing add = new Browsing();
            add.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Qauries add = new Qauries();
            add.Show();
            this.Hide();
        }
    }
}
