using System;
using System.Threading.Tasks;

namespace Modul018_09_AsyncAwaitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Mit Task Objekt
            Task<string> task = Task.Run(DayTime);
            //task.Wait();
            //string result = task.Result;

            Task myTask = task.ContinueWith(task => ShowDayTime(task.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            myTask.Wait();


            string theCoolerReturnValue = await Task.Run(DayTime);  //await sagt...ich warte bis ergebnis da ist (gegensatz zu Task.Wait()) 
            await Task.Run(()=>ShowDayTime(theCoolerReturnValue)); 

        }

        public static string DayTime()
        {
            DateTime date = DateTime.Now;

            return date.Hour > 17
                ? "evening"
                : date.Hour > 12
                ? "afternoon"
                : "morning";
        }


        public static void ShowDayTime(string result)
        {
            Console.WriteLine(result);
        }
    }
}
