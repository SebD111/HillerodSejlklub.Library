using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class DinghyBoat: Boat
    {
        public DinghyBoat (int id, string boatName, int sailNumber,Motor motor, string boatDimensions, int yearOfConstruction, int numberOfOars): base(id, boatName, sailNumber, boatDimensions, yearOfConstruction)
        {
            NumberOfOars = numberOfOars;

        }

        public int NumberOfOars { get; set; }

    }
}
