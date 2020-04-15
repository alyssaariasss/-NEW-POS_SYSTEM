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
    public partial class resetpassC : Form
    {
        public resetpassC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password successfully changed!");
            this.Hide();
            Form7C f7 = new Form7C();
            f7.ShowDialog();
            this.Close();
        }
    }
}
