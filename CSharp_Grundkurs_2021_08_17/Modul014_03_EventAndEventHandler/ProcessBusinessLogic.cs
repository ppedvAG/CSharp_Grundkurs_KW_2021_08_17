using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul014_03_EventAndEventHandler
{


    public delegate void Notify();
    public delegate void Percent(int i);

    public class ProcessBusinessLogic
    {
        //Beispiel -> event mit Delegate
        public event Notify ProcessCompleted; //Funktionszeiger werden von aussen (wenn Objekt instanziiert ist) initialisiert
        public event Percent ActuallyPercentStatus;

        //Beispiel2 -> event mit Action
        public event Action<int> ActuallyPercentStatusWithAction;
        public event Action ProcessCompletedWithAction; 



        public void StartProcess()
        {

            //Bearbeitung
            for (int i = 0; i <= 100; i++)
            {
                OnProcessPercentStatus(i);
            }
                


            OnProcessCompleted();
        }



        public void StartProcessWithActions()
        {

            //Bearbeitung
            for (int i = 0; i <= 100; i++)
            {
                OnProcessPercentStatuWithActions(i);
            }

            OnProcessCompletedWithAction();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke(); //Invoke auf ProcessBusinessLogic_ProcessCompleted
        }

        protected virtual void OnProcessPercentStatus(int percent)
        {
            ActuallyPercentStatus?.Invoke(percent); //Invoke mit Parameter auf ProcessBusinessLogic_ActuallyPercentStatus
        }




        //ActionSample

        protected virtual void OnProcessCompletedWithAction()
        {
            ProcessCompletedWithAction?.Invoke(); //Invoke auf ProcessBusinessLogic_ProcessCompleted
        }

        protected virtual void OnProcessPercentStatuWithActions(int percent)
        {
            ActuallyPercentStatusWithAction?.Invoke(percent); //Invoke mit Parameter auf ProcessBusinessLogic_ActuallyPercentStatus
        }
    }
}
