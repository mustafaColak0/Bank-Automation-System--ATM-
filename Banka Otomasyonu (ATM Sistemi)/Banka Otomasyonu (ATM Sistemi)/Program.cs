using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu__ATM_Sistemi_
{

    internal class Program
    {
        // 1. ADIM:  Müşteri sınıfı oluşturuyoruz.
        public class Musteri
        {
            public string Ad;
            public string Sifre;
            public double Bakiye;

            // yapıcı metot oluşturduk.
            public Musteri(string gelenAd, string gelenSifre, double gelenBakiye)
            {
                Ad = gelenAd;
                Sifre = gelenSifre;
                Bakiye = gelenBakiye;
            }

            // Para yatırma Metodu
            public void ParaYatir(double miktar)
            {
                Bakiye += miktar; //bakiye=bakiye+miktar
                Console.WriteLine(miktar + " Tl Yatırıldı. Güncel Bakiye: " + Bakiye + " TL");
            }

            // Para Çek Metodu (kontrol mekanizması oluşturduk)
            public void ParaCek(double miktar)
            {
                if (miktar <= Bakiye)
                {
                    Bakiye -= miktar;
                    Console.WriteLine(miktar + " Tl Çekildi. Güncel Bakiye: " + Bakiye + " TL");
                }
                else
                {
                    Console.WriteLine(" Yetersiz Bakiye ! Mevcut Bakiyeniz: " + Bakiye + "TL");
                }
            }
        }
        static void Main(string[] args)
        {
            // Bankada kayıtlı olan müşteri nesnesini oluşturuyoruz.
            Musteri musteri1 = new Musteri("Mustafa", "1234", 1000);

            // 2. ADIM : Giriş Paneli (doğru girilene kadar)
            while (true)
            {
                Console.WriteLine("Bankamıza Hoşgeldiniz");
                Console.WriteLine("Lütfen kullanıcı Adınızı Giriniz:");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Lütfen şifrenizi Giriniz:");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == musteri1.Ad && sifre == musteri1.Sifre)
                {
                    Console.WriteLine("Giriş Başarılı Hoşgeldiniz " + musteri1.Ad);
                    Console.WriteLine("------------------------");
                    break;//döngüden çıkıyor
                }
                else
                {
                    Console.WriteLine("Hatalı giriş , Tekrar deneyiniz");
                    Console.WriteLine();
                }

            }

            // 3. ADIM: ANA İŞLEM MENÜSÜ
            while (true)
            {
                // TRY-CATCH: Harf girilince programın çökmesini engeller.
                try
                {
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("1- Bakiye Sorgula");
                    Console.WriteLine("2- Para Yatır");
                    Console.WriteLine("3- Para Çek");
                    Console.WriteLine("4- Çıkış");


                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim)
                    {
                        // sadece bakiyeyi yazdırıyoruz 
                        case 1:
                            Console.WriteLine("Bakiyeniz : " + musteri1.Bakiye + "TL");
                            break;
                        // para yatırma işlemi

                        case 2:
                            Console.WriteLine("Kaç para yatırmak istersiniz: ");
                            double yatirilacakmiktar = Convert.ToDouble(Console.ReadLine());
                            musteri1.ParaYatir(yatirilacakmiktar); //sınıfın içindeki metodu çağırdık
                            break;

                        // para çekme işlemi
                        case 3:
                            Console.WriteLine("Kaç para çekeceksiniz");
                            double cekilecekmiktar = Convert.ToDouble(Console.ReadLine());
                            musteri1.ParaCek(cekilecekmiktar);
                            break;

                        // çıkış
                        case 4:
                            Console.WriteLine("Bankamızı tercih ettiğiniz için teşekkürler. Çıkış yapılıyor...");
                            return; //Tüm main metodunu bitirir , programı kapatır

                        default:

                            Console.WriteLine("Geçersiniz seçenek! Lütfen tekrar deneyin.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n Hata: Lütfen doğru formatı giriniz");
                }

                Console.ReadLine();
            }
        }
    }
}
