using System;

using System.Threading.Tasks; //TPL 

namespace Modul018_01_Task_Starten
{
    class Program
    {
        static void Main(string[] args)
        {
            Task easyTask = new Task(MachEtwasInEinemThread); //Funktionszeiger wird übergeben
            easyTask.Start(); //threading.Start()
            easyTask.Wait(); //threading.Join 




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
