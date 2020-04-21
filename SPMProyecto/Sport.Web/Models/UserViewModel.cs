namespace Sport.Web.Models
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Sport.Web.Data.Entities;
    using System.Collections.Generic;

    public class UserViewModel : User
    {
        public IFormFile ImageFile { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
