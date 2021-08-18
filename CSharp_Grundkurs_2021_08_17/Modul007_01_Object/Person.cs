using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_01_Object
{
    public class Person : IDisposable
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag { get; set; }

        public int HaarFarbe { get; set; }

        

        #region Konstruktor
        Person (DateTime Geburtstag) //default ist privat
        {
            this.Geburtstag = Geburtstag;
        }
        public Person (string Vorname, string Nachname)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
        }

        public Person (string Vorname, string Nachname, DateTime Geburtstag) 
            : this (Vorname, Nachname) //Wir rufen den Konstruktor  -> public Person (string Vorname, string Nachname)
        {
            this.Geburtstag = Geburtstag;
        }

        public Person(string Vorname, string Nachname, DateTime Geburtstag, int HaarFarbe)
            :this(Vorname, Nachname, Geburtstag)
        {
            this.HaarFarbe = HaarFarbe;
        }
        #endregion

        #region Dekonstruktor  //Destruktor wird durch die GC aufgerufen
        ~Person()
        {
            Console.WriteLine("Destruktoraufruf: das Objekt wird nun zerstoert");
        }

        public void Dispose()
        {
            //Hier weden alle Werte bereinigt -> danach wird der Dekonstruktor aufgerufen 
        }
        #endregion

    }
}
