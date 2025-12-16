using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class BoatCreateModel : PageModel
    {
        IBoatRepository _boatRepository;


        public BoatCreateModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(int id, string boatName, int sailNumber, string sailvolume, int numberOfOars, string boatDimensions, int yearOfConstruction, string boatType)
        {
            Boat newBoat = null;

            switch (boatType)
            {
                case "Sailboat":

                    newBoat = new SailBoat(id, boatName, sailNumber, boatDimensions, yearOfConstruction, "2x4 meter");
                    break;

                case "Motorboat":
                    Motor genericMotor = new Motor("Standard Motor", 100, "Diesel", 2023);

                    newBoat = new MotorBoat(id, boatName, sailNumber, genericMotor, boatDimensions, yearOfConstruction);


                    break;

                case "DinghyBoat":

                    newBoat = new DinghyBoat(id, boatName, sailNumber, boatDimensions, yearOfConstruction, 2);
                    break;

                default:

                    return Page();
            }


            if (newBoat != null)
            {
                _boatRepository.Add(newBoat);
            }

            return RedirectToPage("/AdminBoats");
        }

    }

}
