using System;
using System.Collections.Generic;
using System.Text;



public class Event
{
    private static List<Event> _events = new List<Event>();

    // Auto-Properties for Event class
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; }
    public int MaxParticipants { get; set; }

    public const string DateTimeFormat = "dd-MM-yyyy HH:mm";

    // Opretter et event og tilføjer det til listen over _events
    public static Event Create(
        string title,
        DateTime start,
        DateTime end,
        string description,
        int participants,
        string location)
    {
        Event ev = new Event
        {
            Title = title,
            Description = description,
            Location = location,
            MaxParticipants = participants,
            StartDate = start,
            EndDate = end
        };

        _events.Add(ev);
        return ev;
    }

    // Udskriver alle events til konsollen
    public static void PrintAll()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEventliste i Hillerød Sejlklub");
        Console.ResetColor();
        Console.ForegroundColor= ConsoleColor.DarkGray;
        Console.WriteLine("-------------------------------------------");
        Console.ResetColor();

        foreach (Event ev in _events)
        {
            // Titel
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ev.Title);
            Console.ResetColor();

            // Detaljer
            Console.WriteLine($"  Start: {ev.StartDate.ToString(DateTimeFormat)}");
            Console.WriteLine($"  Slut:  {ev.EndDate.ToString(DateTimeFormat)}");
            Console.WriteLine($"  Sted:  {ev.Location}");
            Console.WriteLine($"  Deltagere (max): {ev.MaxParticipants}");
            Console.WriteLine($"  Beskrivelse: {ev.Description}");

            // Separator
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
    }
}