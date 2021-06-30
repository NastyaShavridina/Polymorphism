using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism3
{
   abstract class Vehicle
    {
        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public decimal Cost { get; set; }

        public double Speed { get; set; }

        public int NumbOfPassenger { get; set; }

        public int Year { get; set; }

        protected Vehicle(double longitude, double latitude, decimal cost, double speed, int numbOfPassenger, int year)
        {
            Longitude = longitude;
            Latitude = latitude;
            Cost = cost;
            Speed = speed;
            NumbOfPassenger = numbOfPassenger;
            Year = year;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Долгота: {Longitude}, Широта: {Latitude}");

            Console.WriteLine($"Стоимость: {Cost}, Скорость: {Speed}");

            Console.WriteLine($"Количество пассажиров: {NumbOfPassenger}, Год выпуска: {Year}");

        }
    }
}
