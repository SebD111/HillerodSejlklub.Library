using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class UserCreateModel : PageModel
    {
        IUserRepository _userRepository;


        public UserCreateModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string name, string adress, string phone, string email, bool admin)
        {

            User newUser = new User(name, adress, phone, email, admin);

            if (newUser != null)
            {
                _userRepository.Add(newUser);
            }

            return RedirectToPage("/AdminUsers");
        }

    }

}
