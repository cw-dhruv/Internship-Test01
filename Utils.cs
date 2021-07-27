using System.Collections.Generic;
using System;

namespace CarInfo
{
    class Utils
    {   
        public static readonly string MARUTI_SUZUKI = "MARUTI SUZUKI";
        public static readonly string HYUNDAI = "HYUNDAI";
        public static readonly string TATA = "TATA";
        public static readonly string HONDA = "HONDA";
        public static List<Car> getCars()
        {
            var cars = new List<Car>(){};
            cars.Add(new Car(MARUTI_SUZUKI, "Baleno", "Sigma", 5.97, 5) );
            cars.Add(new Car(MARUTI_SUZUKI, "Swift", "Lxi", 5.81, 5));
            cars.Add(new Car(HYUNDAI, "Creta", "E 1.5 Petrol", 10.0, 5));
            cars.Add(new Car(HYUNDAI, "i20", "Magna 1.2 MT", 6.85, 5));
            cars.Add(new Car(HONDA, "City", "V Petrol", 11.02, 5));
            cars.Add(new Car(HONDA, "Amaze", "1.2 E MT Petrol", 6.25, 5));
            cars.Add(new Car(TATA, "Altroz", "XE PEtrol", 5.80, 5));
            cars.Add(new Car(TATA, "Nexon", "XM", 7.20, 5));

            return cars;

        }


    }
}