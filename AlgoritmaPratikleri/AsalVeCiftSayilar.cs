using System;

namespace AlgoritmaVeProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Asal, Tek ve Çift Sayı Ayrıştırıcı ---");
            Console.Write("Lütfen bir sınır değeri giriniz: ");
            
            // Kullanıcının harf veya geçersiz bir değer girmesini engelliyoruz
            if (!int.TryParse(Console.ReadLine(), out int sinir) || sinir < 2)
            {
                Console.WriteLine("Lütfen 2'den büyük geçerli bir tam sayı giriniz.");
                return;
            }

            string asalSayilar = "";
            string tekSayilar = "";
            string ciftSayilar = "";

            int tekToplam = 0, ciftToplam = 0;

            // 2'den başlayarak sınır değerine kadar tüm sayıları tarıyoruz
            for (int i = 2; i <= sinir; i++)
            {
                // 1. ADIM: Çift ve Tek Ayrımı
                if (i % 2 == 0)
                {
                    ciftSayilar += i + " ";
                    ciftToplam += i;
                }
                else
                {
                    tekSayilar += i + " ";
                    tekToplam += i;
                }

                // 2. ADIM: Asal Sayı Kontrolü
                bool asalMi = true;
                
                // Matematiksel bir kural: Bir sayının kareköküne kadar olan sayılara tam bölünmüyorsa asaldır.
                // Bu yöntem, döngünün gereksiz yere binlerce kez dönmesini engeller (Optimizasyon).
                for (int j = 2; j <= Math.Sqrt(i); j++) 
                {
                    if (i % j == 0)
                    {
                        asalMi = false;
                        break; // Tam bölen bulunduysa daha fazla aramaya gerek yok
                    }
                }

                // Eğer sayı asalsa listemize ekliyoruz
                if (asalMi)
                {
                    asalSayilar += i + " ";
                }
            }

            // Sonuçları Ekrana Yazdırma
            Console.WriteLine("\n--- SONUÇLAR ---");
            Console.WriteLine("Tek Sayılar: " + tekSayilar);
            Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
            
            Console.WriteLine("\nÇift Sayılar: " + ciftSayilar);
            Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);
            
            Console.WriteLine("\nAsal Sayılar: " + asalSayilar);

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
