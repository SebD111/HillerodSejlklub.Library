using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HillerødSejlklub.Library
{
    public abstract class Boat
    {
        // Constructor 
        public Boat(int id, string boatName, int sailNumber, string boatDimensions, int yearOfConstruction)
        {
            Id = id;
            BoatName = boatName;
            SailNumber = sailNumber;
            BoatDimensions = boatDimensions;
            YearOfConstruction = yearOfConstruction;
        }
        //Properties 
        public int Id { get; set; }
        public string BoatName { get; set; }
        public int SailNumber { get; set; }
        public string BoatDimensions { get; set; }
        public int YearOfConstruction { get; set; }

        // Metode 
        public virtual string ToString(Boat boat) 
        {
            return "";
        }
    }
}
