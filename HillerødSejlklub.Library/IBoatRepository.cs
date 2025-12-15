using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public interface IBoatRepository
    {
        // Metoder
        List<Boat> GetAll();
        Boat GetById(int id);
        void Add(Boat boat);
        void Remove(int id);
        void PrintAll();
    }
}
