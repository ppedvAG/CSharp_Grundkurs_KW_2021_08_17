using System;

namespace Modul008_01_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch human = new Mensch(33, "Berlin");

            Console.WriteLine(human.Alter);
            Console.WriteLine(human.Wohnort);
        }
    }

    //Basisklasse
    public class Lebewesen
    {
        public int Alter { get; set; }

        public Lebewesen(int Alter)
        {
            this.Alter = Alter;
        }

        public void Schlafen()
        {
            //zZZZZzzzZZ
        }

        
    }

    //abgeleitetede oder vererbte Klasse
    public class Mensch : Lebewesen
    {
        public string Wohnort { get; set; }

        public void Lesen()
        {
        }

        public void Essen()
        {
            Verdauen(); //private Methoden können nur innerhalb der Klasse verwendet werden. 
        }
        private void Verdauen()
        {

        }

        public Mensch(int Alter, string Wohnort)
            :base(Alter) //hier rufen wir die Basi
        {
            this.Wohnort = Wohnort;
        }
    }


    public class Katze : Lebewesen
    {
        public Katze(int Alter)
            : base(Alter)
        {

        }

        public void Schnurren()
        {
            //Katze schnurrt
        }
    }



    public class Fisch:Lebewesen
    {
        public float Size { get; set; }

        public Fisch(int Alter, int Size)
            :base(Alter)
        {
            this.Size = Size;
        }

        public void Kiemenatmung ()
        { 
        }
    }

    public class Zander : Fisch
    {
        public int ZanderTyp { get; set; } = 1; //Property mit Defaultwert

        public Zander(int Alter, int Size, int ZanderTyp)
            :base(Alter, Size)
        {
            this.ZanderTyp = ZanderTyp;
        }
    }

}
