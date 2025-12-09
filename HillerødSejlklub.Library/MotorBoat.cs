using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class MotorBoat: Boat
    {
         public MotorBoat (int id, string boatType, string boatName, int sailNumber, string motorInfo, string boatDimensions, int yearOfConstruction): base(id, boatType, boatName, sailNumber, motorInfo, boatDimensions, yearOfConstruction)
        {

        }
    }
}
