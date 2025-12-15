using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class Motor
    {
        // Constructor
        public Motor(string manufacturer, int horsepower, string fuelType, int year)
        {
            Manufacturer = manufacturer;
            Horsepower = horsepower;
            FuelType = fuelType;
            Year = year;
        }

        // Properties
        public string Manufacturer { get; set; }
        public int Horsepower { get; set; }
        public string FuelType { get; set; } 
        public int Year { get; set; }

        // Override ToString metode og return motor info
        public override string ToString()
        {
            return
                $"    Motorinfo:\n" +
                $"    Fabrikat: {Manufacturer}\n" +
                $"    Hestekræfter: {Horsepower} hk\n" +
                $"    Brændstof: {FuelType}\n" +
                $"    Årgang: {Year}";
        }

    }

}