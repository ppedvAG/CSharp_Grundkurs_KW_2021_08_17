using System;

namespace Modul007_01_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new("Otto", "Walkes", DateTime.Now, 11);

            using(Person person = new Person("Otto","Walkes"))
            {

            } //Hier wird das Objekt abgebaut (auch bei Fehler) 

            //Wo werden ssings verwendet -> FileStream (Dateien schreiben und zugreifen)



        }// Variable person1 wird hier durch GC abgebaut 
    }
}
