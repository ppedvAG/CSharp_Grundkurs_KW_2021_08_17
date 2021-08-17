using System;


namespace Modul002_02_Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //einfache Rechenoperatoren
            int zahl1 = 4;
            int zahl2 = 2;

            int addition = zahl1 + zahl2;       // 4 + 2 => 6
            int substraktion = zahl1 - zahl2;   // 4 - 2 => 2
            int multiplikation = zahl1 * zahl2; // 4 * 2 => 8
            int division = zahl1 / zahl2;     // 4 / 2 => 2

            int zahl3 = 14;
            int zahl4 = 3;
            int modulo = zahl3 % zahl4; // 14 % 3  => 2 

            Random rd = new Random();

            //bekommen irgendeine Zufallszahl....von 0 bis 32.678
            int result = rd.Next();

            //Zufallswert zwischen 0 und 99 
            int randomNumber = result % 100;

            //einfache Rechenoperatoren als Kurzform
            int zahl5 = 10;


            Console.WriteLine(++zahl5); //11
            
            zahl5 = 10;
            Console.WriteLine(zahl5++); //10


            zahl5++;        //zahl5 = zahl5 + 1 => 11
            zahl5--;        //zahl5 = zahl5 - 1 => 10

            zahl5 += 2;     //zahl5 = zahl5 + 2 => 12
            zahl5 -= 6;     //zahl5 = zahl5 - 6 => 6

            zahl5 *= 10;    //zahl5 = zahl5 * 10 => 60
            zahl5 /= 3;     //zahl5 = zahl5 / 3 => 20

            //Gleitkommazahlen runden
            double zahl6 = Math.Round(4.89); //kaufm. Runden => 5
            double zahl7 = Math.Ceiling(4.14); //immer aufrunden => 5;
            double zahl8 = Math.Floor(4.76); //immer abrunden => 4;
            
            //Minimal und Maximal
            int zahl9 = 12;
            int zahl10 = 65;
            int zahl11 = Math.Min(zahl9, zahl10); //12
            int zahl12 = Math.Max(zahl9, zahl10); //65
        }
    }
}
