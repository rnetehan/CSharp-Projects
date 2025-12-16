using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
          string ekle=textBox1.Text;
            if (Enum.TryParse(ekle, true, out seviyeler seviye))
            {
                if (seviye == seviyeler.level1)
                {
                    listBox1.Items.Add((int)seviyeler.level1); 
                }
                else if (seviye == seviyeler.level2)
                {
                    listBox1.Items.Add((int)seviyeler.level2);
                }
                else if (seviye == seviyeler.level3)
                {
                    listBox1.Items.Add((int)seviyeler.level3);
                }
                else if (seviye == seviyeler.level4)
                {
                    listBox1.Items.Add((int)seviyeler.level4);
                }
                else if (seviye == seviyeler.level5)
                {
                    listBox1.Items.Add((int)seviyeler.level5);
                }
                else
                {
                    MessageBox.Show("Girilen Level Yok");
                }

            }
        }
    }
}
