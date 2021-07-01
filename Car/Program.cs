using System;

namespace CarNSPr
{
    class Program
    {
        static void Main(string[] args)
        {
            CarNS.Car car = new CarNS.Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model + " - " + car.Odometer);

        }
    }
}
