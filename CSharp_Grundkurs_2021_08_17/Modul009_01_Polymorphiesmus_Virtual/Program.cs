using System;

namespace Modul009_01_Polymorphiesmus_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Obst obst = new();
            Console.WriteLine(obst.WasBinIch()); //Ich bin Obst

            Apfel apfel = new Apfel();
            Console.WriteLine(apfel.WasBinIch());


            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());




            #region virtual - new
            Fahrzeug fahrzeug = new Fahrzeug();
            Console.WriteLine(fahrzeug.WasBinIch());
            //Ich bin ein Fahrzeug

            Auto auto = new Auto();
            Console.WriteLine(auto.WasBinIch());
            //Ich bin ein Auto
            #endregion
        }
    }
}
