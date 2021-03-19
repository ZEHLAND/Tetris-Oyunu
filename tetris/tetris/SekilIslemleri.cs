using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hilal Zehra AYDIN
//190707078
//DÖNEM PROJESİ 2 
//BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ

namespace tetris
{
    class SekilIslemleri
    {
        private static Sekil[] sekilDizisi;//Şekillleri oluşturmak için dizi tanımlandı

        
        static SekilIslemleri() //sekil oluşturmak için 
        {
            // dizi içinde şekil oluştur
            sekilDizisi = new Sekil[] //sekil dizisi oluşturuldu
                {
                    new Sekil { //yeni sekil 
                        genislik = 2, //boyutlandırma yapıldı 
                        yukseklik = 2, //boyutlandırma yapıldı 
                        
                        Kutu = new int[,] // kare şekli için dizi oluşturuldu
                        {
                            { 1, 1 }, 
                            { 1, 1 } 
                        }
                    },
                    new Sekil { //yeni sekil 
                        genislik = 1, // L şekline göre boyutlandırma ona göre yapıldı
                        yukseklik = 4,// L şekline göre boyutlandırma ona göre yapıldı
                        Kutu = new int[,] //yeni şekil dizisi oluşturuldu
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        }
                    },
                    new Sekil {//yeni sekil 
                        genislik = 3,// yeni şekil için boyutlandırma yapıldı 
                        yukseklik = 2, // yeni şekil için boyutlandırma yapıldı 
                        Kutu = new int[,] //yeni şekil dizisi oluşturuldu
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Sekil {//yeni sekil 
                        genislik = 3,// yeni şekil için boyutlandırma yapıldı 
                        yukseklik = 2,// yeni şekil için boyutlandırma yapıldı 
                        Kutu = new int[,] //yeni şekil dizisi oluşturuldu
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new Sekil {//yeni sekil 
                        genislik = 3,// yeni şekil için boyutlandırma yapıldı 
                        yukseklik = 2,// yeni şekil için boyutlandırma yapıldı 
                        Kutu = new int[,]//yeni şekil dizisi oluşturuldu
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Sekil {//yeni sekil 
                        genislik = 3,// yeni şekil için boyutlandırma yapıldı 
                        yukseklik = 2,// yeni şekil için boyutlandırma yapıldı 
                        Kutu = new int[,]//yeni şekil dizisi oluşturuldu
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new Sekil {
                        genislik = 3,// yeni şekil için boyutlandırma yapıldı 
                        yukseklik = 2,// yeni şekil için boyutlandırma yapıldı 
                        Kutu = new int[,]//yeni şekil dizisi oluşturuldu
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    }
                };
        }

        // olusan şekillerin random olarak getirilmesi
        public static Sekil RandomSekilGetir()
        {
            var sekil = sekilDizisi[new Random().Next(sekilDizisi.Length)];//rand olarak şeklin belirnmesi 

            return sekil; //rand secilen şeklin gönderilmesi
        }
    }
}
