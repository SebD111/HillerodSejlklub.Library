using System;
using System.Collections.Generic;

namespace HillerødSejlklub.Library
{
    public interface IEventRepository
    {
        // Metoder 
        void PrintAll();
        Event Add(Event ev);    
        Event GetByTitle(string title);
        Event RemoveByTitle(string title);
        void AddUserToEvent(string eventTitle, int id, UserRepository userRepository);
    }
}
