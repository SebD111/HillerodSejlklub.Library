using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace HillerødSejlklub.Library
{
    public class EventRepository : IEventRepository
    {
        // Intern samling af events
        private static readonly List<Event> _events = new List<Event>();

        // Udskriver alle events 
        public void PrintAll()
        {
            OverLay();
            for (int i = 0; i < _events.Count; i++)
            {
                Event ev = _events[i];
                PrintEvent(ev);
            }
        }

        // Tilføjer event til samlingen
        public Event Add(Event ev)
        {
            if (ev == null)
            {
                return null;
            }
            else
            {
                _events.Add(ev);
                return ev;
            }
        }

        // Finder event baseret på præcis titel
        public Event GetByTitle(string title)
        { 
            if (string.IsNullOrWhiteSpace(title))
            {
                return null;
            }

            for (int i = 0; i <_events.Count; i++)
            {
                Event thisEvent = _events[i];
                
                if (thisEvent.Title == title)
                {
                    return thisEvent;
                }
            }
            return null;
        }

        // Fjerner event baseret på præcis titel
        public Event RemoveByTitle(string title)
        {
            Event ev = GetByTitle(title);
            if (ev != null)
            {
                _events.Remove(ev);
                Console.WriteLine("Event Fjernet:");
                return ev;
            }
            else
            {
                return null;
            }
        }
        private void OverLay() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEventliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
        private void PrintEvent(Event ev) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ev.Title);
            Console.ResetColor();

            Console.WriteLine($"  Start: {ev.StartDate.ToString(Event.DateTimeFormat)}");
            Console.WriteLine($"  Slut:  {ev.EndDate.ToString(Event.DateTimeFormat)}");
            Console.WriteLine($"  Sted:  {ev.Location}");
            Console.WriteLine($"  Deltagere (max): {ev.MaxParticipants}");
            Console.WriteLine($"  Beskrivelse: {ev.Description}");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
        // Denne metode tilføjer en bruger til et event
        public void AddUserToEvent(string eventTitle,int userId, UserRepository userRepository)
        {
            Event ev = GetByTitle(eventTitle); // 

            if (ev == null) // Tjekker om eventet findes 
            {
                Console.WriteLine($"{eventTitle} findes ikke");
                return;
            }
                
            User user = userRepository.GetById(userId); 
            if (user == null) //Tjekker om brugeren findes
            {
                Console.WriteLine($"Bruger med ID {userId} findes ikke");
                return;
            }

            if(ev.ParticipantList.Count >= ev.MaxParticipants) // Tjekker om der er plads til flere i eventet
            {
                Console.WriteLine($"{ev.Title} er fuldt booket");
                Console.WriteLine($"Der er {Count()} medlemmere tilmedt til eventet ud af {ev.MaxParticipants}");
            }
            else

            {
                ev.ParticipantList.Add(user); // Tilføjer en user til Participantlist
                Console.WriteLine($"{user.Name} er nu tilføjet");
                Console.WriteLine($"Der er {Count()} medlemmere tilmedt til eventet ud af {ev.MaxParticipants}");
            }
           
        } 


        public int Count()
        {
            return _events.Count;
        }
    }
}


