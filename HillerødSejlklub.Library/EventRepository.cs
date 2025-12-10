using System;
using System.Collections.Generic;

namespace HillerødSejlklub.Library
{
    public class EventRepository : IEventRepository
    {
        // Intern samling af events
        private static readonly List<Event> _events = new List<Event>();

        // Udskriver alle events 
        public void GetAll()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEventliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            foreach (Event ev in _events)
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
        }

        // Tilføjer event til samlingen
        public Event Add(Event ev)
        {
            if (ev == null)
            {
                return null;
            }

            _events.Add(ev);
            return ev;
        }

        // Finder event baseret på præcis titel
        public Event GetByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return null;
            }

            foreach (Event ev in _events)
            {
                if (ev.Title == title)
                {
                    return ev;
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

            return null;
        }

    }

}


