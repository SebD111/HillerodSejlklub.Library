namespace HillerødSejlklub.Library
{
    public class Booking
    {
        private static List<Booking> _bookings = new List<Booking>();
        private static int _idcounter = 0;

        // Constructor, som initialiserer en booking og tilføjer den til listen over bookinger
        public Booking(Boat boat, DateTime startTime, DateTime endTime, User user, int nrParticipant, string destination)
        {
            _idcounter++;
            Id = _idcounter;
            Boat = boat;
            StartTime = startTime;
            EndTime = endTime;
            User = user;
            NrParticipant = nrParticipant;
            Destination = destination;
            if (CheckBookingDate(startTime, endTime, boat))
            {
                Console.WriteLine($"Your time is confirmed heres your Id - {Id}");
                _bookings.Add(this);
            }
            else 
            {
                Console.WriteLine("The boat is not available in that time slot");
            }
        }
        //Properties
        public int Id { get; set; }
        public Boat Boat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public int NrParticipant { get; set; }
        public string Destination { get; set; }


        // Metode til at tjekke om en båd er ledig i det ønskede tidsrum
        private bool CheckBookingDate(DateTime start, DateTime end, Boat boat)
        {
            foreach (Booking booking in _bookings) // Gennemgår alle eksisterende bookinger
            {
                if (booking.Boat == boat) // Tjekker kun bookinger for den samme båd
                {
                    if (start < booking.EndTime && end > booking.StartTime) //Tjekker at der ikke er overlap i tidsrum
                    {
                        return false; 
                    }
                }
            }
            return true;
        }

        // Metode til at hente alle bookinger
        public void GetAll()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAktive bookinger");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            foreach (Booking booking in _bookings)
            {
                // Booking ID som hovedlinje
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Booking ID: {booking.Id}");
                Console.ResetColor();

                // Detaljer
                Console.WriteLine($"  Båd: {booking.Boat.BoatName}");
                Console.WriteLine($"  Bruger: {booking.User.Name}");
                Console.WriteLine($"  Start: {booking.StartTime}");
                Console.WriteLine($"  Slut: {booking.EndTime}");
                Console.WriteLine($"  Deltagere: {booking.NrParticipant}");
                Console.WriteLine($"  Destination: {booking.Destination}");

                // Separator
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-------------------------------------------");
                Console.ResetColor();
            }
        }

        // Metode til at returnere en båd sikkert ved at fjerne bookingen baseret på ID
        public void SafeReturn(int id)
        {
            foreach (Booking booking in _bookings) // Gennemgår alle eksisterende bookinger
            {
                if (booking.Id == id) // Finder bookingen med det givne ID
                {
                    _bookings.Remove(booking); // Fjerner bookingen fra listen
                    Console.WriteLine("Welcome back from the trip");
                    return;
                }
            }
            Console.WriteLine("Your booking could not be found");
        }

        // Metode til at tjekke hvilke både der er i vandet i et givent tidsrum
        public void BoatInTheWater(DateTime start, DateTime end)
        {
            foreach (Booking booking in _bookings) // Gennemgår alle eksisterende bookinger
            {
                if (start < booking.EndTime && end > booking.StartTime) // Tjekker om bookingen overlapper med det givne tidsrum
                {
                    Console.WriteLine($"{booking.Boat.BoatName} is in the water. Time slot {booking.StartTime} - {booking.EndTime}");
                }
            }
        }
    }
}
