using System;

namespace Modul002_01_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# - Datentypen

            char textzeichen = 'A';
            
            string text = "ABCDEFG";
            string einenLeerenString = string.Empty; // besser als -> string einenLeerenString = "";

            bool boolean = true; //true oder false 

            #region Nummerischen Werte
            byte minByte = 0;
            byte maxMyte = 255;
            // byte.MinValue -> kleinster gültiger Wert
            // byte.MaxValue -> höchster gültiger Wert

            //16 Bit
            short minShort = short.MinValue; // -32.768
            short maxShort = short.MaxValue; // 32.767

            //32 Bit
            int minInt = int.MinValue; //-2.147.483.648
            int maxInt = int.MaxValue; // 2.147.483.647

            //64 Bit 
            long minLong = long.MinValue; // –9.223.372.036.854.775.808
            long maxLong = long.MaxValue; // 9.223.372.036.854.775.807
            #endregion


            #region .NET Datentyp - CSharp Datentyp 
            int myCSharpIntegerTyp = 123;
            Int32 myNetType = myCSharpIntegerTyp;
            String myText = "verwende den .NET Nativen Datentyp";
            #endregion


            #region Gleitkomma Zahlen

            double doubleValue = 69.64;


            float floatValue = 12.232f;

            decimal Geldbetraege = 30.15m; //decimal Geld
            #endregion


        }
    }
}
