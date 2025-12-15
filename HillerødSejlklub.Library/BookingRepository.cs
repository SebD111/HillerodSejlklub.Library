using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class BookingRepository : IBookingRepository
    {
        // instance field
        private static List<Booking> _bookings = new List<Booking>();

        // Metoder

        // Denne metode tilføjer en booking til listen over booking
        public void Add(Booking booking)
        {
            if (CheckBookingDate(booking.StartTime, booking.EndTime, booking.Boat)) // Tjekker om båden er ledig i det angivne tidsrum
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

        // Denne metode fjerner en booking ud fra booking id
        public void SafeReturn(int id)
        {
            foreach (Booking booking in _bookings) 
            {
                if (booking.Id == id) 
                {
                    _bookings.Remove(booking); 
                    Console.WriteLine("Velkommen hjem fra din tur");
                    return;
                }
            }
            Console.WriteLine("Bookingen blev ikke fundet");
        }

        // Denne metode viser alle både som er i vandet lige nu
        public void ShowAllBoatInTheWater()
        {
            DateTime time = DateTime.Now; // Henter det nuværende tidspunkt
            foreach (Booking booking in _bookings)
            {
                if (time <= booking.EndTime && time >= booking.StartTime) // Tjekker om den nuværende tid er inden for bookingens start- og sluttid
                {
                    Console.WriteLine($"{booking.Boat.BoatName} er på vandet. Tidsrum {booking.StartTime} - {booking.EndTime}");
                }
            }
        }

        // Denne metode tjekker om båden er ledig i det angivne tidsrum
        private bool CheckBookingDate(DateTime start, DateTime end, Boat boat)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.Boat == boat)
                {
                    if (start < booking.EndTime && end > booking.StartTime) // Tjekker for overlap mellem bookinger
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Denne metode udskriver alle bookinger i listen
        public void PrintAll()
        {
            OverLay();
            foreach (Booking booking in _bookings)
            {
                Print(booking);
            }
        }

        // Overlay til booking
        private void OverLay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAktive bookinger");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }

        // Denne metode udskriver en enkelt booking
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

        // Får alle bookings i listen (Bruges til razor page)
        public List<Booking> GetAll()
        {
            return _bookings;
        }

    }
}
