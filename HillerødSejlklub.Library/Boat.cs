using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HillerødSejlklub.Library
{
    public abstract class Boat
    {
        // Constructor der initialiserer en båd og tilføjer den til BoatRepository
        public Boat(int id, string boatName, int sailNumber, string boatDimensions, int yearOfConstruction)
        {
            Id = id;
            BoatName = boatName;
            SailNumber = sailNumber;
           //Måske lave en klasse til motor info, lave den abscract base class
            BoatDimensions = boatDimensions;
            YearOfConstruction = yearOfConstruction;
            BoatRepository.Add(this);
        }
        // Auto-Properties for Boat class
        public int Id { get; set; }
        public string BoatType { get; set; }
        public string BoatName { get; set; }
        public string MotorInfo { get; set; }
        public int SailNumber { get; set; }
        public string BoatDimensions { get; set; }
        public int YearOfConstruction { get; set; }
        // Skal Fixes
        public void PrintAll() // Sæt ind i boat class
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBådliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
            
            foreach (Boat boat in BoatRepository.GetAll())
            {
                Print(boat);
            }
             
        }
        public virtual void Print(Boat boat)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"ID: {boat.Id} - {boat.BoatName}");
            Console.ResetColor();

            Console.WriteLine($"  Type: {boat.BoatType}");
            Console.WriteLine($"  Sejlnummer: {boat.SailNumber}");
            Console.WriteLine($"  Motor: {boat.MotorInfo}");
            Console.WriteLine($"  Størrelse: {boat.BoatDimensions}");
            Console.WriteLine($"  Årgang: {boat.YearOfConstruction}");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
    }// Nogle metoder kan være virtual, så subklasses kan override dem
}
