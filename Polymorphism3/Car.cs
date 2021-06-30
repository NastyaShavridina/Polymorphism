using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism3
{
    class Car : Vehicle
    {
        public Car(double longitude, double latitude, decimal cost, double speed, int numbOfPassenger, int year) : base(longitude, latitude, cost, speed, numbOfPassenger, year)
        {

        }

        public override void Show()
        {
            Console.WriteLine("Информация об автмобиле: ");

            base.Show();
        }
    }
}
