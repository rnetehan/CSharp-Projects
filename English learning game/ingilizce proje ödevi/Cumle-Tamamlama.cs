using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_proje_ödevi
{
    public partial class Cumle_Tamamlama : Form
    {
        public Cumle_Tamamlama()
        {
            InitializeComponent();
           
        }
        int sonrakisoru = 0;
        
        private void Cumle_Tamamlama_Load(object sender, EventArgs e)
        {
            
            

        }

        private void Cumle_Tamamlama_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //5 soru
            if (sonrakisoru == 5)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    sonrakisoru++;
                }

                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }
            }


            //4 soru
            else if (sonrakisoru == 4)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

               else  if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    sonrakisoru++;
                }

                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

               else  if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }
            }


            //3 soru
            else if (sonrakisoru == 3)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    sonrakisoru++;
                }
            }


            //3 soru
            else if (sonrakisoru == 2)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    sonrakisoru++;
                }

                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }
            }


            //2. soru
            else if (sonrakisoru == 1)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    sonrakisoru += 1;
                }

                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }
            }


            //İlk Soruı
            else if (sonrakisoru == 0)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }

                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    sonrakisoru += 1;
                }

                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Lost");
                }
            }
           


            // soruyu degıstırme satırları
            if (sonrakisoru == 1)
            {
                label1.Text = "I ____ to school by bus.";
                radioButton1.Text = "Eat";
                radioButton2.Text = "Go"; //dogru sık
                radioButton3.Text = "Read";
                radioButton4.Text = "Sleep";
            }

            //3. soruya geç
            if (sonrakisoru == 2)
            {
                label1.Text = "An elephant is very ____.";
                radioButton1.Text = "Big"; //dogru sık
                radioButton2.Text = "Blue";
                radioButton3.Text = "Fast";
                radioButton4.Text = "Small";
            }
            //4. soruya geç
            if (sonrakisoru == 3)
            {
                label1.Text = "It is ____ today, take your umbrella.";
                radioButton1.Text = "Sunny"; 
                radioButton2.Text = "Hot";
                radioButton3.Text = "Hungry";
                radioButton4.Text = "Rainy"; //Doğru Şık
            }
            //5. soru
            if (sonrakisoru == 4)
            {
                label1.Text = "Please, close the ____. It is very cold.";
                radioButton1.Text = "Apple";
                radioButton2.Text = "Window"; // dogru sık
                radioButton3.Text = "Shoe";
                radioButton4.Text = "Spoon"; 
            }
            //6
            if (sonrakisoru == 5)
            {
                label1.Text = "I ____ my teeth every night.";
                radioButton1.Text = "Jump";
                radioButton2.Text = "Brush"; // dogru sık
                radioButton3.Text = "Listen";
                radioButton4.Text = "Watch";
            }
            if (sonrakisoru == 6)
            {
                DialogResult secenek = MessageBox.Show("You Won the Game","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (secenek ==DialogResult.Yes)
                {
                    label1.Text = "I drink ____ every morning.";
                    radioButton1.Text = "Bread";
                    radioButton2.Text = "Window"; 
                    radioButton3.Text = "Milk"; //dogru
                    radioButton4.Text = "Pen";
                    sonrakisoru = 0;
                }
                if (secenek == DialogResult.No)
                {
                    Close();
                }
            }
        }
    }
}
