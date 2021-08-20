using System;
using System.Collections.Generic;

namespace Modul016_01_GenericsSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generische List wird typisiert 
            IList<string> nameList = new List<string>();
            nameList.Add("Harry");
            nameList.Add("Emanuella");

            IList<int> zahlenListe = new List<int>();
            zahlenListe.Add(1);


            IDictionary<Guid, string> dict = new Dictionary<Guid, string>();

            dict.Add(new KeyValuePair<Guid, string>(Guid.NewGuid(), "Hallooooo :-)"));


            DataStore<string, DateTime> dataStore = new DataStore<string, DateTime>();
            dataStore.AddOrUpdate(0, "Guten Morgen");
            dataStore.AddOrUpdate(1, "Guten Mittag");

            dataStore.DisplayDefault<Guid>();
            dataStore.DisplayDefault<int>();
            dataStore.DisplayDefault<DateTime>();
        }
    }

    public class DataStore<T, ABC>
    {
        private T[] _data = new T[10];

        private ABC myABCDataType;

        public ABC MyABC
        {
            get => myABCDataType;
            set => myABCDataType = value;
        }

        public T[] Data
        {
            get => _data;
            set => _data = value;
        }

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData (int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        public void DisplayDefault<MyType>()
        {
            MyType item = default(MyType);

            Console.WriteLine($"Default value of {typeof(MyType)} is {(item == null ? "null" : item.ToString())}.");
        }
    }
}
