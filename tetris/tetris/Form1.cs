using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//HİLAL ZEHRA AYDIN
//190707078
//DÖNEM PROJESİ 2 
//BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
namespace tetris
{
    public partial class Form1 : Form
    {
        Sekil mevcutSekil; //oyunda olan şekil 
        Sekil gelecekSekil; //gelecek yeni şekil
        Timer timer = new Timer(); // yeni time clası oluşturuldu .
    
        public Form1()
        {
            InitializeComponent();
           // button1.Visible = false;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
         
            var dikeyTasi = 0; //dikey yönde taşıma için 
            var yatayTasi = 0; //yatay olarak taşıma için

            // tuşlara basıldığında yatay ve dikey eksende konumlarını hesaplar 
            switch (e.KeyCode)
            {
                // sola hareket ettirme
                case Keys.Left:
                    dikeyTasi--;
                    break;

                // sağa hareket ettirme
                case Keys.Right:
                    dikeyTasi++;
                    break;

                // aşağı yön tuşuna basınca daha hızlı hareket etmesini sağlama
                case Keys.Down:
                    yatayTasi++;
                    break;

                // yukarı yön tuşu ile şekli döndürme
                case Keys.Up:
                    mevcutSekil.Cevir();
                    break;
                default:
                    return;
            }

            var basarili = TasimaBasarilimi(yatayTasi, dikeyTasi);

            // şekli döndürme başarılı olmaz ise mevcutta gelen şekle geri döndürür
            if (!basarili && e.KeyCode == Keys.Up)
                mevcutSekil.GeriDondur(); // mevcut şeklin konumu tekrar dondurme
        }



        // oyun alanının oluşturulması
        Bitmap oyunAlaniBitmap; 
        Graphics oyunAlaniGraphics; 
        //oyun alanının boyutlanması 
        int oyunAlaniGenislik = 15;
        int oyunAlaniYukseklik = 20;
        //oyun alanı 
        int[,] oyunAlanıKutuDizisi;
        int nokta_boyut = 20;//alan için 
        private void OyunAlaniYukle()
        {
            // pixtureboxı kutu boyutuna ve oyun alanı boyutuna göre geri döndürür.
            picboxOyunAlani.Width = oyunAlaniGenislik * nokta_boyut;
            picboxOyunAlani.Height = oyunAlaniYukseklik * nokta_boyut;

            // pixtureboxın boyutuna göre bitmap oluşturma
            oyunAlaniBitmap = new Bitmap(picboxOyunAlani.Width, picboxOyunAlani.Height);

            oyunAlaniGraphics = Graphics.FromImage(oyunAlaniBitmap);

            oyunAlaniGraphics.FillRectangle(Brushes.LightGray, 0, 0, oyunAlaniBitmap.Width, oyunAlaniBitmap.Height);

            // oluşturulan bitmapı pixtureboxa  yükler
            picboxOyunAlani.Image = oyunAlaniBitmap;

            //oyun alanını başlatır varsayılan değer 0 dır
            oyunAlanıKutuDizisi = new int[oyunAlaniGenislik, oyunAlaniYukseklik];
        }
        //mevcut x ve y konumları 
        int mevcutX; 
        int mevcutY;
        private Sekil gelenSekliHizala()
        {
            var sekil = SekilIslemleri.RandomSekilGetir();

            // X ve y değerlerini, sanki şekil merkezdeymiş gibi hesaplar
            mevcutX = 7;
            mevcutY = -sekil.yukseklik;

            return sekil;
        }
        int sayac = 0;
        Bitmap workingBitmap;
        Graphics workingGraphics;
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            var basarili = TasimaBasarilimi(moveDown: 1);
            sayac++;
            lbl_Puan.Text = "Puanınız: " + sayac.ToString();

            // şekil zemine ulaştıysa veya başka bir şeklin üstüne oturduysa
            if (!basarili)
            {
                // çalışan resmi oyun alanına kopyalar
                oyunAlaniBitmap = new Bitmap(workingBitmap);

                KutuDizisiGuncelle();

                // yeni şekil getirir
                // gelecek şekil mevcut şekle atandı 
                mevcutSekil = gelecekSekil;
                gelecekSekil = yeniSekilGetir();
                
                tetrisOlursa();
                
            }
            
        }
        //mevcut şekil oyun alanında taşma yapar yani sığmazsa oyun bitti demektir . 
        //bunun kontrölü yapıldı.
        private void KutuDizisiGuncelle() 
        {
            for (int i = 0; i < mevcutSekil.genislik; i++)
            {
                for (int j = 0; j < mevcutSekil.yukseklik; j++)
                {
                    if (mevcutSekil.Kutu[j, i] == 1) 
                    {
                        oyunBittMi(); //oyun bittimi kontrolü yapılır

                        oyunAlanıKutuDizisi[mevcutX + i, mevcutY + j] = 1;
                    }
                }
            }
        }

        private void oyunBittMi()
        {
            if (mevcutY < 0) // yükseklik 0 dan küçük ise  oyun bitti demektir
            {
                timer.Stop(); //zaman durdurulur 
                MessageBox.Show("Oyun Bitti. Skorunuz :"+sayac);//skor ekrana bastırılır
                Application.Exit();//oyun ekranı kapatılır
            }
        }

        // zemine ulaşırsa veya başka bir şeklin üstüne gelirse dizide oluştuğu haline döner
        private bool TasimaBasarilimi(int moveDown = 0, int moveSide = 0)
        {
            var yeniX = mevcutX + moveSide;
            var yeniY = mevcutY + moveDown;

            // alt veya yan çubuğa ulaşıp ulaşmadığını kontrol eder
            if (yeniX < 0 || yeniX + mevcutSekil.genislik > oyunAlaniGenislik
                || yeniY + mevcutSekil.yukseklik > oyunAlaniYukseklik)
                return false;

            // başka şekillere değip değmediğini kontrol edin
            for (int i = 0; i < mevcutSekil.genislik; i++)
            {
                for (int j = 0; j < mevcutSekil.yukseklik; j++)
                {
                    if (yeniY + j > 0 && oyunAlanıKutuDizisi[yeniX + i, yeniY + j] == 1 && mevcutSekil.Kutu[j, i] == 1)
                        return false;
                }
            }
            //yeni şeklin x ve y konumu mevcut şekle aktarıldı
            mevcutX = yeniX;
            mevcutY = yeniY;

            sekilCiz();

            return true;
        }

        private void sekilCiz()
        {
            workingBitmap = new Bitmap(oyunAlaniBitmap); 
            workingGraphics = Graphics.FromImage(workingBitmap);

            for (int i = 0; i < mevcutSekil.genislik; i++)
            {
                for (int j = 0; j < mevcutSekil.yukseklik; j++)
                {
                    if (mevcutSekil.Kutu[j, i] == 1)
                        workingGraphics.FillRectangle(Brushes.Red, (mevcutX + i) * nokta_boyut, (mevcutY + j) * nokta_boyut, nokta_boyut, nokta_boyut);
                }
            }

            picboxOyunAlani.Image = workingBitmap;
        }

       

        int score;
        public void tetrisOlursa()
        {
            // her satırı kontrol eder
            for (int i = 0; i < oyunAlaniYukseklik; i++)
            {
                int j;
                for (j = oyunAlaniGenislik - 1; j >= 0; j--)
                {
                    if (oyunAlanıKutuDizisi[j, i] == 0)
                        break;
                }

                if (j == -1)
                {
                    // Puan Güncelle
                    score+=100;
                    sayac += score;
                  

                    // diziyi güncelle
                    for (j = 0; j < oyunAlaniGenislik; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            oyunAlanıKutuDizisi[j, k] = oyunAlanıKutuDizisi[j, k - 1];
                        }

                        oyunAlanıKutuDizisi[j, 0] = 0;
                    }
                }
            }

            // güncellen diziye göre yeni bir panel çizer
            for (int i = 0; i < oyunAlaniGenislik; i++)
            {
                for (int j = 0; j < oyunAlaniYukseklik; j++)
                {
                    oyunAlaniGraphics = Graphics.FromImage(oyunAlaniBitmap);
                    oyunAlaniGraphics.FillRectangle(
                        oyunAlanıKutuDizisi[i, j] == 1 ? Brushes.Red : Brushes.LightGray,
                        i * nokta_boyut, j * nokta_boyut, nokta_boyut, nokta_boyut
                        );
                }
            }

            picboxOyunAlani.Image = oyunAlaniBitmap;
        }

        Bitmap gelecekSekilBitmap;
        Graphics gelecekSekilGraphics;
        private Sekil yeniSekilGetir()
        {
            var sekil = gelenSekliHizala();

            // sonraki şekli gösteren kodlar
            gelecekSekilBitmap = new Bitmap(6 * nokta_boyut, 6 * nokta_boyut);
            gelecekSekilGraphics = Graphics.FromImage(gelecekSekilBitmap);

            gelecekSekilGraphics.FillRectangle(Brushes.LightGray, 0, 0, gelecekSekilBitmap.Width, gelecekSekilBitmap.Height);

            // yeni şekil için ideal olduğunu düşündüğüm konum
            var startX = (6 - sekil.genislik) / 2;
            var startY = (6 - sekil.yukseklik) / 2;

            for (int i = 0; i < sekil.yukseklik; i++)
            {
                for (int j = 0; j < sekil.genislik; j++)
                {
                    gelecekSekilGraphics.FillRectangle(
                        sekil.Kutu[i, j] == 1 ? Brushes.Black : Brushes.LightGray,
                        (startX + j) * nokta_boyut, (startY + i) * nokta_boyut, nokta_boyut, nokta_boyut);
                }
            }

            picboxGelenSekil.Size = gelecekSekilBitmap.Size;
            picboxGelenSekil.Image = gelecekSekilBitmap;

            return sekil;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            mevcutSekil = gelecekSekil;
           gelecekSekil = yeniSekilGetir();
        }
        
        private void btn_Basla_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            OyunAlaniYukle();
            mevcutSekil = gelenSekliHizala();
            gelecekSekil = yeniSekilGetir();

            timer.Tick += Timer_Tick;
            timer.Interval = 1000; // timerin değeri verildi
            timer.Start(); //zaman başlatıldı
            this.KeyDown += Form1_KeyDown;//keyDown özelliği form1 e eklendi
            this.KeyPreview = true;
            btn_Basla.Visible = false;
           

        }

        private void btn_YeniOyun_Click(object sender, EventArgs e)
        {
            //oyunu yenile butonu
            timer.Stop();// zaman durduruldu
            //oyun için gerekli fonksiyonlar tekrar çağrıldı
            //değişkenler sıfırlandı 
            sayac = 0;
            score = 0;
            timer = new Timer();
            OyunAlaniYukle();
            mevcutSekil = gelenSekliHizala();
            gelecekSekil = yeniSekilGetir();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
