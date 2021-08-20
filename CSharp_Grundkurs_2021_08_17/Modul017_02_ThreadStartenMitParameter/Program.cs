using System;
using System.Threading;

namespace Modul017_02_ThreadStartenMitParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methode -> MachEtwasInEinemThread muss ein object als Parameter vorweisen 
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(MachEtwasInEinemThread);

            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start(600);

            thread.Join();

            for (int i = 0; i < 100; i++)
                Console.Write("*");

            Console.ReadLine();
        }

        private static void MachEtwasInEinemThread(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.Write("#");
            }
        }
    }
}
