using System;

namespace Modul008_02_ZugriffsmodifiziererLib
{
    public class Fahrzeug
    {
        public int publicGeschwindigkeit;
        private string privateFarbe; // kann nur innerhalb der Fahrzeugklassen verwendet werden 
        protected object protectedAntrieb;
        internal object internalRadio;
        protected internal object protectedinternalKofferraum;
        private protected object privateprotectedLenkrad;

        public void Lackiere()
        {
            //Private kann nur innerhalb der Klasse verwendet werden, die in dieser auch definiert ist. 
            this.privateFarbe = "Orange";
        }
    }

    public class ElectroCar : Fahrzeug
    {
        public void WhatCanIUseIntern()
        {
            //Auf welche Variablen kann intern zugreifen 

            this.internalRadio = new object();
            this.privateprotectedLenkrad = new object();
            this.protectedAntrieb = new object();
            this.protectedinternalKofferraum = new object();
            this.publicGeschwindigkeit = 12;
        }
    }
}
