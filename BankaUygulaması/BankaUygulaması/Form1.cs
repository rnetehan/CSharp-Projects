using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankaUygulaması
{
    public partial class Form1 : Form
    {
        int siraNo = 0;
        Random rnd = new Random();

        Queue<int> kuyrukM1 = new Queue<int>();
        Queue<int> kuyrukM2 = new Queue<int>();
        Queue<int> kuyrukM3 = new Queue<int>();
        Queue<int> kuyrukM4 = new Queue<int>();
        Queue<int> kuyrukM5 = new Queue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            siraNo++;

            int secim = rnd.Next(1, 6);
            string gise = "Oda " + secim;

            listBox1.Items.Add(siraNo);
            listBox2.Items.Add(siraNo + " → " + gise);

            switch (secim)
            {
                case 1: kuyrukM1.Enqueue(siraNo); break;
                case 2: kuyrukM2.Enqueue(siraNo); break;
                case 3: kuyrukM3.Enqueue(siraNo); break;
                case 4: kuyrukM4.Enqueue(siraNo); break;
                case 5: kuyrukM5.Enqueue(siraNo); break;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (kuyrukM1.Count > 0)
            {
                int siradaki = kuyrukM1.Peek();
                int girilen;

                if (int.TryParse(textBox1.Text, out girilen))
                {
                    if (girilen == siradaki)
                    {
                        kuyrukM1.Dequeue();
                        listBox1.Items.Remove(girilen);
                        listBox2.Items.Remove(girilen + " → Oda 1");
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("HATA! Sıradaki kişi: " + siradaki);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir numara girin!");
                }
            }
            else
            {
                MessageBox.Show("Oda 1'de Kimse Yok");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (kuyrukM2.Count > 0)
            {
                int siradaki = kuyrukM2.Peek();
                int girilen;

                if (int.TryParse(textBox2.Text, out girilen))
                {
                    if (girilen == siradaki)
                    {
                        kuyrukM2.Dequeue();
                        listBox1.Items.Remove(girilen);
                        listBox2.Items.Remove(girilen + " → Oda 2");
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("HATA! Sıradaki kişi: " + siradaki);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir numara girin!");
                }
            }
            else
            {
                MessageBox.Show("Oda 2'de Kimse Yok");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (kuyrukM3.Count > 0)
            {
                int siradaki = kuyrukM3.Peek();
                int girilen;

                if (int.TryParse(textBox3.Text, out girilen))
                {
                    if (girilen == siradaki)
                    {
                        kuyrukM3.Dequeue();
                        listBox1.Items.Remove(girilen);
                        listBox2.Items.Remove(girilen + " → Oda 3");
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("HATA! Sıradaki kişi: " + siradaki);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir numara girin!");
                }
            }
            else
            {
                MessageBox.Show("Oda 3'de Kimse Yok");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (kuyrukM4.Count > 0)
            {
                int siradaki = kuyrukM4.Peek();
                int girilen;

                if (int.TryParse(textBox4.Text, out girilen))
                {
                    if (girilen == siradaki)
                    {
                        kuyrukM4.Dequeue();
                        listBox1.Items.Remove(girilen);
                        listBox2.Items.Remove(girilen + " → Oda 4");
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("HATA! Sıradaki kişi: " + siradaki);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir numara girin!");
                }
            }
            else
            {
                MessageBox.Show("Oda 4'de Kimse Yok");
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (kuyrukM5.Count > 0)
            {
                int siradaki = kuyrukM5.Peek();
                int girilen;

                if (int.TryParse(textBox5.Text, out girilen))
                {
                    if (girilen == siradaki)
                    {
                        kuyrukM5.Dequeue();
                        listBox1.Items.Remove(girilen);
                        listBox2.Items.Remove(girilen + " → Oda 5");
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("HATA! Sıradaki kişi: " + siradaki);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir numara girin!");
                }
            }
            else
            {
                MessageBox.Show("Oda 5'de Kimse Yok");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
