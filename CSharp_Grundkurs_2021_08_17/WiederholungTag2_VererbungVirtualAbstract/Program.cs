using System;

namespace WiederholungTag2_VererbungVirtualAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            AbgeleiteteKlasse abgeleiteteKlasse = new();
            //abgeleiteteKlasse.VirtualMethode();
            abgeleiteteKlasse.NormaleMethodeA();
            abgeleiteteKlasse.AccessVirtualProtectedMethode();

            Basisklasse basisklasse = (Basisklasse)abgeleiteteKlasse;
            basisklasse.NormaleMethodeA(); //Basisklasse soll aufgerufen, weil mit 
            basisklasse.NormaleMethodeB();
            //basisklasse.VirtualMethode();

            Basisklasse sampleClass = new AbgeleiteteKlasse();
            //sampleClass.VirtualMethode();
            sampleClass.NormaleMethodeA();
            sampleClass.NormaleMethodeB();
        }
    }



    public class Basisklasse
    {
        protected virtual void VirtualMethode()
        {
            Console.WriteLine("Basisklasse->Ich bin die VirtualMethode().");
        }

        public void NormaleMethodeA()
        {
            Console.WriteLine("Basisklasse->Ich bin die NormaleMethodeA()");
        }
        public void NormaleMethodeB()
        {
            Console.WriteLine("Basisklasse->Ich bin die NormaleMethodeB()");
        }
    }

    public class AbgeleiteteKlasse : Basisklasse
    {
        //Bitte nicht so verwenden 
        protected new void VirtualMethode()
        {
            Console.WriteLine("AbgeleiteteKlasse->Ich bin die override VirtualMethode().");
        }

        public void AccessVirtualProtectedMethode()
        {
            this.VirtualMethode();
        }

        public new void NormaleMethodeA()
        {
            Console.WriteLine("AbgeleiteteKlasse->Ich bin die NormaleMethodeA().");
        }
    }


}
