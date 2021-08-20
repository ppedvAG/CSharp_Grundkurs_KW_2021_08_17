using System;
using System.Threading;

namespace Modul017_01_ThreadStarten
{
    class Program
    {
        static void Main(string[] args)
        {
            //using System.Threading;
            Thread thread = new Thread(MachEtwasInEinemThread); //Übergeben Funktionszeiger in Thread 
            thread.Start(); //Der Thread wird gestartet->MachEtwasInEinemThread wird via Invoke gecalled. 
            thread.Join(); //Wir warten, bis der Thread fertig ist 

            for (int i = 0; i < 100; i++)
                Console.Write("*");

            Console.ReadLine();
        }



        /// <summary>
        /// Diese Funktion läuft in einem seperaten Thread 
        /// </summary>
        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("#");
        }
    }
}
