
using Modul008_02_ZugriffsmodifiziererLib;
using System;

namespace Modul008_02_Zugriffsmodifizierer
{
    class Program
    {
        static void Main(string[] args)
        {
            //public => ueberall
            //private => innerhalb der selben Klasse
            //protected => innerhalb der selben Klasse oder innerhalb abgeleiteter Klassen
            //internal => innerhalb der aktuellen Assembly
            //protected internal => innerhalb der aktuellen Assembly oder abgeleitet Klasse in anderer Assembly
            //private protected => innerhalb der selben Klasse oder innerhalb einer abgeleiteten Klasse in der aktuellen Assembly


            ElectroCar electroCar = new ElectroCar();
           
            electroCar.publicGeschwindigkeit = 123;

            ////Diese Variablen sind von "aussen" via Instance zugreifbar
            //electroCar.internalRadio = new object();
            //electroCar.protectedinternalKofferraum = new object();
            //electroCar.publicGeschwindigkeit = 123;
        }
    }

    


    
}
