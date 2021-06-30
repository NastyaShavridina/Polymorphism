using System;

namespace Polymorphism
{
    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте класс Printer.
    //В теле класса создайте метод void Print(string value), который выводит на экран значение
    //аргумента.
    //Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
    //соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
    //выводились разными цветами.
    //Обязательно используйте приведение типов. 
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Print("print");

            Printer2 printer2 = new Printer2();

            printer = printer2;

            printer.Print("pprint");

            Printer3 printer3 = new Printer3();

            printer = printer3;
  
            printer.Print("Print");

            Console.ReadKey();
        }
    }
}
