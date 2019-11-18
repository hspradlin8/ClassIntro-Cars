using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();

            Car ford = new Car("Ford", "Bronco", 80_000);

            ford.Year = 1986;
            ford.Color = "Pearl";
            ford.IsInspected = true;
            ford.CountryOfOrigin = "USA";

            Car toyota = new Car("Toyota", "4Runner", 300)
            {

                Year = 2019,
                Color = "White",
                IsInspected = false,
                CountryOfOrigin = "Japan"

            };

            Car chevy = new Car("Chvey", "Malibu", 200_000)
            {

                Year = 1995,
                Color = "Red",
                IsInspected = false,
                CountryOfOrigin = "USA"

            };

            carLot.Add(ford);
            carLot.Add(toyota);
            carLot.Add(chevy);

            Console.WriteLine($"The ford has {ford.Mileage} miles");
            ford.Drive(10);
            Console.WriteLine($"The ford has now drive {ford.Mileage}");
            Console.WriteLine(ford.Description);
            Console.WriteLine(chevy.Description);
            Console.WriteLine(toyota.Description);
            toyota.Drive(3000);
            // everytime we access description it is going to recompute that information
            Console.WriteLine(toyota.Description);

        }
    }
}