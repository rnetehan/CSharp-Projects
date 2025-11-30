namespace Hesap_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = "Şifre";
                label2.Text = "Kullanıcı Adı";
                label3.Text = "Zaten Oluşturulmuş Bir Hesabınız mı Var?";
                label5.Text = "Şifre Onayla";
                groupBox1.Text = "Dil";
                groupBox2.Text = "Tema";
                groupBox3.Text = "Hesap Oluşturma";
                button1.Text = "Tıkla";
                radioButton3.Text = "Beyaz";
                radioButton4.Text = "Gri";
                button2.Text = "Onayla";
                if (textBox1.Text == "")
                {
                    if (radioButton1.Checked == true) { label4.Text = "Please enter your username"; }
                    if (radioButton2.Checked == true) { label4.Text = "Lütfen Kullanıcı Adı Girin"; }
                }
                if (textBox2.Text != textBox3.Text)
                {
                    if (radioButton2.Checked == true) { label4.Text = "Girilen Şifreler Uyuşmuyor!"; }
                    else if (radioButton1.Checked == true) { label4.Text = "The entered passwords do not match.!"; }
                }
                if (textBox2.Text == textBox3.Text) { label4.Text = ""; }
                if (textBox3.Text == "" && textBox2.Text == "")
                {
                    if (radioButton2.Checked == true) { label4.Text = "Lütfen Şifre Oluşturun"; }
                    if (radioButton1.Checked == true) { label4.Text = "Please Create Password"; }
                }
                if (textBox1.Text == "")
                {
                    if (radioButton2.Checked == true) { label4.Text = "Lütfen Kullanıcı Adı Oluşturun"; }
                    if (radioButton1.Checked == true) { label4.Text = "Please Create a Username"; }
                }
                if (textBox1.Text != "" && textBox2.Text == textBox3.Text && textBox3.Text != "" && textBox2.Text != "")
                {
                    label4.Text = "";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "Password";
                label2.Text = "User Name";
                label3.Text = "Already Have an Account Created?";
                label5.Text = "Confirm Password";
                groupBox1.Text = "Language";
                groupBox2.Text = "BackColor";
                groupBox3.Text = "Creating an Account";
                button1.Text = "Click";
                button2.Text = "Confirm";
                radioButton3.Text = "White";
                radioButton4.Text = "Gray";

                if (textBox1.Text == "")
                {
                    if (radioButton1.Checked == true) { label4.Text = "Please enter your username"; }
                    if (radioButton2.Checked == true) { label4.Text = "Lütfen Kullanıcı Adı Girin"; }
                }
                if (textBox2.Text != textBox3.Text)
                {
                    if (radioButton2.Checked == true) { label4.Text = "Girilen Şifreler Uyuşmuyor!"; }
                    else if (radioButton1.Checked == true) { label4.Text = "The entered passwords do not match.!"; }
                }
                if (textBox2.Text == textBox3.Text) { label4.Text = ""; }
                if (textBox3.Text == "" && textBox2.Text == "")
                {
                    if (radioButton2.Checked == true) { label4.Text = "Lütfen Şifre Oluşturun"; }
                    if (radioButton1.Checked == true) { label4.Text = "Please Create Password"; }
                }
                if (textBox1.Text == "")
                {
                    if (radioButton2.Checked == true) { label4.Text = "Lütfen Kullanıcı Adı Oluşturun"; }
                    if (radioButton1.Checked == true) { label4.Text = "Please Create a Username"; }
                }
                if (textBox1.Text != "" && textBox2.Text == textBox3.Text && textBox3.Text != "" && textBox2.Text != "")
                {
                    label4.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesap_giris x = new Hesap_giris();
            x.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                if (radioButton1.Checked == true) { label4.Text = "Please enter your username"; }
                if (radioButton2.Checked == true) { label4.Text = "Lütfen Kullanıcı Adı Girin"; }
            }
            if (textBox2.Text != textBox3.Text)
            {
                if (radioButton2.Checked == true) { label4.Text = "Girilen Şifreler Uyuşmuyor!"; }
                else if (radioButton1.Checked == true) { label4.Text = "The entered passwords do not match.!"; }
            }
            if (textBox2.Text == textBox3.Text) { label4.Text = ""; }
            if (textBox3.Text == "" && textBox2.Text == "")
            {
                if (radioButton2.Checked == true) { label4.Text = "Lütfen Şifre Oluşturun"; }
                if (radioButton1.Checked == true) { label4.Text = "Please Create Password"; }
            }
            if (textBox1.Text == "")
            {
                if (radioButton2.Checked == true) { label4.Text = "Lütfen Kullanıcı Adı Oluşturun"; }
                if (radioButton1.Checked == true) { label4.Text = "Please Create a Username"; }
            }
            if (textBox1.Text != "" && textBox2.Text == textBox3.Text && textBox3.Text != "" && textBox2.Text!="")
            {
                label4.Text = "";
                Form2 xn = new Form2();
                xn.Show();
                Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
