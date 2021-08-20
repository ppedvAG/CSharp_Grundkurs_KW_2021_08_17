using System;
using System.Threading;

namespace Modul017_04_ThreadBeenden
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MachEtwas);

            t.Start();
            //t.Join();
            Thread.Sleep(3000); // nach drei Sekunden wird der Thread aus der Main - Methoder heraus beendet
            t.Interrupt(); //Alternative zu Abort (Obselete) 


            
        }


        private static void MachEtwas() //Dieser Thread wird nach 10 Sekunden beendet
        {
            try
            {
                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("zzZZZzzzzzZZZZZZzzzzzzZZZZZZ"); //Wird nur 3 SEkunden ausgegeben, weil die Main Methode mit Interrupt den Thread von aussen beendet
                }
            }
            catch
            {

            }
        }
    }
}
