using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modul018_08_TaskWhenAllSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Task<int>> tasks = new List<Task<int>>();
            
            
            
            List<Task<string>> tasks1 = new List<Task<string>>();

            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int baseValue = ctr;
                tasks.Add(Task.Factory.StartNew(b => (int)b * (int)b, baseValue));

                //Weiteres Beispiel > geht auch mit strings
                tasks1.Add(Task.Factory.StartNew(b => b.ToString(), baseValue));
            }

            // Task.WaitAll() -> WaitAll gibt keine Rückgabewerte zurück (im Gegensatz zu WhenAll)
            int[] results = await Task.WhenAll(tasks);
            string[] stringResults = await Task.WhenAll(tasks1);


            int sum = 0;
            for (int ctr = 0; ctr <= results.Length - 1; ctr++)
            {
                var result = results[ctr];
                Console.Write($"{result} {((ctr == results.Length - 1) ? "=" : "+")} ");
                sum += result;
            }

        }
    }
}
