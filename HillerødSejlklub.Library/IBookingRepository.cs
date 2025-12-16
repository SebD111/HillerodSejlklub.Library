using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public interface IBookingRepository
    {
        // Metoder
        void Add(Booking booking);
        void SafeReturn(int id);
        void ShowAllBoatInTheWater();
        void PrintAll();
        List<Booking> GetAll();

    }
}
