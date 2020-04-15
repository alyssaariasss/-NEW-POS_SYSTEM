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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _1manager f8 = new _1manager();
            f8.ShowDialog();
            this.Close();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2cashier f9 = new _2cashier();
            f9.ShowDialog();
            this.Close();
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _3slsassociate f10 = new _3slsassociate();
            f10.ShowDialog();
            this.Close();
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _4delclerk f11 = new _4delclerk();
            f11.ShowDialog();
            this.Close();
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            _5janitress f12 = new _5janitress();
            f12.ShowDialog();
            this.Close();
        }

        private void circularButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            _6janitor f13 = new _6janitor();
            f13.ShowDialog();
            this.Close();
        }
    }
}
