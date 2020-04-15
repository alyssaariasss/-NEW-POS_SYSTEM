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
    public partial class checkoutC : Form
    {
        public checkoutC()
        {
            InitializeComponent();
        }

        private void receiptbttn_Click(object sender, EventArgs e)
        {
            receiptC r = new receiptC();
            r.ShowDialog();
        }
    }
}
