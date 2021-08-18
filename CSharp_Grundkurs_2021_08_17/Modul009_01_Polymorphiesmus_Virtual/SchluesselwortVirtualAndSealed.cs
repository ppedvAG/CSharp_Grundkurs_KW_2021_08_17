using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_Polymorphiesmus_Virtual
{
    public class Lebewesen
    {

        //Methode "WasBinIch" wird initialisiert und kann auch so verwendet werden
        //durch "virtual" kann es in abgeleitetetn Klassen auch ueberschrieben werden
        public virtual string WasBinIch()
        {
            return "Ich bin ein Lebewesen";
        }
    }

    public class Mensch : Lebewesen
    {
        public sealed override string WasBinIch()
        {
            return "Ich bin ein Mensch";
        }
    }

    public class Kind : Mensch
    {
        //Error CS0239	'Kind.WasBinIch()': cannot override inherited member 'Mensch.WasBinIch()' because it is sealed 
        //public override string WasBinIch()
        //{
        //    return base.WasBinIch();
        //}
    }


    public sealed class MySealedClass
    {
        public string Text = "HAllo";
    }


    //Severity	Code	Description	Project	File	Line	Suppression State
    //Error CS0509  'MyChildClass': cannot derive from sealed type 'MySealedClass'	

    //public class MyChildClass : MySealedClass
    //{

    //}
}
