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
                booking.Print(booking);
                _bookings.Add(booking);
            }
            else
            {
                Console.WriteLine("Denne båd er ikke tilgængelig i dette tidsrum");
            }
        }
        public bool CheckBookingDate(DateTime start, DateTime end, Boat boat)
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

        public void SafeReturn(int id)
        {
            foreach (Booking booking in _bookings) // Gennemgår alle eksisterende bookinger
            {
                if (booking.Id == id) // Finder bookingen med det givne ID
                {
                    _bookings.Remove(booking); // Fjerner bookingen fra listen
                    Console.WriteLine("Velkommen tilbage fra din tur");
                    return;
                }
            }
            Console.WriteLine("Din booking kunne ikke findes");
        }
        public List<Booking> GetAll()
        {
            return _bookings;
        }
    }
}
