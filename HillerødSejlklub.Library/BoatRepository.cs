using HillerødSejlklub.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class BoatRepository : IBoatRepository
    {

        private static Dictionary<string, Boat> _boatData = new Dictionary<string, Boat>
    {
        { "KutterKnud", new MotorBoat(5,"KutterKnud", 67,new Motor("Suzuki", 80, "Diesel", 2010),"8M X 4M",2005) },
        { "JollenYolo", new DinghyBoat(6,"JollenYolo", 21,"3M X 1M",2020,2)},
        { "Zephyr", new SailBoat(7,"Zephyr",69,"5M x 2M",2022,"20 m²")}
    };
        //Denne metode henter alle både i båd dictionary
        public List<Boat> GetAll()
        {
            return _boatData.Values.ToList();
        }

        // Denne metode henter en båd ud fra id
        public Boat GetById(int id)
        {
            foreach (Boat boat in _boatData.Values) //Gennemgår alle både i båd dictionary //Overvej at søge på key
            {
                if (boat.Id == id) //Tjekker om bådens id matcher det givne id
                {
                    return boat;
                }
            }
            return null;
        }

        // Denne metode tilføjer en båd til båd dictionary
        public void Add(Boat boat)
        {
            _boatData.Add(boat.BoatName, boat); // Skal kigges på
        }

        // Denne metode fjerner en båd ud fra id
        public void Remove(int id)
        {
            Boat BoatRemove = GetById(id); //Henter båden ud fra id

            if (BoatRemove != null) //Tjekker om båden findes
            {
                _boatData.Remove(BoatRemove.BoatName); // Fjerner båden fra båd dictionary
            }
        }
        public void PrintAll() // Sæt ind i boat class
        {
            OverLay();
            BoatRepository repo = new BoatRepository();

            foreach (Boat boat in repo.GetAll())
            {
                Console.WriteLine(boat.ToString(boat));
            }
        }
        private void OverLay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBådliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
    }
}