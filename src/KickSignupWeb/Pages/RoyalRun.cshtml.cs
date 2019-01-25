using KickSignupWeb.Models;
using KickSignupWeb.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KickSignupWeb.Pages
{
    public class RoyalRunModel : SignUpPageModel
    {
        private readonly ISignupRepository _repository;

        public RoyalRunModel(ISignupRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public SignMeUpModel Contact { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Contact.Area = "Royal Run";
            Contact.SignupDateTime = System.DateTime.Now;
            _repository.Insert(Contact);

            return Redirect("/Tak");
        }

    }
}
