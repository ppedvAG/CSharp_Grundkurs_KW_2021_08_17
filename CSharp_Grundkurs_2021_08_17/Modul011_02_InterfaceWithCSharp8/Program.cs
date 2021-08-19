using System;

namespace Modul011_02_InterfaceWithCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1 Default-Implementierung in einem Interface
            //Klassische Instanziierung -> erhalten wir nur die Implementierungen die in der ImplementationClass definiert sind
            ImplementationClass implementationClass = new ImplementationClass();
            implementationClass.MethodA();


            //Via Cast können wir auf MethodeB zusätzlich zugreifen
            ((IBaseInterface)implementationClass).MethodA();
            ((IBaseInterface)implementationClass).MethodB();

            //Eleganter geht das mit IBaseInterface implementationClass1 = new ImplementationClass();
            Console.WriteLine(" ##### IBaseInterface implementationClass1 = new ImplementationClass(); ######");
            IBaseInterface implementationClass1 = new ImplementationClass();
            implementationClass1.MethodA();
            implementationClass1.MethodB();
            #endregion
        }
    }


    #region Sample 1 : Default-Implementierung in einem Interface
    interface IBaseInterface
    {
        void MethodA();

        void MethodB()
        {
            Console.WriteLine("IBaseInterface.MethodB");
        }
    }

    public class ImplementationClass : IBaseInterface
    {
        public void MethodA()
        {
            Console.WriteLine("ImplementationClass.MethodA");
        }
    }
    #endregion

    #region Offener Punkt Sample2
    public interface IVehicle
    {
        public abstract void Drive();

        public virtual void Drive1()
        {

        }

    }

    public interface ICar: IVehicle
    {
       public new void Drive()
       {

       }

        public new void Drive1()
        {

        }
    }

    public class Vehicle : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Drive1()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Sample3
    interface IFahrzeug
    {
        private string InterneFahrzeugNummer 
        { 
            get
            {
                return "Test";
            }
            set
            {

            }
        }


        //es koennen statische Member definiert werden
        public static string Test = "Ein String!";

        string Bezeichnung { get; set; }

        //Member koennen eine Standardimplementierung erhalten
        //sie sind nur ueber das Interface aufrufbar
        public string Info()
        {
            InterneFahrzeugNummer = "Test";
            return "Ich bin ein " + Bezeichnung;
        }
    }

    public class Auto : IFahrzeug
    {
        public string Bezeichnung { get; set; }

        public Auto(string bezeichnung)
        {
            this.Bezeichnung = bezeichnung;
        }
    }

    #endregion




}
