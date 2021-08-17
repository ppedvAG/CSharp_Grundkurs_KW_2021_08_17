using System;

namespace Modul005_01_StatischeMember
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufruf einer statischen Methode durch [Klassenname].[Methodenname]()
            Console.WriteLine("Text");
        } 


        public static void SummeAusgeben(int zahl1, int zahl2)
        {
            int summe = zahl1 + zahl2;

            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}");
        }


        public static void TestMe ()
        {
            string[] myArgs = { "Eins", "Zwei" };
            Program.Main(myArgs);

            Program.SummeAusgeben(12, 12);
        }
    }
}
