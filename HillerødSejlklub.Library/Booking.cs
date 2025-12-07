using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class Booking
    {
        private static List<Booking> _bookings = new List<Booking>();
        private static int _id = 0;
        public Booking(Boat boat, DateTime startTime, DateTime endTime, string user, int nrParticipant, string destination)
        {
            _id++;
            Boat = boat;
            StartTime = startTime;
            EndTime = endTime;
            User = user;
            NrParticipant = nrParticipant;
            Destination = destination;
            if (CheckBookingDate(startTime, endTime, boat))
            {
                _bookings.Add(this);
                Console.WriteLine($"Your time is confirmed. Id - {_id}");
            }
            else 
            {
                Console.WriteLine("The boat is not available in that time slot");
            }

        }
        public Boat Boat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string User { get; set; }
        public int NrParticipant { get; set; }
        public string Destination { get; set; }
        
        private bool CheckBookingDate(DateTime start, DateTime end, Boat boat)
        {
            foreach (var booking in _bookings)
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

        
        public void GetAll()
        {
            foreach(var booking in _bookings)
            {
                Console.WriteLine($"Boat: {booking.Boat.Id}\nStart: {booking.StartTime}, End: {booking.EndTime}\nUser: {booking.User}\nParticipants: {booking.NrParticipant}\nDestination: {booking.Destination}");
            }
        }

        public void SafeReturn(int id)
        {
            foreach (Booking booking in _bookings)
            {
                if (Booking._id == id)
                {
                    _bookings.Remove(booking);
                }
            }
            Console.WriteLine("Your booking could not be found");
        }
    }
}
