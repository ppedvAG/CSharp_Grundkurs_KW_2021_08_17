using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class ListSample
    {
        public void Beispiel()
        {
            //intern wird ein Array verwendet -> T[] _items 
            IList<string> stringListe = new List<string>();
            stringListe.Add("Das");
            stringListe.Add("ist");
            stringListe.Add("eine");
            stringListe.Add("Liste");
            stringListe.Add("mit");
            stringListe.Add("Strings");

            List<string> stringListe2 = new List<string>();
            stringListe2.Add("Hallo");
            
            foreach (string currentItem in stringListe)
            {
                Console.WriteLine(currentItem);
            }

            //Hat einen Index -> Achtung vor OutOfRangeException
            Console.WriteLine(stringListe[0]);

            stringListe.Insert(1, "Guten Morgen");

            MethodeWithListAsParameter(stringListe);
            MethodeWithListAsParameter(stringListe2);
        }

        public void MethodeWithListAsParameter(IList<string> liste)
        {

        }

    }
}
