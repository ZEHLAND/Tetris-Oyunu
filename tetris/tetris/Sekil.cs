using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HİLAL ZEHRA AYDIN
//190707078
//DÖNEM PROJESİ 2 
//BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
namespace tetris
{
    class Sekil
    {
        public int genislik; // oyundaki şekillerin genişliği
        public int yukseklik; // oyundaki şekillerin yuksekliği
        public int[,] Kutu; // şekil oluşturmak için dizi tanımlandı

        private int[,] kutuYedek; // şekil oluşturmak için yedek dizi tanımlandı
        public void Cevir() //sekillerin cevirilmesi işlemi için fonksiyon tanımlandı
        {
         
            kutuYedek = Kutu; // esas kutu yedek kutuya kopyalandı

            Kutu = new int[genislik, yukseklik]; // kutunun satır ve sütünu verildi 
            for (int i = 0; i < genislik; i++) //satır = genişliğe kadar gidildi 
            {
                for (int j = 0; j < yukseklik; j++) // sutun = yuksekliğe kadar gidildi.
                {
                    Kutu[i, j] = kutuYedek[yukseklik - 1 - j, i]; 
                    //kutuda satır ve sutunu yer değiştirerek cevirme işlemi yaptım 
                }
            }

            //gecici değişken oluşturarak genişlik ve yüksekliğin yerini değiştirdim .
            var temp = genislik; 
            genislik = yukseklik;
            yukseklik = temp;
        }

       
        public void GeriDondur() // şekli eski haline geri cevirme 
        {
            Kutu = kutuYedek;//yedek kutu esas kutuya koylandı 
            //tekrar satır ve sutunda  değişme işlemi yapıldı 
            var temp = genislik;
            genislik = yukseklik;
            yukseklik = temp;
        }
    }
}
