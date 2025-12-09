using System;
using System.Collections.Generic;
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
            BoatRepository.AddBoat(this);
        }
        // Auto-Properties for Boat class
        public int Id { get; set; }
        public string BoatType { get; set; }
        public string BoatName { get; set; }
        public string MotorInfo { get; set; }
        public int SailNumber { get; set; }
        public string BoatDimensions { get; set; }
        public int YearOfConstruction { get; set; }
    }// Nogle metoder kan være virtual, så subklasses kan override dem
}
