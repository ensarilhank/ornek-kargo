using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       


        private void Form1_Load(object sender, EventArgs e)
        {
            
            //KargoVer kargo = new KargoVer();
            //kargo.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string cevap=Interaction.InputBox("Türkiye'nin Başkenti Neresidir ?", "Robot Kontrol", "", 0, 0);
            if (cevap == "Ankara")
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          




            KargoVer kargover = new KargoVer();

            KargoVer.ad = textBox1.Text;
            KargoVer.gsm = textBox3.Text;
            KargoVer.tc = textBox2.Text;

            kargoVer1.Visible = true;
            kargoVer1.Show();            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void kargoVer1_Load(object sender, EventArgs e)
        {

        }

        private void kargoVer1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 kargomnerede = new Form2();
            kargomnerede.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 kurye = new Form1();
            kurye.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
