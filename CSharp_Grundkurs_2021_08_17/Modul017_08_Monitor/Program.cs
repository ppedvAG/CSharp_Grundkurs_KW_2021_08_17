using System;
using System.Threading;

namespace Modul017_08_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        static void KritischerCodeAbschnitt()
        {
            int x = 1;


            Monitor.Enter(x);//Es darf hier nur ein Thread arbeit. Weitere Threads müssen warten..

            try
            {
                //callen weitere Methoden 
                //if-else Struktur
            }
            finally
            {
                Monitor.Exit(x);
            }
        }
    }
}
