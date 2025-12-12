namespace HillerødSejlklub.Library
{
    public class Booking
    {
        private static int _idCounter = 0;

        // Constructor, som initialiserer en booking og tilføjer den til listen over bookinger
        public Booking(Boat boat, DateTime startTime, DateTime endTime, User user, int nrParticipant, string destination)
        {
            _idCounter++;
            Id = _idCounter;
            Boat = boat;
            StartTime = startTime;
            EndTime = endTime;
            User = user;
            NrParticipant = nrParticipant;
            Destination = destination;
        }
        //Properties
        public int Id { get; set; }
        public Boat Boat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public int NrParticipant { get; set; }
        public string Destination { get; set; }   


    }
}
