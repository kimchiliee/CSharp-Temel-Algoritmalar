using System;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[200];
            Random rnd = new Random();

            Console.WriteLine("--- Dizinin İçine Rastgele Sayılar Atanıyor ---");

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 500);
                Console.WriteLine((i + 1) + ". eleman -> " + dizi[i]);
            }

            Console.WriteLine("\nİşlem tamamlandı. Çıkmak için Enter'a basın...");
            Console.ReadLine();
        }
    }
}
