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
        public override string ToString(Boat boat)
        {
            return
               "--------------------------------------- "+
              $"  \nMotorbåd info:\n" +
              $"    Id: {Id}\n" +
              $"    Navn: {BoatName}\n" +
              $"    Sejlnummer: {SailNumber}\n" +
              $"    Dimensioner: {BoatDimensions}\n" +
              $"    Byggeår: {YearOfConstruction}\n\n" + 
              Motor.ToString() + "\n" +
               "--------------------------------------- " + "\n";
        }
    }
}
