using System;
using System.Collections.Generic;

namespace HillerødSejlklub.Library
{
    public interface IEventRepository
    {
        // Udskriver alle events 
        void PrintAll();

        // Tilføjer et event til samlingen
        Event Add(Event ev);    

        // Finder et event baseret på titel 
        Event GetByTitle(string title);

        // Fjerner et event baseret på titel 
        Event RemoveByTitle(string title);

        // Tilføjer en bruger til et event baseret på eventets titel og brugerens id
        void AddUserToEvent(string eventTitle, int id, UserRepository userRepository);
    }
}
