using System;

namespace Modul006_03_PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Alter = 33;
            person.Gewicht = 77;

            person.SteheAuf();
            person.GeheArbeiten();


            Person person1 = new(); //C# 9.0 

        }
    }
}
