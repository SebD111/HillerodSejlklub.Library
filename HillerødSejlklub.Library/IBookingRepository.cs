using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public interface IBookingRepository
    {
        bool CheckBookingDate(DateTime start, DateTime end, Boat boat);
        void SafeReturn(int id);
        void Add(Booking booking);
        List<Booking> GetAll(); 

    }
}
