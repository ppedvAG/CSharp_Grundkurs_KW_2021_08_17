using System;

namespace Modul014_03_EventAndEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();
            processBusinessLogic.ProcessCompleted += ProcessBusinessLogic_ProcessCompleted;
            processBusinessLogic.ActuallyPercentStatus += ProcessBusinessLogic_ActuallyPercentStatus;
            processBusinessLogic.StartProcess();



            ProcessBusinessLogic2 processBusinessLogic2 = new ProcessBusinessLogic2();
            processBusinessLogic2.ProcessCompleted += ProcessBusinessLogic2_ProcessCompleted;
            processBusinessLogic2.ProcessCompletedNew += ProcessBusinessLogic2_ProcessCompletedNew;
            processBusinessLogic2.StarProcess();
        }

        private static void ProcessBusinessLogic2_ProcessCompletedNew(object sender, EventArgs e)
        {
            MyEventArgs myEventArgs = (MyEventArgs)e;

            Console.WriteLine(myEventArgs.Uhrzeit.ToShortDateString());
        }

        private static void ProcessBusinessLogic2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("fertig");
        }


        #region Sample1
        private static void ProcessBusinessLogic_ActuallyPercentStatus(int i)
        {
            Console.WriteLine($"{i} %");
        }


        //CallBack REutnr Message 
        private static void ProcessBusinessLogic_ProcessCompleted()
        {
            Console.WriteLine("Ich bin fertig :-)");
        }
        #endregion
    }
}
