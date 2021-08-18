using System;

namespace Modul006_02_Fields_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Oldtimer oldtimer = new Oldtimer();

            ElectroCar electroCar = new ElectroCar() { FeldMitStandartwert = "Hallo :-) ", Höchstgeschwindigkeit = 123 };
            electroCar.FeldMitStandartwert = "Nochmal Halli Hallo";
            //electroCar.Höchstgeschwindigkeit = 200; -> Compilier liefert hier einen Fehler
        }
    }
}
