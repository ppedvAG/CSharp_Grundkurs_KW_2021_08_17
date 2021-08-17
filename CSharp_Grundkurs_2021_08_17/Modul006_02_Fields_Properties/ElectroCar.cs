using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_Fields_Properties
{
    public class ElectroCar 
    {
        //Fields
        private string marke;
        private string modell;
        private int baujahr;
        private string feldMitStandartwert = "Halli Hallo"; //Feld mit Defaultwert

        private int reichweite = 100;
        private int höchstgeschwindigkeit = 120;


        //ctor + tab +tab -> Default Konstrukor
        public ElectroCar()
        {
            Höchstgeschwindigkeit = 99;
        }


        //Properties
        public string Marke { get => marke; set => marke = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Baujahr { get => baujahr; set => baujahr = value; }

        public string FeldMitStandartwert
        {
            get
            {
                return feldMitStandartwert;
            }

            set
            {
                //Wenn Stirng befüllt ist, kann dieser erst übergeben werden
                //Validierung ;-) 
                if (!string.IsNullOrEmpty(value))
                    feldMitStandartwert = value;
            }
        }


        //Reichweite kann nur ausgelesen werden 
        public int Reichweite { get => reichweite;}



        //Kleines Update C# 8.0 ->
        public int Höchstgeschwindigkeit { get; init; } //Init bedeutet, dass nur beim Initialisieren eines Objektes befüllt werden darf. Danach ist es ReadOnly

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
