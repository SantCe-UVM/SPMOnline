namespace School.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using School.Web.Data;
    using System.Linq;

    [Route("api/[Controller]")]
    public class GendersController : Controller
    {
        private readonly DataContext dataContext;

        public GendersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult GetGenders()
        {
            return Ok(this.dataContext.Genders.ToList());
        }
    }
}
