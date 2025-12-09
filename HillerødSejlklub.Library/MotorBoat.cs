using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class MotorBoat: Boat
    {
         public MotorBoat (int id, string boatName, int sailNumber, Motor motor, string boatDimensions, int yearOfConstruction): base(id, boatName, sailNumber, boatDimensions, yearOfConstruction)
        {
            Motor = motor;
        }
        public Motor Motor { set; get; }
        public override void Print(Boat boat)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"ID: {boat.Id} - {boat.BoatName}");
            Console.ResetColor();

            Console.WriteLine($"  Type: {boat.BoatType}");
            Console.WriteLine($"  Sejlnummer: {boat.SailNumber}");
            Console.WriteLine($"  Motor: {boat.MotorInfo}");
            Console.WriteLine($"  Størrelse: {boat.BoatDimensions}");
            Console.WriteLine($"  Årgang: {boat.YearOfConstruction}");
            Console.WriteLine("-------------Boat Motor-------------");
            Console.WriteLine($"  Årgang: {Motor.Manufacturer}");
            Console.WriteLine($"  Årgang: {Motor.FuelType}");
            Console.WriteLine($"  Årgang: {Motor.Horsepower}");
            Console.WriteLine($"  Årgang: {Motor.Year}");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
    }
}
