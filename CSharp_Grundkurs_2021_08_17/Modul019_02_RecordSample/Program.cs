using System;

namespace Modul019_02_RecordSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRecord personRecord1 = new PersonRecord(1, "Mario Bart");
            PersonRecord personRecord2 = new PersonRecord(1, "Mario Bart");


            PersonRecord personRecord3 = personRecord1 with { Name = "Kevin" }; //Beim Kopierren, bzw initiieren von personRecord3 kann man bei WITH den Datensatz nochmals manipulieren.

            MyPerson myPerson1Class = new MyPerson(1, "Helge Schneider");
            MyPerson myPerson2Class = new MyPerson(1, "Helge Schneider");




            #region == Operator
            //== Operator
            if (myPerson1Class == myPerson2Class)
            {
                Console.WriteLine("myPerson1Class == myPerson2Class -> gleich");
            }
            else
            {
                Console.WriteLine("myPerson1Class == myPerson2Class -> ungleich");
            }

            // == Operator
            if (personRecord1 == personRecord2)
            {
                Console.WriteLine("personRecord1 == personRecord2 -> gleich");
            }
            else
            {
                Console.WriteLine("personRecord1 == personRecord2 -> ungleich");
            }
            #endregion

            #region Equal
            if (myPerson1Class.Equals(myPerson2Class))
            {
                Console.WriteLine("myPerson1Class.Equals(myPerson2Class) -> gleich");
            }
            else
            {
                Console.WriteLine("myPerson1Class.Equals(myPerson2Class) -> ungleich");
            }

            if (personRecord1.Equals(personRecord1))
            {
                Console.WriteLine("personRecord1.Equals(personRecord2) -> gleich");
            }
            else
            {
                Console.WriteLine("personRecord1.Equals(personRecord2) -> ungleich");
            }
            #endregion
            

            Console.WriteLine(personRecord1.GetHashCode()); //Ist in Records ausimplementiert // In Klassen muss GetHastCode überschrieben werden. 

            Console.WriteLine("myPerson1Class.ToString()" + myPerson1Class.ToString());
            Console.WriteLine("personRecord1.ToString() : " + personRecord1.ToString());

            int identity;
            string theName;
            //Hier bekomme ich aus dem Person Record alles Property Variablen als Rückgabe geliefert. 
            personRecord1.Deconstruct(out identity, out theName);

            (int id, string name) = personRecord1; //ruft den Deconstruct auf

            (int id2, string name2) = myPerson2Class;

            EmployeeRecord employeeRecord = new EmployeeRecord(2, "Daniel Roth", 10000);
            //employeeRecord.Gehalt = 123; //Geht nicht -> Gehalt ist mit Init geschützt.

        }
    }

    // Das ist ein Record in kompakter Schreibweise
    public record PersonRecord(int Id, string Name); //Properties werden per Default mit set;init; angegeben

    public record EmployeeRecord : PersonRecord
    {
        public decimal Gehalt { get; init; }

        public EmployeeRecord(int Id, string Name)
            : base(Id, Name)
        {

        }

        public EmployeeRecord(int Id, string Name, decimal Gehalt)
           : base(Id, Name)
        {
            this.Gehalt = Gehalt;
        }
    }

    public class MyPerson 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //ctor + tab + tab -> Konstruktor
        public MyPerson(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }


        public void Deconstruct (out int Id, out string Name)
        {
            Id = this.Id;
            Name = this.Name;
        }

        //public override Equals

        //public override == Operator

        //public override GetHashCode

        //public override ToString() 

        
    }


}
