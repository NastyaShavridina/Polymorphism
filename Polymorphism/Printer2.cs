using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Printer2 : Printer 
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Значение: {value}");
        }
    }
}
