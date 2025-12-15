using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class ShowAllEventsModel : PageModel
    {

        private IEventRepository _eventRepository;

        public List<Event> Eventlist { get; set; }

        public ShowAllEventsModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void OnGet()
        {
            Eventlist = _eventRepository.GetAll();
        }
    }


}

