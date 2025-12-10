using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class Event
    {
        // Auto-Properties for Event class
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public int MaxParticipants { get; set; }

        public const string DateTimeFormat = "dd-MM-yyyy HH:mm";
    }
}