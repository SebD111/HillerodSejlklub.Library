using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library


{
    public class BoatRepository
    {

        private static Dictionary<string, Boat> _boatData = new Dictionary<string, Boat>();

        //Denne metode henter alle både i båd dictionary
        public List<Boat> GetAll()
        {
            return _boatData.Values.ToList();
        }
        // Denne metode henter en båd ud fra id
        public Boat GetBoatById(int id)
        {
            foreach (Boat boat in _boatData.Values) //Gennemgår alle både i båd dictionary
            {
                if (boat.Id == id) //Tjekker om bådens id matcher det givne id
                {
                    return boat;
                }
            }

            return null;
        }
        // Denne metode tilføjer en båd til båd dictionary
        public static Boat AddBoat(Boat boat)
        {
            _boatData.Add(boat.BoatName, boat); // Skal kigges på
            return boat;
        }
        // Denne metode fjerner en båd ud fra id
        public Boat RemoveBoat(int id)
        {
            Boat BoatRemove = GetBoatById(id); //Henter båden ud fra id

            if (BoatRemove != null) //Tjekker om båden findes
            {
                _boatData.Remove(BoatRemove.BoatName); // Fjerner båden fra båd dictionary
                return BoatRemove;
            }

            return null;

        }

        // Denne metode printer alle både i båd dictionary
        public void PrintAllBoats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBådliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            foreach (Boat boat in _boatData.Values)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"ID: {boat.Id} - {boat.BoatName}");
                Console.ResetColor();

                Console.WriteLine($"  Type: {boat.BoatType}");
                Console.WriteLine($"  Sejlnummer: {boat.SailNumber}");
                Console.WriteLine($"  Motor: {boat.MotorInfo}");
                Console.WriteLine($"  Størrelse: {boat.BoatDimensions}");
                Console.WriteLine($"  Årgang: {boat.YearOfConstruction}");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-------------------------------------------");
                Console.ResetColor();
            }
        }

    }

}