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
    public partial class görsel_eslestirme : Form
    {
        public görsel_eslestirme()
        {
            InitializeComponent();
        }
        int level = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          //okul cevap 2
            if (level == 0)
            {
                if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level++;
                    radioButton1.Text = "Homework";
                    radioButton2.Text = "office";
                    radioButton3.Text = "company";
                    radioButton4.Text = "camp";
                    pictureBox1.Image = Properties.Resources.images__1_;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
         //ev odevı cevap 1
            }
            else if (level == 1) 
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level++;
                    radioButton1.Text = "family";
                    radioButton2.Text = "mountain walk";
                    radioButton3.Text = "fight";
                    radioButton4.Text = "fisherman";
                    pictureBox1.Image = Properties.Resources.large_14_e1476868248189;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
            }
            //dag yuruyusu  cevap 2
            else if (level == 2) 
            {
                if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level++;
                    radioButton1.Text = "enemy";
                    radioButton2.Text = "crocodile";
                    radioButton3.Text = "car";
                    radioButton4.Text = "farmer";
                    pictureBox1.Image = Properties.Resources.cartoon_farmer_with_farmland_background_free_vector;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
            }

            //çiftci cevap 4
            else if (level == 3)
            {
                if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level++;
                    radioButton1.Text = "organisation";
                    radioButton2.Text = "thief";
                    radioButton3.Text = "forest";
                    radioButton4.Text = "fire";
                    pictureBox1.Image = Properties.Resources.Wee_Forests___image_1;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
            }

            // orman cevap 3
            else if (level == 4)
            {
                if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level++;
                    radioButton1.Text = "gold";
                    radioButton2.Text = "win";
                    radioButton3.Text = "rubbish";
                    radioButton4.Text = "police";
                    pictureBox1.Image = Properties.Resources.pngtree_gray_garbage_trash_png_image_10130504;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
            }

            // çöp cevap 3
            else if (level == 5)
            {
                if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level++;
                    radioButton1.Text = "foam";
                    radioButton2.Text = "fireman";
                    radioButton3.Text = "beach";
                    radioButton4.Text = "musician";
                    pictureBox1.Image = Properties.Resources.cartoon_drawing_of_a_fireman_vector;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
            }

            // itfaiyeci cevap 2
            else if (level == 6)
            {
                if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Your Win");
                    level=0;
                    radioButton1.Text = "swin";
                    radioButton2.Text = "school";
                    radioButton3.Text = "walk";
                    radioButton4.Text = "run";
                    pictureBox1.Image = Properties.Resources.pngtree_school_building_cartoon_school_elements_png_image_5689022;
                }
                else
                {
                    MessageBox.Show("Your Lost");
                }
            }
        }
    }
}
