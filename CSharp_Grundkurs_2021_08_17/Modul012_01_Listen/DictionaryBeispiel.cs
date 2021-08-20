using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class DictionaryBeispiel
    {
        public void Beispiel()
        {
            IDictionary<int, string> _dict = new Dictionary<int, string>();

            _dict.Add(1, "Guten Morgen");
            _dict.Add(2, "Guten Mittag");


            //KeyValuePair 
            KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>(3, "Guten Abend");
            _dict.Add(keyValuePair);

            //Mit KeyValuePair -> Liste laufen 
            foreach(KeyValuePair<int, string> currentDictItem in _dict)
            {
                Console.WriteLine($"{currentDictItem.Key} - {currentDictItem.Value}");
            }



            IDictionary<int, string> auswahlKursListe = new Dictionary<int, string>();
            auswahlKursListe.Add(1, "C# Grundlagenkurs");
            auswahlKursListe.Add(2, "SQL Grundlagenkurs");
            auswahlKursListe.Add(3, "HTML Design");
            auswahlKursListe.Add(4, "C# Fortgeschritten");
            auswahlKursListe.Add(5, "C# Architektur");
            auswahlKursListe.Add(6, "Scrum Master");
            //auswahlKursListe.Add(6, "Scrum Master"); ->führt zu Fehler -> doppelterKey

            IDictionary<int, string> eigeneKurse = new Dictionary<int, string>();

            Console.Write("Auswahl eines Kurses >");
            int selectedKursId = int.Parse(Console.ReadLine());


            //Ist der Eintrag schon in meinem eigeneKurs - Dictionary
            if (!eigeneKurse.ContainsKey(selectedKursId))
            {
                //lese wert aus Dictionary
                string value = auswahlKursListe[selectedKursId];

                //füge Eintrag in meine eigeneKurs-Liste
                eigeneKurse.Add(selectedKursId, value);

                //Lösche Eintrag aus auswahlKursListe
                auswahlKursListe.Remove(selectedKursId);
            }
                

        }
    }
}
