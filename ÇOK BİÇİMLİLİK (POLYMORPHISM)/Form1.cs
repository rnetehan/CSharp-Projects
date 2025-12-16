using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇOK_BİÇİMLİLİK__POLYMORPHISM_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<sekil> sekiller = new List<sekil>
            {
                new daire(),
                new ücgen(),
                new Kare()
            };

            foreach (var sekil in sekiller)
            {
                sekil.ciz();
            }

        }
    }
}
