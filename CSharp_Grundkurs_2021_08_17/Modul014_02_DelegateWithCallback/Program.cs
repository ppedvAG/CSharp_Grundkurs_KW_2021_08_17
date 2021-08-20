using System;

namespace Modul014_02_DelegateWithCallback
{

    public delegate void MessageDelegate(string message);

    class Program
    {
        public Person MeineAusgelesePerson { get; set; }

        static void Main(string[] args)
        {
            //Callback mit Delegate
            MessageDelegate messageDelegate = new MessageDelegate(FinishResultMethode);
            MethodWithCallback(11, 22, messageDelegate);

            //Callback mit Action
            Action<string> actionMessageDelegate = new Action<string>(FinishResultMethode);
            MethodWithCallback(22, 33, actionMessageDelegate);


            Action<Person> personDelegate = new Action<Person>(FinishResultWithReturnValue);
            MethodWithCallback(22, 33, personDelegate);
        }

        public static void MethodWithCallback(int param1, int param2, MessageDelegate messageDelegate)
        {
            //Es wird hier viel berechnet... 
            //.... 


            messageDelegate("The number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }


        public static void MethodWithCallback(int param1, int param2, Action<string> messageDelegate)
        {
            //Es wird hier viel berechnet... 
            messageDelegate("The number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }

        public static void MethodWithCallback(int param1, int param2, Action<Person> personDelegate)
        {
            //Es wird hier viel berechnet... 
            //Invoke auf FinishResultMethode


            //Lese Person aus
            Person person = new Person();
            person.Id = 123;
            person.Name = "Harry Weinfuhrt";

            personDelegate(person);
        }

        public static void FinishResultMethode(string message)
        {
            Console.WriteLine(message);
        }

        public static void FinishResultWithReturnValue(Person person)
        {
            //Mach was mit dieser Person 


        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
