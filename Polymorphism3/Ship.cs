using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism3
{
    class Ship : Vehicle
    {
        public string Port { get; set; }

        public Ship(double longitude, double latitude, decimal cost, double speed, int numbOfPassenger, int year, string port) : base(longitude, latitude, cost, speed, numbOfPassenger, year)
        {
            this.Port = port;
        }

        public override void Show()
        {
            Console.WriteLine("Информация о судне: ");

            base.Show();

            Console.WriteLine($"Порт приписки: {Port}");
        }
    }
}
