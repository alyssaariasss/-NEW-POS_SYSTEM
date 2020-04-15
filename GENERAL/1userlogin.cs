using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;

            if (user == "admin" && pass == "12345")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }

            else if (user == "cashier" && pass == "12345")
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
