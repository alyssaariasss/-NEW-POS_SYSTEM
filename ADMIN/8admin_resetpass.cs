﻿using System;
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
    public partial class resetpass : Form
    {
        public resetpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password successfully changed!");
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Close();
        }
    }
}
