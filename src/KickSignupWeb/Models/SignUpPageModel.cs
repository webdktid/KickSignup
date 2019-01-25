using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KickSignupWeb.Models
{
    public class SignUpPageModel: PageModel
    {
        [BindProperty]
        public SignMeUpModel Contact { get; set; }
    }
}
