namespace School.Web.Models
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using School.Web.Data.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class StudentViewModel : Student
    {
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Género")]
        public int  GenderId { get; set; }

        public IEnumerable<SelectListItem> Genders { get; set; }
    }
}
