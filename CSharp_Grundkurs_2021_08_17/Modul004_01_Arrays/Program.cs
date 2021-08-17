using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul004_01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[5]; //ein Integer-Array von der Länge 5 

            zahlen[0] = default(int); //The Zero definition 

            string[] woerter = new string[] { "ppedv", "CSharp", "Grundkurs" }; //eine string-Array mit einer Laenge von drei

            double[] gleitkommzahlen = new double[] { 6.29, 1.58, 4.79, 6.55 };

            zahlen[0] = 1; //Index 0 -> Start-Index Wert
            zahlen[1] = 2;
            zahlen[2] = 3;
            zahlen[3] = 4;
            zahlen[4] = 5; //Index 4 -> End-Index Wert 
            //zahlen[5] -> OutOfRangeException (6te Element gib es nicht) 

            string wort1 = woerter[0]; //wort1 =>"ppedv"

            //Funktionen und Eigenschaften von Arrays
            int laenger = zahlen.Length; //länge eines Arrays mit der Property Length

            //Contains -> benötigt System.Linq;
            bool enthaelt = woerter.Contains("CSharp"); //true 
           
            //Min/Max -> benötigt System.Linq;
            double kleinsteZahl = gleitkommzahlen.Min(); //kleinster Wert im Array wird herausgegeben
            double hoechsteZahle = gleitkommzahlen.Max();
            double durschnittsWert = gleitkommzahlen.Average();
            double ersteZahl = gleitkommzahlen.First();
            double letzteZahl = gleitkommzahlen.Last();

            double sum = gleitkommzahlen.Sum();


            //Deklaration einer mehrdimensionalen Array
            int[,] zweiDimensionen;

            //zweidimensionale Array mit zwei Zeilen und fuenf Spalten initialisieren
            zweiDimensionen = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

            //zweidimensionale Array mit vier Zeilen und drei Spalten
            zweiDimensionen = new int[4, 3];

            //Zugriff ueber den Index
            int wert = zweiDimensionen[1, 2];

            //Zuweisung ueber den Index
            zweiDimensionen[2, 1] = 5;

            int[,,] array3D = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };

            //Anzahl der Dimensionen
            int dimensionen = array3D.Rank;//3

            //Anzahl aller Elemente
            int laenge3D = array3D.Length;//12

            //Laenge der einzelnen Dimensionen
            int laenge1 = array3D.GetLength(0);//2
            int laenge2 = array3D.GetLength(1);//3
            int laenge3 = array3D.GetLength(2);//2

            //-------------------------------------------------------------

            //Initialisierung durch setzen der Laenge
            int[][] verzweigteArray = new int[4][];

            //Initialisierung durch direkte Zuweisung der Elemente
            verzweigteArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 } };

            //Zugriff ueber Index
            int jaggedWert = verzweigteArray[0][2];// 3

            //Zuweisung ueber Index
            verzweigteArray[1][1] = 5;

            Console.ReadLine();
            
            //Nice to Know :-) 
            IList<int> myList = new List<int>(); //Intern dieser liste, wird ein Array verwendet!!!!! -> Default-Größe liegt bei items[3] -> 
        }
    }
}
