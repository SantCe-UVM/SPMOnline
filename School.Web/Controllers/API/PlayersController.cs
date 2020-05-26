namespace School.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using School.Web.Data;
    using System.Linq;

    [Route("api/[Controller]")]
    public class PlayersController : Controller
    {
        private readonly DataContext dataContext;

        public PlayersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult GetPlayers()
        {
            return Ok(this.dataContext.Players.ToList());
        }
    }
}
