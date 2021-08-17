using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_Fields_Properties
{
    public class Oldtimer
    {
        private string marke;
        private string modell;
        private int baujahr;
        private string feldMitStandwert = "Halli Hallo"; //Feld mit Defaultwert

        public void SetMarke (string Marke)
        {
            marke = Marke;
        }
        public string GetMarke()
        {
            return marke;
        }

        public void SetBaujahr(int Baujahr)
            => baujahr = Baujahr; //Kurzschreibvariante

        public int GetBaujahr()
            => baujahr; //wird als return baujahr aufgelöst 


        public void MotorStart()
        {

        }

        public void MotorStop()
        {

        }

        public void FillOil()
        {

        }
    }
}
