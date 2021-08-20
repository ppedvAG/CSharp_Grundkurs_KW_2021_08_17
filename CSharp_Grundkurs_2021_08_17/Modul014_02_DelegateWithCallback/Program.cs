using System;

namespace Modul014_02_DelegateWithCallback
{

    public delegate void MessageDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            //Callback mit Delegate
            MessageDelegate messageDelegate = new MessageDelegate(FinishResultMethode);
            MethodWithCallback(11, 22, messageDelegate);

            //Callback mit Action
            Action<string> actionMessageDelegate = new Action<string>(FinishResultMethode);
            MethodWithCallback(22, 33, actionMessageDelegate);
        }

        public static void MethodWithCallback(int param1, int param2, MessageDelegate messageDelegate)
        {
            //Es wird hier viel berechnet... 


            


            messageDelegate("The number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }


        public static void MethodWithCallback(int param1, int param2, Action<string> messageDelegate)
        {
            //Es wird hier viel berechnet... 





            messageDelegate("The number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }

        public static void FinishResultMethode(string message)
        {
            Console.WriteLine(message);
        }
    }
}
