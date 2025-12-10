using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    // Motor Klasse
    public class Motor
    {
        // Konstruktør
        public Motor(string manufacturer, int horsepower, string fuelType, int year)
        {
            Manufacturer = manufacturer;
            Horsepower = horsepower;
            FuelType = fuelType;
            Year = year;
        }

        // Auto-properties
        public string Manufacturer { get; set; }
        public int Horsepower { get; set; }
        public string FuelType { get; set; } // Benzin, Diesel, El
        public int Year { get; set; }

        // Override ToString metode for nem udskrift
        public override string ToString()
        {
            return
                $"  Motor:\n" +
                $"    Fabrikat: {Manufacturer}\n" +
                $"    Hestekræfter: {Horsepower} hk\n" +
                $"    Brændstof: {FuelType}\n" +
                $"    Årgang: {Year}";
        }

    }

}