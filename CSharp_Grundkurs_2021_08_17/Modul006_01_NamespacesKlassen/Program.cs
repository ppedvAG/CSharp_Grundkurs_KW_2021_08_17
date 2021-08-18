using First = Modul006_01_NamespacesKlassen.ErsteNamespace; //Definition von einem Namespace - Alias
using Second = Modul006_01_NamespacesKlassen.ZweiterNamespace;
using Modul006_01_NamespacesKlassen.DrittenNamespace;
using System;


namespace Modul006_01_NamespacesKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Absolute Namespace.Klassen - Angabe ist absolut und die Klassen sind daher eindeutig. 
            Modul006_01_NamespacesKlassen.ErsteNamespace.MeineKlasse class1 = new ErsteNamespace.MeineKlasse();
            Modul006_01_NamespacesKlassen.ZweiterNamespace.MeineKlasse class2 = new ZweiterNamespace.MeineKlasse();


            //Namespace mit Alias  -> https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/using-directive
            First.MeineKlasse class3 = new First.MeineKlasse(); 
            Second.MeineKlasse class4 = new Second.MeineKlasse();



            //Wenn ich nur eine "MeineKlasse" verwende, dann kann man auch ein using verwenden und die kurze Schreibvariante verwenden 
            //Durch using Modul006_01_NamespacesKlassen.ErsteNamespace; -> Wird Meine Klasse aus ErstenNamespace verwendet
            MeineKlasse meineKlasse = new MeineKlasse(); //kommt aus dem dritten Namespace

            MeineKlasse.TestMethode(); //statische Methoden hängen immer an der Typdefiniton
        }
    }
}
