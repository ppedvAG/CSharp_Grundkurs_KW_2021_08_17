using System;
using System.Threading;

namespace Modul017_03_ThreadStartenMitParameterUndReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string retStr = string.Empty;

            Thread thread = new Thread(() =>
            {
                //Das ist eine Anonyme Methode und diese läuft schon im Thread
                retStr = StringToUpper("Hello World");

            });

            thread.Start();
            thread.Join();


            Console.WriteLine(retStr);
            Console.ReadLine();
        }


        public static string StringToUpper(string param1)
        {
            return param1.ToUpper();
        }
    }
}
