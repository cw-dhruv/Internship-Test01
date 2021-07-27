using System;
using System.Collections.Generic;
using Humanizer;

namespace CarInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets car data from Utils
            var cars = Utils.getCars();
            Console.WriteLine("\nBrand\t\t\t\t\tModel\t\t\t\t\tVersion");

            drawLine();

            //Displays all the available cars
            foreach(var car in cars){
                Console.WriteLine($"{cars.IndexOf(car)+1}) {car.Brand}\t\t\t\t{car.Model}\t\t\t\t{car.Version}");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Enter Car No. for details:");
            
            string s = Console.ReadLine();
            int num = (int)s[0];

            drawLine(); 

            //Specific Car details
            if ((s.Length==1) && ( num > 48) && (num <= cars.Count + 48) ){
                int i = num-48 ;
                var currentCar = cars[i-1];
                currentCar.displayDetails();
            }
            Console.WriteLine("Thank you for Visiting us....\n\n");
            

        }
        

        private static void drawLine()
        {
            // Console.WriteLine();
            for(int i=0; i<100; i++)Console.Write("-");
            Console.WriteLine();
        }
    }
}
