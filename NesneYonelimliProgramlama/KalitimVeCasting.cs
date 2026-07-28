using System;

namespace NesneYonelimliProgramlama
{
    internal class Ornek
    {
        public int TemelSayi { get; set; }
        
        public void TemelMetot()
        {
            Console.WriteLine("Ata sınıfın metodu çalıştı.");
        }
    }

    internal class GelismisOrnek : Ornek
    {
        public int NoSayi { get; set; } 
        
        public void GelismisMetot()
        {
            Console.WriteLine("Oğul sınıfın gelişmiş metodu çalıştı.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Kalıtım ve Tip Dönüşümü (Casting) ---");

            GelismisOrnek gercekGelismisNesne = new GelismisOrnek();
            gercekGelismisNesne.NoSayi = 90;
            gercekGelismisNesne.TemelSayi = 10;

          Ornek ataReferans = gercekGelismisNesne; 
            
            Console.WriteLine("\nUpcasting Başarılı!");
            ataReferans.TemelMetot();

           GelismisOrnek geriDonusenNesne = (GelismisOrnek)ataReferans;
            
            Console.WriteLine("\nDowncasting Başarılı!");
            Console.WriteLine("Geri alınan NoSayi değeri: " + geriDonusenNesne.NoSayi); // 90 değerini başarıyla okuruz


          
            Console.ReadLine();
        }
    }
}
