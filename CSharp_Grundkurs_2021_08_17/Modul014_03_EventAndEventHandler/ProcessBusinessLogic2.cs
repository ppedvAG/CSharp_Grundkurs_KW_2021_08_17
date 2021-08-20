using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul014_03_EventAndEventHandler
{
    public class ProcessBusinessLogic2
    {
        public event EventHandler ProcessCompleted; //Zeiger von ProcessBusinessLogic2_ProcessCompleted hängt hier dran
        public event EventHandler ProcessCompletedNew; //Zeiger von ProcessBusinessLogic2_ProcessCompletedNew hängt hier dran

        public void StarProcess()
        {
            //Mach was

            OnProcessCompleted(EventArgs.Empty);



            //Sample2 mit eiger Event-Klasse
            MyEventArgs myEvent = new MyEventArgs();
            myEvent.Uhrzeit = DateTime.Now;

            OnProcessCompletedNew(myEvent);
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            //Invoke sender = this, EventArgs = e 
            ProcessCompleted?.Invoke(this, e); //Program->ProcessBusinessLogic2_ProcessCompleted
        }


        protected virtual void OnProcessCompletedNew(MyEventArgs e)
        {
            ProcessCompletedNew?.Invoke(this, e);
        }
    }


    public class MyEventArgs : EventArgs
    {
        public DateTime Uhrzeit { get; set; }
    }
}
