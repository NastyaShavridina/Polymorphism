using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Printer3 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Значение: {value}");
        }
    }
}
