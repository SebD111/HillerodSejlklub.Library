using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class Boat
    {
        public Boat(int id) 
    {
            Id = id;
        }
        public Boat(int id, string boatType, string boatName, int sailNumber, string motorInfo, string boatDimensions, int yearOfConstruction)
        {
            Id = id;
            BoatType = boatType;
            BoatName = boatName;
            SailNumber = sailNumber;
            MotorInfo = motorInfo;
            BoatDimensions = boatDimensions;
            YearOfConstruction = yearOfConstruction;
        }
        public int Id { get; set; }
        public string BoatType { get; set; }
        public string BoatName { get; set; }
        public string MotorInfo { get; set; }
        public int SailNumber { get; set; }
        public string BoatDimensions { get; set; }
        public int YearOfConstruction { get; set; }
    }
}
