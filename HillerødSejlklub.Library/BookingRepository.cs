using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class BookingRepository : IBookingRepository
    {
        private static List<Booking> _bookings = new List<Booking>();

        public void Add(Booking booking)
        {
            if (CheckBookingDate(booking.StartTime, booking.EndTime, booking.Boat))
            {
                Console.WriteLine($"Din tid er bekræftet");
                Print(booking);
                _bookings.Add(booking);
            }
            else
            {
                Console.WriteLine("Båden er optaget i det angivne tidsrum");
            }
        }
        public void SafeReturn(int id)
        {
            foreach (Booking booking in _bookings) // Gennemgår alle eksisterende bookinger
            {
                if (booking.Id == id) // Finder bookingen med det givne ID
                {
                    _bookings.Remove(booking); // Fjerner bookingen fra listen
                    Console.WriteLine("Velkommen hjem fra din tur");
                    return;
                }
            }
            Console.WriteLine("Bookingen blev ikke fundet");
        }
        public void ShowAllBoatInTheWater()
        {
            DateTime time = DateTime.Now;
            foreach (Booking booking in _bookings)
            {
                if (time <= booking.EndTime && time >= booking.StartTime)
                {
                    Console.WriteLine($"{booking.Boat.BoatName} er på vandet. Tidsrum {booking.StartTime} - {booking.EndTime}");
                }
            }
        }
        private bool CheckBookingDate(DateTime start, DateTime end, Boat boat)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.Boat == boat)
                {
                    if (start < booking.EndTime && end > booking.StartTime)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void PrintAll()
        {
            OverLay();
            foreach (Booking booking in _bookings)
            {
                Print(booking);
            }
        }

        private void OverLay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAktive bookinger");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }

        private void Print(Booking booking)
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
        public List<Booking> GetAll()
        {
            return _bookings;
        }

    }
}
