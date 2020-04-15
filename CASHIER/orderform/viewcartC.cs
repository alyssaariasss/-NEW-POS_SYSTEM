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
    public partial class viewcartC : Form
    {
        public viewcartC()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.datelabel.Text = datetime.ToString();
        }

        private void viewcartC_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void paybttn_Click(object sender, EventArgs e)
        {
            checkoutC co = new checkoutC();
            co.ShowDialog();
            this.Close();
        }
    }
}
