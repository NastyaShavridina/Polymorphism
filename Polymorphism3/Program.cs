using System;

namespace Polymorphism3
{
    //    Требуется:
    //Создать класс Vehicle.
    //В теле класса создайте поля: координаты и параметры средств передвижения(цена, скорость, год
    //выпуска).
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane(30, 45, 15000000, 800, 150, 2010, 13000);

            Vehicle ship = new Ship(30, 50, 10000000, 150, 1000, 2005, "Odessa");

            Vehicle car = new Car(30, 50, 20000, 150, 5, 2005);

            plane.Show();

            Console.ReadLine();

            ship.Show();

            Console.ReadLine();

            car.Show();
        }
    }
}
