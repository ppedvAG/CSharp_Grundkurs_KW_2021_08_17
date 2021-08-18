using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_Methoden
{
    public class OutInRefParameter
    {
        //OUT (in PArameterliste) hat eine Bedinung, die Variable muss befüllt werden 
        public float Berechne(int zahl1, int zahl2, out int min, out int max, out float avg)
        {
            float summe = zahl1 + zahl2;

            if(zahl1 < zahl2)
            {
                min = zahl1;
                max = zahl2;
            }
            else
            {
                min = zahl2;
                max = zahl1;
            }
            avg = summe / 2; //The out parameter 'avg' must be assigned to before control leaves the current method
            return summe; 
        }

        //Bei Verwendung von 'in' wird die Variable als readonly behandelt. 
        public float Berechne(int zahl1, int zahl2, in int Faktor)
        {
            //Faktor = 2; //Cannot assign to variable 'in int' because it is a readonly variable Modul007_02_Methoden

            return zahl1 + zahl2 * Faktor;
        }

        //Ref ist die allgemeinste Verwendung einer Referenz, es ist keine Regel hinterlegt 
        public float BerechneMitRef(int zahl1, int zahl2, ref int Faktor)
        {
            Faktor = 123;
            return zahl1 + zahl2 + Faktor;
        }

    }
}
