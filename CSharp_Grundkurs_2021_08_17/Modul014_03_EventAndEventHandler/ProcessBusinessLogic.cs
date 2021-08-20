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
        public event Notify ProcessCompleted;
        public event Percent ActuallyPercentStatus;


        public void StartProcess()
        {
            for (int i = 0; i <= 100; i++)
            {
                OnProcessPercentStatus(i);
            }
                




            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }



        protected virtual void OnProcessPercentStatus(int percent)
        {
            ActuallyPercentStatus?.Invoke(percent);
        }


    }
}
