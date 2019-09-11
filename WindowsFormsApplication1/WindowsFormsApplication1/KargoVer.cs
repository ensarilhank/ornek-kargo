using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class KargoVer : UserControl
    {
        public KargoVer()
        {
            InitializeComponent();
        }
        public static string ad;
        public static string gsm;
        public static string tc;
        SqlConnection con = new SqlConnection("Data Source=LAB7-4;Initial Catalog=Yurtici_Kargo;User ID=sa;Password=123456");
        int talep;
        int tip;
        string kurumsal;
        private void KargoVer_Load(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
     
            label1.Text = ad;
            label2.Text = gsm;
            label3.Text = tc;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {

            

            if (textBox6.Text == "Adresiniz")
            {
                textBox6.Text = " ";
                textBox6.ForeColor = Color.Black;
            }
            
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            
            if (textBox6.Text == " ")
            {
                textBox6.Text = "Adresiniz";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Bina Numarası")
            {
                textBox7.Text = " ";
                textBox7.ForeColor = Color.Black;
            }

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == " ")
            {
                textBox7.Text = "Bina Numarası";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Daire Numarası")
            {
                textBox9.Text = " ";
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if(textBox9.Text == " ")
            {
                textBox9.Text = "Daire Numarası";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Kat Numarası")
            {
                textBox8.Text = " ";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == " ")
            {
                textBox8.Text = "Kat Numarası";
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == " ")
            {
                textBox10.Text = "Apartman / Daire Adı";
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Apartman / Daire Adı")
            {
                textBox10.Text = " ";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            talep = 1;
            panel1.Visible = true;
           
                textBox1.Text = tc;
                textBox1.ForeColor = Color.Black;
                textBox2.Text = ad;
                textBox2.ForeColor = Color.Black;
                textBox4.Text = gsm;
                textBox4.ForeColor = Color.Black;
            
           
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Talep İleten TCKN")
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Black;
            }
            if (textBox1.Text == "Talep İleten Vergi Numarası")
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Talep İleten TCKN";
                textBox1.ForeColor = Color.Gray;
            }
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Talep İleten Vergi Numarası";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Adı Soyadı")
            {
                textBox2.Text = " ";
                textBox2.ForeColor = Color.Black;
            }
            if (textBox2.Text == "Şirket Ünvanı")
            {
                textBox2.Text = " ";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == " ")
            {
                textBox2.Text = "Şirket Ünvanı";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "E-posta Adresiniz")
            {
                textBox3.Text = " ";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == " ")
            {
                textBox3.Text = "E-posta Adresiniz";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Cep Telefonu Numarası")
            {
                textBox4.Text = " ";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == " ")
            {
                textBox4.Text = "Cep Telefonu Numarası";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Telefon Numarası")
            {
                textBox5.Text = " ";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == " ")
            {
                textBox5.Text = "Telefon Numarası";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == " ")
            {
                panel2.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            talep = 2;
            textBox1.Text = "Talep ileten TCKN";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Adı Soyadı";
            textBox2.ForeColor = Color.Gray;
            textBox4.Text = "Cep Telefonu Numarası";
            textBox4.ForeColor = Color.Gray;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tip = 2;
            textBox1.Text = "Talep İleten Vergi Numarası";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Şirket Ünvanı";
            textBox2.ForeColor = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tip = 1;
            textBox1.Text = tc;
            textBox1.ForeColor = Color.Black;

            textBox2.Text = ad;
            textBox2.ForeColor = Color.Black;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
            
            textBox1.Text = ad;
            textBox1.ForeColor = Color.Black;
            textBox2.Text = tc;
            textBox2.ForeColor = Color.Black;
            textBox4.Text = gsm;
            textBox4.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kurumsal = "evet";
            }
            else
            {
                kurumsal = "Hayır";
            }
            DateTime zaman = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            var zamanim = zaman.ToString(format);
            con.Open();          
            string sorgu = "INSERT INTO Kurye_Cagir(Ad_Soyad,TCKNO,GSM_NO,Talep_ID,Tip_ID,Sahsi_Sirket,e_posta,Telefon_NO,Adres,bina_No,kat_no,daire_no,Apartman_Daire_Ad,islem_Tarihi) VALUES (@ad,@tc,@gsm,@talep,@tip,@sahsi,@eposta,@telefon,@adres,@bina,@kat,@daire,@apartman,@islemtarih)";                                            
            SqlCommand komut = new SqlCommand(sorgu, con);                                                                                                                                                                                     komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@tc", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@gsm", int.Parse(textBox4.Text));
            komut.Parameters.AddWithValue("@talep", talep);
            komut.Parameters.AddWithValue("@tip", tip);
            komut.Parameters.AddWithValue("@sahsi",kurumsal);
            komut.Parameters.AddWithValue("@eposta", textBox3.Text);
            komut.Parameters.AddWithValue("@telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@adres", textBox6.Text);
            komut.Parameters.AddWithValue("@bina", textBox7.Text);
            komut.Parameters.AddWithValue("@kat", int.Parse(textBox8.Text));
            komut.Parameters.AddWithValue("@daire", textBox9.Text);
            komut.Parameters.AddWithValue("@apartman", textBox10.Text);
            komut.Parameters.AddWithValue("@islemtarih", zamanim);
            komut.ExecuteNonQuery();
            con.Close();           
            MessageBox.Show("Kurye Yola Çıktı !!");
        }
    }
}
