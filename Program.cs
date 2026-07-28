using System;

namespace AlgveProgGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- For Döngüsü Kullanımı ---");
            // Sektörde bu tarz işlemler için en çok kullanılan yapı "for" döngüsüdür.
            // Başlangıç değerini, şartı ve artış miktarını tek satırda belirleriz.
            for (int sayi = 1; sayi <= 10; sayi++)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\n--- While Döngüsü Kullanımı ---");
            // Alternatif olarak, senin yazdığın mantığa en yakın yapı "while" döngüsüdür.
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++; 
            }

            // Konsolun hemen kapanmasını engellemek için
            Console.ReadKey();
        }
    }
}
