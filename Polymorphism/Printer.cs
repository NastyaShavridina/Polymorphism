using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Printer
    {
        public virtual void Print( string value)
        {
            Console.WriteLine($"Значение: {value}");
        }
    }
}
