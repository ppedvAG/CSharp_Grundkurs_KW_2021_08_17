using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modul013_01_Serialisierung
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Person person = new()
            {
                Vorname = "Donald",
                Nachname = "Duck",
                Alter = 123,
                Kontostand = 1_000_000m,
                KreditLimit = 10_000_000m,
                KontoPin = "1234"
            };

            Stream stream = null;

            //.NET 6.0 -> Performancesteigerung von 50%
            FileStream s2 = new FileStream("Person.xml", FileMode.OpenOrCreate);

            #region Binary
            //using System.Runtime.Serialization.Formatters.Binary;
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //stream = File.OpenWrite("Person.bin");
            //binaryFormatter.Serialize(stream, person);
            //stream.Close();
            ////einlesen
            //stream = File.OpenRead("Person.bin");
            //Person geladenePerson = (Person)binaryFormatter.Deserialize(stream);
            //stream.Close();
            #endregion

            #region Xml
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            
            //if (File.Exists("Person.xml"))
            //    File.Delete("Person.xml");

            //s2 = File.OpenWrite("Person.xml");
            xmlSerializer.Serialize(s2, person);
            s2.Close();

            //einlesen
            s2 = File.OpenRead("Person.xml");
            Person geladenePerson1 = (Person)xmlSerializer.Deserialize(s2);
            s2.Flush();
            s2.Close();
            #endregion

            #region JSON
            //.NET 4.8 -> Newtonsoft.Json
            // Ab .NET 3.0 -> System.Text.Json -> JsonConvert

            string jsonString = JsonConvert.SerializeObject(person);
            await File.WriteAllTextAsync("Person.json", jsonString); //await -> ich warte solange, bis diese Methode fertig ist 
            
            
            //jsonString könnte man aus PErson.json zuerst lesen
            Person geladeneJsonPerson = JsonConvert.DeserializeObject<Person>(jsonString);
            #endregion

            #region CSV Serializer
            person.Vorname = "Kevin";
            person.Serialize("Person.csv");

            person = new Person();
            person.Deserialize("Person.csv");
            #endregion
        }
    }

    [Serializable] //Objekt Person kann jetzt binär 
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        //[field:NonSerialized] //Bei Binär
        //[XmlIgnore]
        [JsonIgnore]
        public decimal Kontostand { get; set; }

        //[field: NonSerialized] //Bei Binär
        //[XmlIgnore]
        [JsonIgnore]
        public decimal KreditLimit { get; set; }

        //[NonSerialized] //NonSerialzed wird bei Fields Verwendet (Variablen) 
        //[XmlIgnore]
        [JsonIgnore]
        public string KontoPin;

    }
}
