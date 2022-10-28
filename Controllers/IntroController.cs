using Microsoft.AspNetCore.Mvc;

namespace hng_task_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Intro intro = new Intro();
            intro.slackUsername = "Temitope_y";
            intro.backend = true;
            intro.age = 22;
            intro.bio = "Aspiring Backend Developer";

            
            return Ok(intro);
        }
    }
}
