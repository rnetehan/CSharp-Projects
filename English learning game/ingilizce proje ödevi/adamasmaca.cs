using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ingilizce_proje_ödevi
{
    public partial class adamasmaca : Form
    {
        // Değişkenlerimizi sınıfın en başında tanımlıyoruz
        Dictionary<string, string> wordList = new Dictionary<string, string>()
        {
            {"YAZILIM", "SOFTWARE"},
            {"BİLGİSAYAR", "COMPUTER"},
            {"DEĞİŞKEN", "VARIABLE"},
            {"KLAVYE", "KEYBOARD"},
            {"EKRAN", "DISPLAY"},
            {"KÜTÜPHANE", "LIBRARY"},
            {"TEKERLEK", "WHEEL"},
            {"GÜNEŞ", "SUN"}
        };

        string targetWord;  // İngilizce (Tahmin edilecek)
        string hintWord;    // Türkçe (İpucu)
        char[] hiddenWord;  // Ekranda görünen çizgiler
        int errorCount = 0; // Hata sayısı
        int maxErrors = 6;  // Maksimum hata limiti

        public adamasmaca()
        {
            InitializeComponent();
            // Formun ekranın ortasında açılması için:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void adamasmaca_Load(object sender, EventArgs e)
        {
            StartNewGame(); // Form açıldığında oyunu başlat
        }

        private void StartNewGame()
        {
            Random rnd = new Random();
            var randomPair = wordList.ElementAt(rnd.Next(0, wordList.Count));

            hintWord = randomPair.Key;
            targetWord = randomPair.Value.ToUpper(); // İngilizce kelimeyi büyük harf yap

            // Burayı "Türkçe:" olarak güncelledik
            lblHint.Text = "Türkçe: " + hintWord;

            // Çizgileri oluşturma kısmı
            hiddenWord = new char[targetWord.Length];
            for (int i = 0; i < targetWord.Length; i++)
            {
                hiddenWord[i] = '_';
            }

            lblWord.Text = string.Join(" ", hiddenWord);
            errorCount = 0;

            // Oyun başlar başlamaz boş sehpa (hata0) görünsün
            pictureBox1.Image = Properties.Resources.hata0;

            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(input)) return;

            // --- KELİME TAHMİNİ (Örn: Direkt "SUN" yazdıysa) ---
            if (input.Length > 1)
            {
                if (input == targetWord)
                {
                    lblWord.Text = string.Join(" ", targetWord.ToCharArray()); // Tüm harfleri göster
                    MessageBox.Show("Amazing! You guessed the whole word: " + targetWord);
                    StartNewGame();
                }
                else
                {
                    MessageBox.Show("Wrong word guess!");
                    errorCount++; // Yanlış kelime tahmini 1 hata sayılır
                    UpdateHangmanImage();
                }
            }
            // --- HARF TAHMİNİ (Tek harf girildiyse) ---
            else
            {
                char guess = input[0];
                bool isCorrect = false;

                for (int i = 0; i < targetWord.Length; i++)
                {
                    if (targetWord[i] == guess)
                    {
                        hiddenWord[i] = guess;
                        isCorrect = true;
                    }
                }

                if (isCorrect)
                {
                    lblWord.Text = string.Join(" ", hiddenWord);
                    if (!lblWord.Text.Contains("_"))
                    {
                        MessageBox.Show("Congratulations!");
                        StartNewGame();
                    }
                }
                else
                {
                    errorCount++;
                    UpdateHangmanImage();
                }
            }

            // Oyun bitti mi kontrolü
            if (errorCount >= maxErrors)
            {
                MessageBox.Show("Game Over! Word: " + targetWord);
                StartNewGame();
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        private void UpdateHangmanImage()
        {
            // Resimlerin "hata1", "hata2" gibi Resources içinde ekli olduğunu varsayıyoruz
            object img = Properties.Resources.ResourceManager.GetObject("hata" + errorCount);
            if (img != null)
            {
                pictureBox1.Image = (Image)img;
            }
        }

        private void adamasmaca_Load_1(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}