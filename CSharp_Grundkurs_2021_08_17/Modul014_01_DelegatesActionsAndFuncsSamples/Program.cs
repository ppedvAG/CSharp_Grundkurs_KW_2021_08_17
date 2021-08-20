using System;

namespace Modul014_01_DelegatesActionsAndFuncsSamples
{
    //Typ NumbChange
    delegate int NumbChange(int n); //Dieses Gelegate kann mit Methoden arbeiten die diese Signatur -> int MethodeA (int)
    delegate int CalculatorDelegate(int zahl1, int zahl2);

    delegate void LikeAction(int n); 

    delegate void abc(int whatever);
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1 Delegate 
            NumbChange numbChange = new NumbChange(AddNumber); //ÜBergeben den Funktionszeiger an das delegate
            int result = numbChange(18);

            numbChange += SubNumber;
            int result1 = numbChange(18);
            // AddNumber (18) -> Rückgabe:23
            // SubNumber(18) -> result1 -> 7

            numbChange -= AddNumber;
            int result2 = numbChange(18);


            CalculatorDelegate calculatorDelegate = new CalculatorDelegate(Addition);
            int result3 = calculatorDelegate(11, 22);
            #endregion


            Action a1 = new Action(A);
            a1(); //call Methode -> public static void A()
            a1 += B;
            a1();

            //Mit Delegate
            LikeAction likeAction = new LikeAction(C);
            likeAction(123);
            //Mit Action 
            Action<int> actionWithOnParameter = new Action<int>(C);
            actionWithOnParameter(123);


            Func<int, int, int> func = new Func<int, int, int>(Addition);
            int result5 = func(11, 22);
        }


        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }

        public static void C(int zahl)
        {
            Console.Write("C" + zahl);
        }

        public static int AddNumber(int number)
        {
            return number + 5;
        }

        public static int SubNumber(int number)
        {
            return number - 11;
        }


        public static int Addition(int z1, int z2)
        {
            return z1 + z2;
        }
    }
}
