using System;
using System.Diagnostics; // Debug - StopWatch.Start / StopWacht.Restart + StopWatch.Stop -> ergebnis StopWatch .> Millisec
using System.Text;

namespace Modul001_02_DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Agrumente Ausgeben
            if (args.Length > 1)
                Console.WriteLine(args[0], args[1]);
            #endregion

            #region Write-Methode Sample
            Console.Write("Text ohne abschließenden Zeilenumbruch");
            Console.Write("Und dieser Text, steht auch in der selben Zeile");
            #endregion

            #region OutputEncoding

            //Vorsicht Debug.WriteLine verlangsamt die Performance der App
            Debug.WriteLine("Hallo ich stehe nicht Konsole....sonder bin das kleine Persönchen im Output-Fenster");
            Console.WriteLine("###Output Encoding");
            Console.WriteLine("Eurozeichen: €");
            Console.WriteLine("Default Output Encoding: {0}", Console.InputEncoding.EncodingName); // Westeuropaeisch (DOS)
            Console.OutputEncoding = Encoding.Unicode; //assembly -> System.Text
            Console.WriteLine("Eurozeichen: €");
            #endregion

            #region ReadLine()
            Console.WriteLine("### ReadLine() ###");
            Console.WriteLine("Wie teuer darf das Hotelzimmersein?");
            Console.InputEncoding = Encoding.Unicode;
            string zimmerPreis = Console.ReadLine(); //Eingabe muss mit Enter bestätigt werden
            Console.WriteLine($"Sie haben folgenden Betrag eingegeben {zimmerPreis}"); //ab C# 7.0 
            #endregion

            //CMD->CLS Befehl 
            Console.Clear();
            Console.WriteLine("### ReadKey() ###");
            Console.WriteLine("(1) Menüpunt A");
            Console.WriteLine("(2) Menüpunt B");
            Console.WriteLine("(3) Menüpunt C");


            Console.Write("Input>");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            Console.Clear();
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Anzeige Menüpunkt A");
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("Anzeige Menüpunkt B");
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D3 || consoleKeyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine("Anzeige Menüpunkt C");
            }
            else
            {
                Console.WriteLine("Falsche Eingabe");
            }
            
        }
    }
}
