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
    public partial class Form4C : Form
    {
        public Form4C()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }
    }
}
