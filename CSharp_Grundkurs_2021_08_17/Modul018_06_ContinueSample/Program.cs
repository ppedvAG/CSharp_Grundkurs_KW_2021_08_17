using System;
using System.Threading;
using System.Threading.Tasks;


namespace Modul018_06_ContinueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task Objekt- Mit einer anoymen Methoden
            Task t1 = new Task(() =>
            {
                Console.WriteLine("Task 1 ist gestartet");
                Thread.Sleep(1000);
                throw new Exception();
            });

            t1.Start();
            

            t1.ContinueWith(t =>
            {
                Console.WriteLine("Fortlaufender Task - TaskContinuationOptions.OnlyOnRanToCompletion");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            t1.ContinueWith(t =>
            {
                Console.WriteLine("Fortlaufender Task - TaskContinuationOptions.OnlyOnFaulted");
            }, TaskContinuationOptions.OnlyOnFaulted);




            //Allgemeiner Folgetask 
            Task t2 = t1.ContinueWith(t =>
            {
                Console.WriteLine("Allgemeiner Folgetask");
            });


            //Task t3 = t2.ContinueWith(t =>
            //{
            //    Console.WriteLine("Übernächster Folgetask");
            //});




            Console.ReadLine();
        }
    }
}
