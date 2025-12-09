using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class SailBoat:Boat
    {
        public SailBoat (int id, string boatName, int sailNumber, string boatDimensions, int yearOfConstruction): base(id, boatName, sailNumber, boatDimensions, yearOfConstruction)
        {
            
        }
    }
}
