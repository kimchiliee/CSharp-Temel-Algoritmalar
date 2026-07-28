using System;

namespace SinavlaraHazirlik
{
    class Program
    {
        static void Main(string[] args)
        {
            // 25 elemanlı bir diziye 0 ile 100 arasında rastgele BENZERSİZ sayılar atama
            // a) tek ve çift sayılar ayrılsın
            // b) her sayı farklı olacak
            
            Random rnd = new Random();
            int[] dizi = new int[25];

            Console.WriteLine("--- Benzersiz Rastgele Sayılar (Tek/Çift Ayrımı) ---\n");

            // Dizinin 25 elemanını da tek tek doldurmak için dönüyoruz
            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi;
                bool varMi;
                
                // Benzersiz sayı bulana kadar çalışacak döngü
                do
                {
                    sayi = rnd.Next(0, 101); // 0 dahil, 101 hariç (yani 100'e kadar)
                    varMi = false;

                    // Üretilen bu "sayi", dizinin daha önceki indekslerinde var mı diye kontrol ediyoruz
                    for (int j = 0; j < i; j++)
                    {
                        if (dizi[j] == sayi)
                        {
                            varMi = true; // Sayı zaten dizide var!
                            break;        // Aramayı durdur, do-while tekrar başlasın
                        }
                    }
                } while (varMi); // Eğer varMi 'true' olduysa başa dönüp yeni sayı üretir

                // Eğer buraya kadar geldiysek sayı benzersizdir, diziye gönül rahatlığıyla ekleyebiliriz
                dizi[i] = sayi;
            }

            // Çift Sayıları Ekrana Yazdırma
            Console.WriteLine("ÇİFT SAYILAR:");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }

            // Araya biraz boşluk bırakalım ki çıktılar karışmasın
            Console.WriteLine("\n\nTEK SAYILAR:");
            
            // Tek Sayıları Ekrana Yazdırma
            foreach (var item in dizi)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine("\n\nİşlem tamamlandı. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
