using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library

{
    public class BoatRepository
    {

        private List<Boat> _boatData;

        public BoatRepository()
        {
            _boatData = new List<Boat>();

        }

        public List<Boat> GetAll()
        {
            return _boatData;
        }

        public Boat GetBoatById(int id)
        {
            foreach (Boat boat in _boatData)
            {
                if (boat.Id == id)
                {
                    return boat;
                }
            }

            return null;
        }

        public void AddBoat(Boat boat)
        {
            _boatData.Add(boat);
        }

        public Boat RemoveBoat(int id)
        {
            Boat BoatRemove = GetBoatById(id);

            if (BoatRemove != null)
            {

                _boatData.Remove(BoatRemove);
                return BoatRemove;
            }

            return null;

        }


        public void PrintAllBoats()
        {
            Console.WriteLine("Båd liste:");

            foreach (Boat boat in GetAll())
            {
                {
                    Console.WriteLine($"ID: {boat.Id} - Navn: {boat.Name} - Model: {boat.Model}");
                }
            }

        }

    }


}
