using System;
using System.Collections;

namespace Modul012_01_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryBeispiel dictionaryBeispiel = new DictionaryBeispiel();
            dictionaryBeispiel.Beispiel();

            HashTableSample hashTableSample = new HashTableSample();
            hashTableSample.Beispiel();

            //wir verwenden IList/List
            ArrayList arrayList = new ArrayList();
            
        }
    }
}
