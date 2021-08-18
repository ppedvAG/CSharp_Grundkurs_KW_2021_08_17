using System;

namespace Modul007_02_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionaleParameter optionaleParameter = new();

            string[] myStrings = { "eins", "zwei", "drei" };
            
            
            string result1 = optionaleParameter.StringsVerbinden(myStrings);
            Console.WriteLine(result1);

            string result2 = optionaleParameter.StringsVerbinden(myStrings, '*');
            Console.WriteLine(result2);




            ParamsParameter paramsParameter = new ParamsParameter();
            paramsParameter.Addiere();
            paramsParameter.Addiere(1, 2, 3, 5, 6, 4);
            paramsParameter.Addiere(1, 2, 3, 5, 6, 4, 11,55,44,33);


            int min;
            int max;
            float avg;

            OutInRefParameter outParameter = new OutInRefParameter();
            float summe = outParameter.Berechne(22, 33, out min, out max, out avg);

            Console.WriteLine($"Gesamergebnis: {summe}");
            Console.WriteLine($"Minimaler Parameter {min}");
            Console.WriteLine($"Maximaler Wert {max}");
            Console.WriteLine($"Durchschnittswert {avg}");

        }
    }
}
