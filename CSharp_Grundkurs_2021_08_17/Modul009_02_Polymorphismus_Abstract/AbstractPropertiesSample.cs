using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_02_Polymorphismus_Abstract
{
    public abstract class BaseClass   // Abstract class
    {
        protected int _z = 99;
        protected int _x = 100;
        protected int _y = 150;
        public abstract void AbstractMethod();   // Abstract method
        public abstract int X { get; }
        public abstract int Y { get; }

        public abstract int Z { get; set; }
    }

    public class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public override int X   // overriding property
        {
            get
            {
                return _x + 10;
            }
        }

        public override int Y   // overriding property
        {
            get
            {
                return _y + 10;
            }
        }

        public override int Z 
        { 
            get
            {
                return _z;
            }
            set
            {
                if (value > 0)
                    _z = value;
            }
        }

        static void Main()
        {
            var o = new DerivedClass();
            o.AbstractMethod();
            Console.WriteLine($"x = {o.X}, y = {o.Y}");
        }
    }
    // Output: x = 111, y = 161
}
