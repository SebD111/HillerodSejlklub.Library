using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class DinghyBoat: Boat
    {
        public DinghyBoat (int id, string boatName, int sailNumber, string boatDimensions, int yearOfConstruction, int numberOfOars): base(id, boatName, sailNumber, boatDimensions, yearOfConstruction)
        {
            NumberOfOars = numberOfOars;

        }

        public int NumberOfOars { get; set; }

        public override string ToString(Boat boat)
        {
            return
                "--------------------------------------- "+
                $"  \nJolle info:\n" +
                $"    Id: {Id}\n" +
                $"    Navn: {BoatName}\n" +
                $"    Sejlnummer: {SailNumber}\n" +
                $"    Dimensioner: {BoatDimensions}\n" +
                $"    Byggeår: {YearOfConstruction}\n" +
                $"    Antal årer: {NumberOfOars}\n"+
                "--------------------------------------- " +
                "\n"; ;
        }
    }
}
