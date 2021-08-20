using System;
using System.Linq;
using System.Collections.Generic;

namespace Modul015_01_LinqLamdaSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>()
            {
                new Person {Id=1, Age=37, Vorname="Kevin", Nachname="Winter"},
                new Person {Id=2, Age=29, Vorname="Hannes", Nachname="Preishuber"},
                new Person {Id=3, Age=19, Vorname="Scott", Nachname="Hunter"},

                new Person {Id=4, Age=21, Vorname="Scott", Nachname="Hanselmann"},
                new Person {Id=5, Age=45, Vorname="Daniel", Nachname="Roth"},
                new Person {Id=6, Age=50, Vorname="Bill", Nachname="Gates"},

                new Person {Id=7, Age=70, Vorname="Newton", Nachname="King"},
                new Person {Id=8, Age=40, Vorname="Andre", Nachname="R"},
                new Person {Id=9, Age=60, Vorname="Petra", Nachname="Musterfrau"},
            };

            //Linq Statements -> wurden verwendet von LinqToSql (O/R-Mapper, Status: inaktiv) 

            //wird benötigt -> using System.Linq;
            IList<Person> linqStatementResult = (from p in persons
                                                 where p.Age >= 40 && p.Age < 50
                                                 orderby p.Nachname
                                                 select p).ToList();


            //Linq-Functionen (where / orderby) mit Lambda-Expressions: p => p.Age >= 40 && p.Age < 50
            IList<Person> people = persons.Where(p => p.Age >= 40 && p.Age < 50)
                                          .OrderBy(o => o.Nachname)
                                          .ThenBy(secondCriterium => secondCriterium.Vorname)
                                          .ToList();

            IList<Person> people1 = persons.Where(p => p.Age >= 40 && p.Age < 50)
                              .OrderByDescending(o => o.Nachname)
                              .ThenBy(secondCriterium => secondCriterium.Vorname)
                              .ToList();


            //result.Count
            if (people.Count > 0)
            {
                //we have people inside the list
            }


            //result
            if (people.Any())
            {
                //we have people inside the list
            }


            //source
            if (persons.Any(p=>p.Age > 100))
            {
                // If you are here, you found a Person with over 100 years :-) 
            }


            //Allgemeiner Altersdurchschnit. 
            double altersdurchschnitt = persons.Average(a => a.Age);

            double gesamtAlterAllerPersonen = persons.Sum(a => a.Age);

            //Altersdurschnitt von Mitarbeiter, die über 40 sind. 
            double altersdurschnitt1 = persons.Where(p => p.Age > 40).Average(a => a.Age);


            Person selectedPerson = persons.Single(s => s.Id == 4);

            Person firstPerson = persons.First(); //Ersten Datensatz von der Liste
            Person lastPerson = persons.Last();

            //SingleDefault / FirstOrDefault / LastOrDefault ->Default ist null
            Person defaultPerson = persons.SingleOrDefault(s => s.Id == 10);

            //int value = default(int);
            //string strValue = default(string);

            //Get correct person or null
            Person person = persons.SingleOrDefault(s => s.Id == 10);

            //i get a person?
            if (person != null)
            {
                Console.WriteLine($"{person.Vorname} {person.Nachname}" );
            }

            int pagingNumber = 1; //Aktuell Seite 
            int pagingSize = 3; //Anzahl der Elemente, die auf einer Seite angezeigt werden


            //Paging wird auf der WebAPI Seite implementiert 
            //Seite
            IList<Person> ergebnisSeite1 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();

            //Seite 2
            pagingNumber = 2;
            IList<Person> ergebnisSeite2 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();


            //Seite 3
            pagingNumber = 3;
            IList<Person> ergebnisSeite3 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();

        }
    }



    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}
