using System;
using System.ComponentModel.DataAnnotations;

namespace KickSignupWeb.Models
{
    public class SignMeUpModel
    {
        public int Id { get; set; } 

        [Display(Name = "Dit navn")]
        [Required(ErrorMessage = "Skriv dit navn")]
        public string Name { get; set; }

        [Display(Name = "Email adresse")]
        [Required(ErrorMessage = "Skriv din email adresse")]
        [EmailAddress(ErrorMessage = "Skriv en gyldig email adresse")]
        public string Email { get; set; }

        public DateTime SignupDateTime { get; set; }

        [Display(Name = "Ønsket klub")]
        public string PreferredClub { get; set; }

        [Display(Name = "Postnummer")]
        [Required(ErrorMessage = "Udfyld dit postnummer")]
        public string ZipCode { get; set; }

        [Display(Name = "Dit telefonnummer")]
        [Required(ErrorMessage = "Udfyld dit telefonnummer")]
        public string Phone { get; set; }

        public string Area { get; set; }

    }
}
