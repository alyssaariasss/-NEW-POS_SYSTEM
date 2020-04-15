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
    public partial class viewcart : Form
    {
        public viewcart()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkout co = new checkout();
            co.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.datelabel.Text = datetime.ToString();
        }

        private void viewcart_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
