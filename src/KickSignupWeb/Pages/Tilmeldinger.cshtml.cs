using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KickSignupWeb.Models;
using KickSignupWeb.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace KickSignupWeb.Pages
{
  
    public class TilmeldingerModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ISignupRepository _signupRepository;

        public List<SignMeUpModel> Signups = new List<SignMeUpModel>();


        public TilmeldingerModel(IConfiguration configuration, ISignupRepository  signupRepository)
        {
            _configuration = configuration;
            _signupRepository = signupRepository;
        }


        public IActionResult OnGet()
        {
            Signups = _signupRepository.GetAll();

            return Page();
        }
    }
}