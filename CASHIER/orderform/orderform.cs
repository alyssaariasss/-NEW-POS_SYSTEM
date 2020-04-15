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
    public partial class orderform : Form
    {
        public orderform()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label7.Text = datetime.ToString();
        }

        private void orderform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void viewcartbttn_Click(object sender, EventArgs e)
        {
            viewcartC vc = new viewcartC();
            vc.ShowDialog();
        }

        private void paybttn_Click(object sender, EventArgs e)
        {
            checkoutC co = new checkoutC();
            co.ShowDialog();
        }
    }
}
