namespace School.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using School.Web.Data;
    using System.Linq;

    [Route("api/[Controller]")]
    public class SubjectsController : Controller
    {
        private readonly DataContext dataContext;

        public SubjectsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult GetSubjects()
        {
            return Ok(this.dataContext.Subjects.ToList());
        }
    }
}
