using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public interface IBoatRepository
    {
        void Add(Boat boat);
        Boat GetById(int id);
        List<Boat> GetAll();
        void Remove(int id);
        void PrintAll();




    }
}
