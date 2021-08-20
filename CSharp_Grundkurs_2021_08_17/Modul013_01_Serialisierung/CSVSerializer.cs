using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_01_Serialisierung
{
    //Erweiterungsmethoden benötigen eine statische Klasse
    public static class CSVSerializer
    {
        public static void Serialize(this Person p, string path)
        {
           
            File.WriteAllText(path, $"{p.Vorname};{p.Nachname};{p.Alter};{p.Kontostand};{p.KreditLimit};");
        }

        public static void Deserialize(this Person p, string path)
        {
            string content = File.ReadAllText(path);

            string[] csvParts = content.Split(';');

            p.Vorname = csvParts[0];
            p.Nachname = csvParts[1];
            p.Alter = int.Parse(csvParts[2]);
            p.Kontostand = int.Parse(csvParts[3]);
            p.KreditLimit = int.Parse(csvParts[4]);

        }
    }
}
