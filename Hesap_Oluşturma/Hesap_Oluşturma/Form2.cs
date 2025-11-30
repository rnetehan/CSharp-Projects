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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Language";
            groupBox2.Text = "BackColor";
            label2.Text = "Your account has been created successfully.";
            label1.Text = "To Return";
            button1.Text = "Click";
            radioButton3.Text = "White";
            radioButton4.Text = "Gray";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Dil";
            groupBox2.Text = "Tema";
            label2.Text = "Hesabınız başarıyla oluşturuldu.";
            label1.Text = "Geri Dönmek İçin";
            button1.Text = "Tıkla";
            radioButton3.Text = "Beyaz";
            radioButton4.Text = "Gri";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
