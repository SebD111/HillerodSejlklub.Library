using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace HillerødSejlklub.Library
{
    public class EventRepository : IEventRepository
    {
        // instance field
        private static List<Event> _events = new List<Event>()
    {
        { new Event("Rave party","Vi smadrer loftet", new DateTime(2026,1 , 13, 10,00,00), new DateTime(2026, 01, 13, 12, 00, 00), "Hillerødsejlklub", 0)},
    };

        // Metoder

        // Tilføjer event til samlingen
        public Event Add(Event ev)
        {
            if (ev == null) // Tjekker om event er null
            {
                return null;
            }
            else
            {
                _events.Add(ev);
                return ev;
            }
        }

        // Henter event baseret på titelen
        public Event GetByTitle(string title)
        { 
            if (title == null) // Tjekker om title er null
            {
                return null;
            }

            for (int i = 0; i <_events.Count; i++) // Gennemgår alle events i samlingen
            {
                Event thisEvent = _events[i]; // Henter det aktuelle event

                if (thisEvent.Title == title) // Tjekker om titelen matcher
                {
                    return thisEvent;
                }
            }
            return null;
        }

        // Fjerner event baseret på titelen
        public Event RemoveByTitle(string title)
        {
            Event ev = GetByTitle(title); // Henter eventet ved hjælp af GetByTitle metoden
            if (ev != null) // Tjekker om eventet findes
            {
                _events.Remove(ev);
                Console.WriteLine($"Event Fjernet:{title}");
                return ev;
            }
            else
            {
                return null;
            }
        }
        // Tilføjer en bruger til et event baseret på event titel og bruger id
        public void AddUserToEvent(string eventTitle, int userId, UserRepository userRepository)
        {
            Event ev = GetByTitle(eventTitle); // Henter eventet ved hjælp af GetByTitle metoden

            if (ev == null) // Tjekker om eventet findes 
            {
                Console.WriteLine($"{eventTitle} findes ikke");
                return;
            }

            User user = userRepository.GetById(userId); // Henter brugeren ved hjælp af UserRepository
            if (user == null) //Tjekker om brugeren findes
            {
                Console.WriteLine($"Bruger med ID {userId} findes ikke");
                return;
            }

            if (ev.ParticipantList.Count >= ev.MaxParticipants) // Tjekker om der er plads til flere i eventet
            {
                Console.WriteLine($"{ev.Title} er fuldt booket");
                
            }
            else

            {
                ev.ParticipantList.Add(user); 
                Console.WriteLine($"{user.Name} er nu tilføjet");
                Console.WriteLine($"Der er {ev.ParticipantList.Count} medlemmere tilmedt til eventet ud af {ev.MaxParticipants}");
            }

        }

        // Udskriver alle events i samlingen
        public void PrintAll()
        {
            OverLay();
            for (int i = 0; i < _events.Count; i++)
            {
                Event ev = _events[i];
                Print(ev);
            }
        }

        // OverLay til event
        private void OverLay() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEventliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }

        // Udskriver et event
        private void Print(Event ev) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ev.Title);
            Console.ResetColor();

            Console.WriteLine($"  Start: {ev.StartDate}");
            Console.WriteLine($"  Slut:  {ev.EndDate}");
            Console.WriteLine($"  Sted:  {ev.Location}");
            Console.WriteLine($"  Deltagere (max): {ev.MaxParticipants}");
            Console.WriteLine($"  Beskrivelse: {ev.Description}");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }

        // Udskriver antallet af events
        public int EventCount()
        {
            return _events.Count;
        }

        // Får alle bookings i listen (Bruges til razor page)
        public List<Event> GetAll()
        {
            return _events;
        }
    }
}


