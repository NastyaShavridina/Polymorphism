using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism3
{
    class Plane : Vehicle
    {
        public double Height { get; set; }

        public Plane(double longitude, double latitude, decimal cost, double speed, int numbOfPassenger, int year, double height) : base(longitude, latitude, cost, speed, numbOfPassenger, year)
        {
            this.Height = height;
        }

        public override void Show()
        {
            Console.WriteLine("Информация о самолете: ");
            
            base.Show();

            Console.WriteLine($"Высота: {Height}");   
        }

    }
}
