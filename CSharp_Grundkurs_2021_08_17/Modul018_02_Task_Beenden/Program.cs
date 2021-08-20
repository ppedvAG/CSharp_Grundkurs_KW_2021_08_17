using System;

using System.Threading;
using System.Threading.Tasks;

namespace Modul018_02_Task_Beenden
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            Task task = Task.Factory.StartNew(MeineMethodeMitAbbrechen, cts); //Die Methode wird sofort gestartet 
            Thread.Sleep(3000);

            cts.Cancel(); //Hier signalisieren wir, dass der Task abgebrochen werden soll.
            // cts.IsCancellationRequested wird intern auf true gesetzt
        }



        private static void MeineMethodeMitAbbrechen(object param)
        {
            CancellationTokenSource cts = (CancellationTokenSource)param;

            while (true)
            {
                Console.WriteLine("ZZZzzzz.....zzzZZZzz...Zzz.ZZ");
                Thread.Sleep(50);

                if (cts.IsCancellationRequested)
                    break;
            }
        }
    }
}
