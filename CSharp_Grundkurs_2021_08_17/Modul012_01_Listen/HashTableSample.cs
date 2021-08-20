using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class HashTableSample
    {
        public void Beispiel()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(DateTime.Now, "Otto");
            hashtable.Add("gutes Wetter", 123456);
            hashtable.Add(this, new ArrayList());
            //hashtable.Add(null, "Otto"); -> null as key is unvalid

            foreach( DictionaryEntry entry in hashtable)
            {
                if (entry.Key is null)
                {
                    Console.WriteLine("Key is null");
                }

                if (entry.Key is DateTime date)
                {
                    Console.WriteLine($"{date.ToShortDateString()}");
                }
            }

            //foreach (object current in hashtable)
            //{
            //    if ( current is null)
            //    {

            //    }

            //    if (current is DateTime)
            //    {

            //    }
            //}
        }
    }
}
