using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class AdminBoatsModel : PageModel
    {
        IBoatRepository _boatRepository;

        public Boat GetBoat
        { get; set; }
        public List<Boat> Boatlist
        { get; set; }
        public string Name
        { get; set; }


        public AdminBoatsModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
            Boatlist = new List<Boat>();


        }

        public void OnGet()
        {

            Boatlist = _boatRepository.GetAll();

        }

        public void OnPost(string input)
        {
            //SearchInput = input;
        }

        public void OnPostFindBoat(string input)
        {

            List<Boat> boats = _boatRepository.GetAll();

            if (input == null)
            {
                Boatlist = boats;
                return;
            }

            foreach (Boat boat in boats)
            {

                if (boat.BoatName.ToLower() == input.ToLower())
                {
                    Boatlist.Add(boat);
                }
                else
                {
                    //Do something
                }
            }

        }



    }
}
