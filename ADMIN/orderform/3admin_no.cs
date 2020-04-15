using System;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class _3admin_no : Form
    {
        public _3admin_no()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void viewcartbttn_Click(object sender, EventArgs e)
        {
            viewcart vc = new viewcart();
            vc.ShowDialog();
        }

        private void paybttn_Click(object sender, EventArgs e)
        {
            checkout co = new checkout();
            co.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label7.Text = datetime.ToString();
        }

        private void _3admin_no_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

