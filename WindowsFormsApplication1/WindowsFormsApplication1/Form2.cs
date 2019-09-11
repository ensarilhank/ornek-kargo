using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAB7-4;Initial Catalog=Yurtici_Kargo;User ID=sa;Password=123456");
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Gönderi Kodu") 
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Gönderi Kodu";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           this.WindowState= FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 kurye = new Form1();
            kurye.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 kargomnerede = new Form2();
            kargomnerede.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("");
        }
    }
}
