using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class BoatDeleteModel : PageModel
    {
        IBoatRepository _boatRepository;


        public BoatDeleteModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }
        public IActionResult OnGetRemoveBoat(int boatId)
        {
            _boatRepository.Remove(boatId);
            return RedirectToPage("/AdminBoats");
        }
    }
}
