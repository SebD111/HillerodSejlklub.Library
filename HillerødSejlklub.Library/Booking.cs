namespace HillerødSejlklub.Library
{
    public class Booking
    {
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
        }
        //Properties
        public int Id { get; set; }
        public Boat Boat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public int NrParticipant { get; set; }
        public string Destination { get; set; }   

        // Metode til at hente alle bookinger
        public void PrintAll()
        {
            BookingRepository repository = new BookingRepository();
            OverLay();
            foreach (Booking booking in repository.GetAll())
            {
                Print(booking);
            }
        }

        // Metode til at returnere en båd sikkert ved at fjerne bookingen baseret på ID
        public void ShowAllBoatInTheWater()
        {
            BookingRepository repository = new BookingRepository();
            DateTime time = DateTime.Now;
            foreach (Booking booking in repository.GetAll()) 
            {
                if (time <= booking.EndTime && time >= booking.StartTime) 
                {
                    Console.WriteLine($"{booking.Boat.BoatName} er på vandet. Tidsrum {booking.StartTime} - {booking.EndTime}");
                }
            }
        }
        public void OverLay() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAktive bookinger");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }
        public void Print(Booking booking) 
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
}
