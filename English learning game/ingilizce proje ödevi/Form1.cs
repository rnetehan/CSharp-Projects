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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cumle_Tamamlama x= new Cumle_Tamamlama();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adamasmaca x=new adamasmaca();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            görsel_eslestirme x= new görsel_eslestirme();
            this.Hide() ;
            x.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
