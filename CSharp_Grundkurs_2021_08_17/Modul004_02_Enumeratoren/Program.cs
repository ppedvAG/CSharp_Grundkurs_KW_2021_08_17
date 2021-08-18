using System;

namespace Modul004_02_Enumeratoren
{

    //Mo = 1 ist der Startwert!
    //Di = erhöht
    enum Wochentag { Mo=1, Di, Mi, Do, Fr, Sa, So } //Mo=1, Di=2, Mi=3, Do=4,Fr=5, Sa=6, SoSo=7
    enum WochentagAutomatisch { Mo,Di,Mi,Do,Fr,Sa,So}; //Mo -> DefaultIndexWert = 0 / Di = 1
    
    [Flags]
    enum Fruechte
    {
        Keines = 0,
        Orange = 1,
        Kirsche = 2,
        Banane = 4, 
        Apfel = 8, 
        Pflaume = 16,
        Birne = 32
    }


    [Flags]
    public enum DinnerItems
    {
        None = 0,
        Entree = 1,
        Appetizer = 2,
        Side = 4,
        Dessert = 8,
        Beverage = 16,
        BarBeverage = 32
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Wochentag
            //Enum in einer Variablen verwenden und initialisieren
            Wochentag wochentag = Wochentag.Fr;
            WochentagAutomatisch wochentagAutomatisch = WochentagAutomatisch.Fr;


            //einem Enum in den zugewiesenen Zahlenwert konventieren
            int tagInWoche = (int)wochentag; //5
            int tagInWocheAuto = (int)wochentagAutomatisch; //4 

            //einen Zahlenwert in den zugewiesenen Enum konvertieren
            Wochentag aNewDayBegin = (Wochentag)3; //Mi
            //Wochentag tag8 = (Wochentag)8; //8, da dem Zahlenwert 8 kein Enumerationsmembers zugewiesen wurde

            Fruechte fruchtkorb = Fruechte.Orange | Fruechte.Banane | Fruechte.Birne; //Wert ist 37 

            //auf einzelne Enumerationsmember pruefen
            bool istOrangeImFruchtkorb = (fruchtkorb & Fruechte.Orange) == Fruechte.Orange;
            Console.WriteLine($"Gibt es im Fruchtkorb Orangen: {istOrangeImFruchtkorb}");


            //Enum ueber eine switch-Anweisung ueberpruefen lassen
            string hinweis = string.Empty;

            switch (wochentag)
            {
                case Wochentag.Mo:
                case Wochentag.Di:
                case Wochentag.Mi:
                case Wochentag.Do:
                case Wochentag.Fr:
                    hinweis = "Leider ist noch kein Wochenende..";
                    break;
                case Wochentag.Sa:
                case Wochentag.So:
                    hinweis = "Wuhu! Endlich Wochenende!";
                    break;
                default:
                    break;
            }



            #region Wiederholungsbeispiel Enums mit BitFlag
           
            //Setzen eines BitFlag
            DinnerItems myOrder = DinnerItems.Appetizer | DinnerItems.Entree |
                              DinnerItems.Beverage | DinnerItems.Dessert;


            DinnerItems flagValue = DinnerItems.Entree | DinnerItems.Beverage;
            
            
            if (myOrder.HasFlag(DinnerItems.Appetizer))
            {
                // DinnerItems.Appetizer ist vorhanden
            }

            Console.WriteLine("{0} includes {1}: {2}",
                              myOrder, flagValue, myOrder.HasFlag(flagValue));
            #endregion

        }


    }
}






public class Example
{
    public static void Main()
    {
        
    }
}
// The example displays the following output:
//    Entree, Appetizer, Dessert, Beverage includes Entree, Beverage: True
