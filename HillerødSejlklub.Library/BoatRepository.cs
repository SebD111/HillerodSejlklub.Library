using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library

{
    public class BoatRepository
    {

        private static Dictionary<string,Boat> _boatData = new Dictionary<string,Boat>();


        public List<Boat> GetAll()
        {
            return _boatData.Values.ToList();
        }

        public Boat GetBoatById(int id)
        {
            foreach (Boat boat in _boatData.Values)
            {
                if (boat.Id == id)
                {
                    return boat;
                }
            }

            return null;
        }

        public static Boat AddBoat(Boat boat)
        {
            _boatData.Add(boat.BoatName, boat);
            return boat;
        }

        public Boat RemoveBoat(int id)
        {
            Boat BoatRemove = GetBoatById(id);

            if (BoatRemove != null)
            {

                _boatData.Remove(BoatRemove.BoatName);
                return BoatRemove;
            }

            return null;

        }


        public void PrintAllBoats()
        {
            Console.WriteLine("Båd liste:");

            foreach (Boat boat in _boatData.Values)
            {
                {
                    Console.WriteLine($"ID: {boat.Id} - Navn: {boat.BoatName} - Model: {boat.BoatType}");
                }
            }

        }

    }


}
