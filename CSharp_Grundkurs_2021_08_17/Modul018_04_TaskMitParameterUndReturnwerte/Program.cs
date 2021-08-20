using System;
using System.Threading.Tasks;

namespace Modul018_04_TaskMitParameterUndReturnwerte
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze katze = new();

            //Task das alleine da steht, verwendet Methoden die ein VOID zurück gebeen
            Task easyTask = new Task(MachEtwasInEinemThread); //Dieser Task, weiß, dass er kein ReturnValue erhält. 
            easyTask.Start();
            
            //Task erwartet einen string als Rückgabetyp
            Task<string> task1 = new Task<string>( ()=>MachEtwas(katze) );    //Wir übergeben ein Katzen-Object 
            task1.Wait();
            string retValue1 = task1.Result;


            Task<string> task2 = new Task<string>(() => MachEtwas(katze, DateTime.Now));
            task2.Wait();
            string retValue2 = task2.Result;


            //VIA FACTORY
            Task<string> task3 = Task.Factory.StartNew(MachEtwas, katze);
            task3.Wait();
            string result1 = task3.Result;

            //via Task.Run

            //Task.Run<string> gibt an, dass ein String zurück gegeben wird
            Task<string> task4 = Task.Run<string>(() => MachEtwas(katze));
            task4.Wait();
            string result2 = task4.Result;


        }



        private static string MachEtwas(object input)
        {
            if (input is Katze myCat)
                return myCat.Name; //Maya wird zurück gegeben

            throw new AggregateException();
        }

        private static string MachEtwas(object input, DateTime dateTime)
        {

            Console.WriteLine(((Katze)input).Name);
            Console.WriteLine(dateTime.ToShortDateString());

            return dateTime.ToShortDateString();
        }

        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
            }
        }
    }

    public class Katze
    {
        public string Name { get; set; } = "Maya";
    }
}
