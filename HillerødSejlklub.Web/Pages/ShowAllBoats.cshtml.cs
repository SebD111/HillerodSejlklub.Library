using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class ShowAllBoatsModel : PageModel
    {

        private IBoatRepository _boatRepository;

        public List<Boat> Boatlist { get; set; }

        public ShowAllBoatsModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        public void OnGet()
        {
            Boatlist = _boatRepository.GetAll();
        }
    }


}