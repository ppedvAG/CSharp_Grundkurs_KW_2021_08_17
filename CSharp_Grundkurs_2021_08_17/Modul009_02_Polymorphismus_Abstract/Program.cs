using System;

namespace Modul009_02_Polymorphismus_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error CS0144  Cannot create an instance of the abstract type or interface 'Shape'	
            //Shape shape = new();

            Square square = new(5);
            Console.WriteLine(square.GetArea());
        }
    }
}
