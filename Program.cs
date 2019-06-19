using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_NotHesapUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Karşılama olacak.
             Menü olarak dersler listelenecek ve bir ders seçtirilecek. (en az 4 ders)
             Ekran temizlenecek.
             Menü olarak öğrenciler listelenecek ve bir öğrenci seçtirilecek 
             Ekran temizlenecek.
             vize1 notu, vize2 notu ve final notu alınacak(kontrollü olarak 100 lük sistemde)
             Ekran temizlenecek.
             vize1 %20, vize2 %30 ve final %50 hesap oranları ile öğrencinin notu hesap edilecek. Geçme notu 70
             Sonuc ekrana yazılır.
             "Osman Yazıcı, Fizik dersinden 40 puan alıp kaldı/gecti."
             */
            #region Karşılama olacak.
            Console.WriteLine("**************************\nNot Hesap Uygulamasına Hoşgeldiniz.\n**************************");
            #endregion

            #region Menü olarak dersler listelenecek 
            Console.WriteLine(@"
1 - Fizik
2 - Kimya
3 - Biyoloji
4 - Matematik
5 - Edebiyat
6 - Yazılım
7 - OOP");
            #endregion

            #region bir ders seçtirilecek.
            Console.Write("Lütfen bir ders seciniz: ");
            string dersSecimi = Console.ReadLine();
            string secilenDers="";
            switch (dersSecimi)
            {
                case "1":secilenDers = "Fizik";
                    break;
                case "2":
                    secilenDers = "Kimya";
                    break;
                case "3":
                    secilenDers = "Biyoloji";
                    break;
                case "4":
                    secilenDers = "Matematik";
                    break;
                case "5":
                    secilenDers = "Edebiyat";
                    break;
                case "6":
                    secilenDers = "Yazılım";
                    break;
                case "7":
                    secilenDers = "OOP";
                    break;
                default:
                    {
                        Console.Write("Hatalı veya menü seçenekleri dışında bir giriş yaptınız.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;
            }
            #endregion

            #region Ekran temizlenecek.
            Console.Clear();
            #endregion

            #region Menü olarak öğrenciler listelenecek
            Console.WriteLine(@"
1 - Osman Yazıcı
2 - Burak KücükAli
3 - Muhammed Hüseyin Çekmez
4 - Oğuzhan Demiral
5 - Semih Ur
6 - Yonca Orhaner
7 - Fatmanur Azturk");
            #endregion

            #region bir öğrenci seçtirilecek
            Console.Write("Lütfen bir öğrenci seçiniz: ");
            string ogrenciSecimi = Console.ReadLine();

            switch (ogrenciSecimi)
            {
                case "1":ogrenciSecimi = "Osman Yazıcı";
                    break;
                case "2":
                    ogrenciSecimi = "Burak KüçükAli";
                    break;
                case "3":
                    ogrenciSecimi = "Muhammed Hüseyin Çekmez";
                    break;
                case "4":
                    ogrenciSecimi = "Oğuzhan Demiral";
                    break;
                case "5":
                    ogrenciSecimi = "Semih Ur";
                    break;
                case "6":
                    ogrenciSecimi = "Yonca Orhaner";
                    break;
                case "7":
                    ogrenciSecimi = "Fatmanur Azturk";
                    break;
                default:
                    {
                        Console.Write("Hatalı yada menü dışında bir seçim yaptınız.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    break;
            }


            #endregion

            #region Ekran temizlenecek.
            Console.Clear();
            #endregion

            #region Notları Al
            //vize1 notu, vize2 notu ve final notu alınacak(kontrollü olarak 100 lük sistemde)
            #region vize1 i al
            Console.Write("Lütfen vize 1 notunuzu giriniz: ");
            string input = Console.ReadLine();
            int vize1Notu;
            bool donustuMu = int.TryParse(input, out vize1Notu);
           if(!donustuMu || vize1Notu>100 || vize1Notu<0)
            {
                Console.Write("Hatalı bir vize notu girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region vize2 i al
            Console.Write("Lütfen vize 2 notunuzu giriniz: ");
            input = Console.ReadLine();
            int vize2Notu;
          donustuMu = int.TryParse(input, out vize2Notu);
            if (!donustuMu || vize2Notu > 100 || vize2Notu < 0)
            {
                Console.Write("Hatalı bir vize notu girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion

            #region final notunu al
            Console.Write("Lütfen final notunuzu giriniz: ");
            input = Console.ReadLine();
            int finalNotu;
            donustuMu = int.TryParse(input, out finalNotu);
            if (!donustuMu || finalNotu > 100 || finalNotu < 0)
            {
                Console.Write("Hatalı bir final notu girdiniz.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion
            #endregion

            #region Ekran temizlenecek.
            Console.Clear();
            #endregion

            #region Ortalamayı hesapla
            //vize1 %20, vize2 %30 ve final %50 hesap oranları ile öğrencinin notu hesap edilecek. 
            int ortalama = (int)(vize1Notu * 0.2 + vize2Notu * 0.3 + finalNotu * 0.5);
            #endregion

            #region Sonucu Yaz
            //"Osman Yazıcı, Fizik dersinden 40 puan alıp kaldı/gecti." Geçme notu 70
            Console.Write(ogrenciSecimi + ", " + secilenDers + " dersinden " + ortalama + " puan alıp " + (ortalama>=70?"geçti":"kaldı"));
            Console.ReadKey();
            #endregion


        }
    }
}
