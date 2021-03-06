﻿using KickSignupWeb.Models;
using KickSignupWeb.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KickSignupWeb.Pages
{
    public class IndexModel : SignUpPageModel
    {
        private readonly ISignupRepository _repository;

        public IndexModel(ISignupRepository repository)
        {
            _repository = repository;
        }

    

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Contact.Area = "Kick";

            Contact.SignupDateTime = System.DateTime.Now;
            _repository.Insert(Contact);

            return Redirect("/Tak");
        }

    }
}
