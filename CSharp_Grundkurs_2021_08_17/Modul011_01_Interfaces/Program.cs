using System;


namespace Modul011_01_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sample1
            //SampleClass sample = new SampleClass();
            //IControl control = sample;
            //ISurface surface = sample;

            //// The following lines all call the same method.
            //sample.Paint();

            //control.Paint();
            //control.Print();

            //surface.Paint();
            //surface.Print();
            #endregion

            #region Sample2 - Explizit
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            //sample.Paint(); // Compiler error.
            control.Paint();  // Calls IControl.Paint on SampleClass.
            surface.Paint();  // Calls ISurface.Paint on SampleClass.
            #endregion
        }
    }

    #region VehicleSample
    public interface ICanUseStrom 
    {
        bool WithBattery { get; set; }
        bool PermantStromSource { get; set; }
    }

    public interface ICanUseOil
    {
        public int Tankvolumen { get; set; }
    }

    public interface ICanUseSuper : ICanUseOil
    {
        int OktanZahl { get; set; }
    }

    public class Vehicle
    {
        //what is a vehicle 
        //lots of properties and methods
    }

    public class Car : Vehicle
    {

    }

    public class ElectroCar : Car, ICanUseStrom
    {
        public bool WithBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PermantStromSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class HypridCar : Car, ICanUseStrom, ICanUseOil
    {
        public bool WithBattery { get; set; }
        public bool PermantStromSource { get; set; }
        public int Tankvolumen { get; set; }
    }




    public class Ship : Vehicle
    {
    }


    public class SpecialShip : Ship, ICanUseStrom
    {
        public bool WithBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PermantStromSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Train : Vehicle, ICanUseStrom
    {
        public bool WithBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PermantStromSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Airplane : Vehicle
    {

    }

    #endregion

    #region Jahresmark Sample

    public interface IFSK16
    {
        bool IsChecked(object Person); //Default -> Method ist public 
    }

    public interface IToiletteAvailable
    {

    }

    public class JahremarktStand
    {

    }

    public class Achterbahn : JahremarktStand, IFSK16
    {
        public bool IsChecked(object Person)
        {
            throw new NotImplementedException();
        }
    }

    public class MirrorCabinett : JahremarktStand
    {

    }

    public class AutoScooter : JahremarktStand, IToiletteAvailable
    {

    }

    public class HorrorSchockCabinett : JahremarktStand, IFSK16, IToiletteAvailable
    {
        public bool IsChecked(object Person)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Sample: Expliziete Interface Implementierung

    public interface InterfaceA
    {
        void MyMethod();
    }

    public interface InterfaceB
    {
        void MyMethod();
    }

    public class MyClass : InterfaceA, InterfaceB
    {
        void InterfaceA.MyMethod()
        {
            throw new NotImplementedException();
        }

        void InterfaceB.MyMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class MyProgrammCs
    {
        public void Main()
        {
            MyClass myClass = new();
            InterfaceA myClass2 = new MyClass();

        }
    }
    #endregion


    #region Sample4


    public interface IControl
    {
        void Paint();


        void Print()
        {
            Console.WriteLine("IControl.Print");
        }
    }
    public interface ISurface
    {
        void Paint();


        void Print()
        {
            Console.WriteLine("ISurface.Print");
        }
    }
    public class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method.
        //public void Paint()
        //{
        //    Console.WriteLine("Paint method in SampleClass");
        //}


        void IControl.Paint()
        {
            System.Console.WriteLine("IControl.Paint");
        }
        void ISurface.Paint()
        {
            System.Console.WriteLine("ISurface.Paint");
        }
    }

    #endregion
}
