using KickSignupWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KickSignupWeb.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public SignMeUpModel Contact { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Contact.SignupDateTime = System.DateTime.Now;

            //write to sql  contactForm
            return Redirect("/Tak");
        }

    }
}
