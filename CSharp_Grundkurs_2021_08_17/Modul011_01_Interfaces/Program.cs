using System;

namespace Modul011_01_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
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




}
