using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet("project")]
        public string Project()
        {
            return "This is projects page!";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact";
        }
    }
}