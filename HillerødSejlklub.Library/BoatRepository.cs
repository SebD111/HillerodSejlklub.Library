using HillerødSejlklub.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class BoatRepository : IBoatRepository
    {
        // Dictionary 
        private static Dictionary<string, Boat> _boatData = new Dictionary<string, Boat>
        {
            { "KutterKnud", new MotorBoat(1,"KutterKnud", 67,new Motor("Suzuki", 80, "Diesel", 2010),"8M X 4M",2005) },
            { "JollenYolo", new DinghyBoat(2,"JollenYolo", 21,"3M X 1M",2020,2)},
            { "Zephyr", new SailBoat(3,"Zephyr",69,"5M x 2M",2022,"20 m²")}
        };
        //Metoder

        // Metode til at hente alle brugere som en liste
        public List<Boat> GetAll()
        {
            return _boatData.Values.ToList();
        }

        // Denne metode henter en båd ud fra id
        public Boat GetById(int id)
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

        // Denne metode tilføjer en båd til båd dictionary
        public void Add(Boat boat)
        {
            _boatData.Add(boat.BoatName, boat);
        }

        // Denne metode fjerner en båd ud fra id
        public void Remove(int id)
        {
            Boat BoatRemove = GetById(id); //Henter båden ud fra id

            if (BoatRemove != null) //Tjekker om båden findes
            {
                _boatData.Remove(BoatRemove.BoatName); 
            }
        }

        // Denne metode udskriver alle både i båd dictionary
        public void PrintAll() 
        {
            OverLay();
            BoatRepository repo = new BoatRepository();

            foreach (Boat boat in repo.GetAll())
            {
                Console.WriteLine(boat.ToString(boat));
            }
        }

        // OverLay til bådliste
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