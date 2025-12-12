using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class Event
    {
        private List<User> _participants = new List<User>();
        
        public Event(string title, string description, DateTime startDate, DateTime endDate, string location, int maxParticipants)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
            MaxParticipants = maxParticipants;
            ParticipantList = _participants;
        }
        // Auto-Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public int MaxParticipants { get; set; }
        public List<User> ParticipantList { get; set; }
    }
}