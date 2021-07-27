
using System;

namespace CarInfo
{
    class Car
    {

        public string Model;
        public string Brand;
        public string Version;
        public double ExShowroomPrice;
        public int Capacity;
        public string Mileage;
        public Car(string brand,string model, string version, double exShowroomPrice, int capacity)
        {
            this.Brand = brand;
            this.Model = model;
            this.Version = version;
            this.ExShowroomPrice = exShowroomPrice;
            this.Capacity = capacity;
            this.Mileage = "18.3 to 24.5 kmpl";
        }

        public void displayDetails()
        {
            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Version: " + this.Version);
            Console.WriteLine("Ex-Showroom Price: ₹ "+this.ExShowroomPrice + "Lakh onwards");
            Console.WriteLine("Capacity: " + this.Capacity + " Seater");
            Console.WriteLine("Mileage: " + this.Mileage);
            Console.WriteLine("\n\n");
        }
    } 
}
