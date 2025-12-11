using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class SailBoat:Boat
    {
        public SailBoat (int id, string boatName, int sailNumber, string boatDimensions, int yearOfConstruction, string sailVolume): base(id, boatName, sailNumber, boatDimensions, yearOfConstruction)
        {
           SailVolume = sailVolume;
        }

        public string SailVolume { get; set; }

        public override string ToString(Boat boat)
        {
            return
                 "--------------------------------------- "+
                $"  \nSejlbåd info:\n" +
                $"    Id: {Id}\n" +
                $"    Navn: {BoatName}\n" +
                $"    Sejlnummer: {SailNumber}\n" +
                $"    Dimensioner: {BoatDimensions}\n" +
                $"    Byggeår: {YearOfConstruction}\n" +
                $"    Sejlvolumen: {SailVolume}\n"+ 
                "--------------------------------------- " +
                "\n";
        }
    }
}
