using System;

namespace Modul003_02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Akku-Eingabe:
            Console.Write("Gib den Akkustand ein: ");
            int akkuStand = int.Parse(Console.ReadLine());


            string akkuStatus = string.Empty;

            if (akkuStand > 20 && akkuStand <= 100) //wenn Bedingung wahr sind
            {
                akkuStatus = "Akku ist in Ordnung";
            }
            else if (akkuStand > 10 && akkuStand <= 20) //wenn vorherige Bedigung falsch ist und eigene Bedingung wahr ist
            {
                akkuStatus = "Akku sollte geladen werden.";
            }
            else if (akkuStand == 0)
            {
                akkuStatus = "Akku ist  fast leer";
            }
            else //Wenn keine Bedienung wahr ist. 
            {
                akkuStatus = "Akku ist defekt";
            }


            int myNumber = 33;

            bool result = myNumber == 33 ? true : false; //Inline - If Statement: bool rersult = [Condition] ? [True-Block] : [False-Block]

            DateTime dt = new DateTime(2003, 5, 1);

            string returnStr = string.Empty;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    returnStr = "Montag";
                    break; //gehe aus switch
                case DayOfWeek.Tuesday:
                    returnStr = "Dienstag";
                    break;
                case DayOfWeek.Wednesday:
                    returnStr = "Mittwoch";
                    break;
                case DayOfWeek.Thursday:
                    returnStr = "Donnerstag";
                    break;
                case DayOfWeek.Friday:
                    returnStr = "Freitag";
                    break;
                default:
                    returnStr = "Wochenende";
                    break;
            }

            //Shortcut: cw + Tab -> Console.WriteLine();
            Console.WriteLine(returnStr);


            Console.Write("Gib ein Obst ein>");
            string obst = Console.ReadLine();
            string farbe;
            switch (obst)
            {
                case "Kirsche":
                    farbe = "rot";
                    break;
                case "Banane": //wenn obst == "Banane" die kommende Anweisung ausfuehren
                case "Zitrone":
                    farbe = "gelb"; //Anweisung ist fuer "Banane" und "Zitrone" gleich
                    break;
                case "Orange":
                    farbe = "orange";
                    break;
                default:
                    farbe = "unbekannt";
                    break;
            }

            Console.WriteLine($"Obst: {obst} - Farbe {farbe}");
            Console.ReadLine();
        }
    }
}
