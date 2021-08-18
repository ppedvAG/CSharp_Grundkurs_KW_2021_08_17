using System;
using System.Collections.Generic;

namespace Modul010_01_Typpruefung
{
    class Program
    {
        static void Main(string[] args)
        {



            #region Get-Type() + typeof(T)
            MeineBasisKlasse basisKlasse = new();
            MeineAbgeleiteteKlasse abgeleiteteKlasse = new();

            Type bassisKlassenTyp = basisKlasse.GetType();



            Type abgeleiteteKlassenTyp = typeof(MeineAbgeleiteteKlasse);


            if (basisKlasse.GetType() == typeof(MeineBasisKlasse))
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineBasisKlasse) \t ->Instanz basisKlasse ist eine Klasse vom Typ-> MeineBasisKlasse");
            }
            else
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineBasisKlasse) -> Typ wurde nicht gefunden");
            }

            if (basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse))
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> Basisklasse kennt die abgeleitete Klasse (das darf nicht gehen)");
            }
            else
            {
                Console.WriteLine("basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> Basisklasse kennt nicht die abgeleitete Klasse");
            }


            if (abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse))
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse) -> abgeleitete Klasse kennt den Typ MeineBasisKlasse");
            }
            else
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse) -> abgeleitete Klasse kennt nicht den Typ MeineBasisKlasse");
            }

            if (abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse))
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> abgeleitete Klasse kennt den Typ MeineAbgeleiteteKlasse");
            }
            else
            {
                Console.WriteLine("abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) -> abgeleitete Klasse kennt nicht den Typ MeineAbgeleiteteKlasse");
            }

            #endregion

            //using System.Collections.Generic;
            List<Shape> geometrieCollections = new List<Shape>();

            Rectangle rec = new ();
            Circle circle = new (4);
            Sphere sphere = new Sphere(5);


            //Typprüfung mit is
            if (rec is Rectangle)
            {
                Console.WriteLine("rec ist ein Rectangle");
            }

            if (rec is Shape)
            {
                //cw + tab
                Console.WriteLine("rec ist eine Shape");
            }
        }

        //SWITCH PATTERN MATCHING
        static void MusterabgleichMitSwitch(Shape shape)
        {
            switch (shape)
            {
                case Rectangle r when r.x == r.y:
                    Console.WriteLine("Ist ein Quatrat");
                    break;
                case Rectangle:
                    Console.WriteLine("Ist ein Rechteck");
                    break;
                case Circle:
                    Console.WriteLine("Ist ein Kreis");
                    break;
                case Sphere:
                    Console.WriteLine("Ist eine Kugel");
                    break;
            }
        }
    }

    #region Sample1 Het-Type / typeof(T)
    class MeineBasisKlasse
    {

    }

    class MeineAbgeleiteteKlasse : MeineBasisKlasse
    {

    }
    #endregion

    #region Geometrie
    public class Shape
    {
        public const double PI = Math.PI;
        public double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    public class Rectangle : Shape
    {
        //Hie müssen wir nichts überschreiben (x*y) reicht komplett aus für eine Rechtseckberechnung
    }


    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * x * x;
        }
    }

    class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
}
