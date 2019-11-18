using System;

namespace ClassIntro
{
    class Car
    {
        // This is a field
        // These are similar to properties but they are typically private
        // and don't specify getters and setters
        // good place to set field is in the constructor 
        private string _vinNumber;

        private int _standardTestDrive = 5;

        // constructor
        // since it is a requirement- constructor is a good idea

        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            _vinNumber = rand.Next(10_000, 1_000_000).ToString();
        }
        // properties
        public string Make { get; set; }
        public int Year { get; set; }

        public string Model { get; set; }

        // by setting the set to private; no one can change the mileage later on in the code.
        // only the means of driving can the mileage be updated 
        public int Mileage { get; private set; }

        public string Color { get; set; }

        public string CountryOfOrigin { get; set; }

        public bool IsInspected { get; set; }

        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }

        // methods

        public void Drive(int milesDriven)
        {
            // defineing the way that the drive method works:
            // this. does not have to be listed- it is implied.
            this.Mileage += milesDriven;
        }

        public void Drive(bool isFriend)
        {
            Mileage += _standardTestDrive + 5;
        }
    }
}