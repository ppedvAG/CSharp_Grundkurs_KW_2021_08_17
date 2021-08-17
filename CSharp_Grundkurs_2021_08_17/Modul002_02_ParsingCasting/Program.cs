using System;

namespace Modul002_02_ParsingCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 25;

            //implizierte Konvertierung in einen String durch den "+" Operator
            string satz1 = "Wert der Zahl: " + zahl1;

            //explizierte Konvertierung durch die Methode ".ToString()"
            string satz2 = "Wert der Zahl: " + zahl1.ToString();

            
            string zahlenwort = "123";
            int zahl2 = Int32.Parse(zahlenwort);
            int zahl3 = int.Parse(zahlenwort); //best 
            int zahl4 = Convert.ToInt32(zahlenwort);

            int zahl5 = 10;

            zahlenwort = zahlenwort.Trim(); //Alle Leerzeichen werden entfernt
            //Ist possible to cast?
            if (int.TryParse(zahlenwort, out zahl5))
            {
                //yes we can :-) 
                Console.WriteLine(zahl5);
            }
            else
            {
                //wir können nicht parsen
            }

            string zahlenwort2 = "123.456";
            float zahl5a = Single.Parse(zahlenwort2);
            float zahl6 = float.Parse(zahlenwort2);

            float myFloatNumber = (float)zahl5;

            ///Schluesselwort   .NET-Typ        Beschreibung
            ///sbyte            System.SByte    8-Bit-Zahl mit Vorzeichen
            ///byte             System.Byte     8-Bit-Zahl ohne Vorzeichen
            ///short            System.Int16    16-Bit-Zahl mit Vorzeichen
            ///ushort           System.Int16    16-Bit-Zahl ohne Vorzeichen
            ///int              System.Int32    32-Bit-Zahl mit Vorzeichen
            ///uint             System.Int32    32-Bit-Zahl ohne Vorzeichen
            ///long             System.Int64    64-Bit-Zahl mit Vorzeichen
            ///ulong            System.Int64    64-Bit-Zahl ohne Vorzeichen

            ///float            System.Single   32-Bit-Zahl (~6-9 Stellen Genauigkeit)
            ///double           System.Double   64-Bit-Zahl (~15-17 Stellen Genauigkeit)
            ///decimal          System.Decimal  128-Bit-Zahl (28-29 Stellen Genauigkeit)

            //Casten von numerischen Datentypen in einen anderen numerischen Datentyp


            #region Extetinos

            int myDefaultInteger; //myDefaultInteger -> hat den Wert 0;
            
            //Nullable Datentyp
            //- (man kann null zuweisen) 

            int? myNullableInteger = null;

            //myNullableInteger = 123; //Wert wird gesetzt

            Console.WriteLine(myNullableInteger);
            //Bestitzt du einen Wert
            
            if (myNullableInteger.HasValue) //HasValue ist false, wenn Inhalt [null] ist
            {
                //Ja ich habe einen Wert
                Console.WriteLine(myNullableInteger.Value);
            }


            //String prüfen auf Inhalt

            string myText = "Halli Hallo";

            //if (myText != "")
            if (!string.IsNullOrEmpty(myText))
            {
                // string ist befüllt
            }

            #endregion
        }
    }
}
