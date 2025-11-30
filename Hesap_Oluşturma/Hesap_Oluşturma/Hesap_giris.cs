using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Oluşturma
{
    public partial class Hesap_giris : Form
    {
        public Hesap_giris()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Text = "Beyaz";
            radioButton4.Text = "Gri";
            groupBox1.Text = "Dil";
            groupBox2.Text = "Tema";
            groupBox3.Text = "Hesap Giriş";
            button1.Text = "Tıkla";
            button2.Text = "Onayla";
            label1.Text = "Hesabınız Yokmu?";
            label3.Text = "Şifre";
            label2.Text = "Kullanıcı Adı";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (radioButton1.Checked == true) { label4.Text = "Please enter all information completely."; }
                if (radioButton2.Checked == true) { label4.Text = "Lütfen tüm bilgileri eksiksiz giriniz."; }
            }
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                if (radioButton1.Checked == true) { label4.Text = "Username or password is incorrect"; }
                if (radioButton2.Checked == true) { label4.Text = "Kullanıcı adı veya şifre hatalı"; }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Text = "White";
            radioButton4.Text = "Gray";
            groupBox1.Text = "Language";
            groupBox2.Text = "BackColor";
            groupBox3.Text = "Account Login";
            button1.Text = "Click";
            button2.Text = "Confirm";
            label1.Text = "Don't have an account?";
            label3.Text = "Password";
            label2.Text = "User Name";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (radioButton1.Checked == true) { label4.Text = "Please enter all information completely."; }
                if (radioButton2.Checked == true) { label4.Text = "Lütfen tüm bilgileri eksiksiz giriniz."; }
            }
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                if (radioButton1.Checked == true) { label4.Text = "Username or password is incorrect"; }
                if (radioButton2.Checked == true) { label4.Text = "Kullanıcı adı veya şifre hatalı"; }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            Hide();
        }

        private void Hesap_giris_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (radioButton1.Checked == true) { label4.Text = "Please enter all information completely."; }
                if (radioButton2.Checked == true) { label4.Text = "Lütfen tüm bilgileri eksiksiz giriniz."; }
            }
            if (textBox2.Text!="" && textBox1.Text!="") 
            {
                if (radioButton1.Checked == true) { label4.Text = "Username or password is incorrect"; }
                if (radioButton2.Checked == true) { label4.Text = "Kullanıcı adı veya şifre hatalı"; }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
