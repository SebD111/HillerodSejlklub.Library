using HillerødSejlklub.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlklub.Web.Pages
{
    public class AdminUsersModel : PageModel
    {
        IUserRepository _userRepository;

        public User Getuser
        { get; set; }
        public List<User> Userlist
        { get; set; }
        public string Name
        { get; set; }


        public AdminUsersModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            Userlist = new List<User>();


        }

        public void OnGet()
        {

            Userlist = _userRepository.GetAll();

        }

        public void OnPost(string input)
        {
            //SearchInput = input;
        }

        public void OnPostFindUser(string input)
        {

            List<User> users = _userRepository.GetAll();

            if (input == null)
            {
                Userlist = users;
                return;
            }

            foreach (User user in users)
            {

                if (user.Name.ToLower() == input.ToLower())
                {
                    Userlist.Add(user);
                }
                else
                {
                    //Do something
                }
            }

        }



    }
}