using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class UserDeleteModel : PageModel
    {
        IUserRepository _userRepository;


        public UserDeleteModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult OnGetRemoveUser(string userName)
        {
            _userRepository.RemoveByName(userName);
            return RedirectToPage("/AdminUsers");
        }
    }
}