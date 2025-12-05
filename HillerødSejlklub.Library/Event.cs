using System;
using System.Collections.Generic;
using System.Text;



public class Event
{
    private static List<Event> _events = new();

    // Auto-Properties for Event class
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; }
    public int MaxParticipants { get; set; }

    public const string DateTimeFormat = "dd-MM-yyyy HH:mm";

    // Opretter et event og tilføjer det til listen over events
    public static Event Create(
        string title,
        DateTime start,
        DateTime end,
        string description,
        int participants,
        string location)
    {
        var ev = new Event
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
        foreach (var ev in _events)
        {
            Console.WriteLine(
                $"Event: {ev.Title}\nStart: {ev.StartDate.ToString(DateTimeFormat)}\nSlut: {ev.EndDate.ToString(DateTimeFormat)}\nIndhold: {ev.Description}\nDeltagere (max): {ev.MaxParticipants}\nSted: {ev.Location}\n");
        }
    }

    // Udskriver et enkelt event til konsollen
    public void Print()
    {
        Console.WriteLine(
            $"Event: {Title}\nStart: {StartDate.ToString(DateTimeFormat)}\nSlut: {EndDate.ToString(DateTimeFormat)}\nIndhold: {Description}\nDeltagere (max): {MaxParticipants}\nSted: {Location}\n");
    }
}

