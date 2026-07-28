using System;

namespace Polymorphism
{
    internal class Cizici
    {
       public virtual void Ciz()
        {
            Console.WriteLine("Temel çizici nesnesi çalıştı.");
        }
    }
   internal class DogruCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Bir doğru (çizgi) çizildi.");
        }
    }

    internal class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Bir kare çizildi.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Çok Biçimlilik (Polymorphism) Örneği ---\n");

            Cizici[] test = new Cizici[3];
            test[0] = new Cizici();
            test[1] = new DogruCiz();
            test[2] = new KareCiz();

            foreach (var item in test)
            {
                Console.WriteLine("Çalışan Sınıf: " + item.GetType().Name); 
                
                item.Ciz(); 
                
                Console.WriteLine("-------------------------");
            }
            
            Console.ReadLine();
        }
    }
}
