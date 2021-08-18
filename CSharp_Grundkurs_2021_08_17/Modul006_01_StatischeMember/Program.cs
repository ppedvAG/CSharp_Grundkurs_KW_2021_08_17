using System;

namespace Modul005_01_StatischeMember
{
    class Program
    {
        static void Main(string[] args)
        {
            //Einstieg ins Programm 


            //Aufruf einer statischen Methode durch [Klassenname].[Methodenname]()
            Console.WriteLine("Text");
        } 


        static void SummeAusgeben(int zahl1, int zahl2)
        {
            int summe = zahl1 + zahl2;

            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}");
        }

        static void SummeAusgeben(int zahl1, int zahl2, int zahl3 )
        {
            int summe = zahl1 + zahl2 + zahl3;

            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} und {zahl3} ist {summe}");
        }


        static void TestMe ()
        {
            string[] myArgs = { "Eins", "Zwei" };
            Program.Main(myArgs);

            Program.SummeAusgeben(12, 12);
        }
    }
}
