using System;
using System.Collections.Generic;

namespace Modul003_03_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Die Zählschleife
            Console.WriteLine("inkrementale for-schleife");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}, ");
            }//0, 1, 2, 3, 4, 5, 6, 7, 8, 9,

            Console.WriteLine("\n"); //Zeilenumbruch

            for (int i = 10; i > 0; i--)
            {
                //zaehlt nach jedem Durchlauf  i - 1  solange die Bedingung "i > 0" erfuellt ist
                Console.Write($"{i}, ");
            }
            //10, 9, 8, 7, 6, 5, 4, 3, 2, 1,
            Console.WriteLine("\n");
            #endregion



            // Schleifen auf Arrays/Listen/Enums
            int[] zahlen = new int[] { 1, 5, 7, 9, 4, 2, 6, 45, 581 };

            //eine Array mit einer for-Schleife durchlaufen
            Console.WriteLine("Array mit for-Schleife");
            for (int i = 0; i < zahlen.Length; i++)
            {
                //ueber den Index i muss auf das Element zugegriffen werden
                Console.Write($"{zahlen[i]}, ");
            }
            //1, 5, 7, 9, 4, 2, 6, 45, 581
            int[] zahl1 = null;
            List<string> listeMitStrings = new List<string>();

            foreach (string currentString in listeMitStrings)
            {
                //Kommt nicht hier in den Logik-Block, wenn die ListeMitStirngs (leer) ist 
            }

            foreach (int currentNumber in zahlen)
            {
                Console.WriteLine(currentNumber);
            }


            //kopfgesteuerte Schleife (while)
            string bedingung = "falsch";
            while (bedingung == "wahr")
            {
                //prueft vor jedem Durchlauf 
                //ob Bedingung true ist
            }

            //fussgesteuerte Schleife (do-while)
            do
            {
                //fuehrt erst aus und prüft dann
                //beginnt von vorne wenn 
                //Bedingung true ist
            } while (bedingung == "wahr");


            //Schluesselwort continue
            //beendet den aktuellen Durchlauf und springt zur naechsten Ueberpruefung
            Console.WriteLine("Schluesselwort continue");
            for (int i = 0; i < 10; i++)
            {
                //durch drei teilbar

                if (i % 3 == 0)
                    continue; //neuen Schleifendurchlauf -> Console.Write wird nicht ausgeführt 

                Console.Write($"{i}, ");
            }
            //0, 1, 2, 4, 5, 7, 8,
            Console.WriteLine("\n");

            //Schluesselwort break
            //beendet den die komplette Schleife
            Console.WriteLine("Schluesselwort break");
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                    break; //Springt aus der Schleife heraus. 

                Console.Write($"{i}, ");
            }
            //0, 1, 2, 3, 4, 5, 

            Console.ReadLine();


        }
    }
}