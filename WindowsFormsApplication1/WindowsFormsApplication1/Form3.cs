﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 kurye = new Form1();
            kurye.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 kargomnerede = new Form2();
            kargomnerede.Show();
        }
    }
}
