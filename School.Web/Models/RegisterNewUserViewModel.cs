namespace School.Web.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using School.Web.Data.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RegisterNewUserViewModel : User
    {
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }

        [Display(Name = "Género")]
        public int GenderId { get; set; }

        public IEnumerable<SelectListItem> Genders { get; set; }
    }
}
