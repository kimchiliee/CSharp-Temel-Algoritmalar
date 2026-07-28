using System;

namespace MetotlarVeParams
{
    class Program
    {
        // 'params' anahtar kelimesi, metoda önceden bir dizi boyutu belirtmeden 
        // istediğimiz kadar parametre göndermemizi sağlar. Mülakatların favori sorularındandır.
        public static int ElemanlariTopla(params int[] dizi)
        {
            int toplam = 0;
            
            // Senin kodunda burada 'arr' yazıyordu, onu metoda gelen 'dizi' ile değiştirdim.
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Params Anahtar Kelimesi Kullanımı ---\n");

            // params sayesinde önceden int[] array = new int[...] dememize gerek kalmaz.
            // Sayıları direkt virgülle ayırarak metoda gönderebiliriz.
            int hesaplananToplam = ElemanlariTopla(512, 720, 250, 567, 889);
            
            Console.WriteLine("Gönderilen Sayıların Toplamı: " + hesaplananToplam);
            
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
