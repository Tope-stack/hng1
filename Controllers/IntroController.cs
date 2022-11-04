using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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

        [HttpPost("calculate")]

        public IActionResult Index([Required] int x, [Required] int y, [Required] string operation_type)
        {
           //var operationType = operation.ToString();
            int result;
            switch(operation_type)
            {
                case "addition":
                    result = x + y;
                    break;

                case "subtraction":
                    result = x - y;
                    break;

                case "multiplication":
                    result = x * y;
                    break;

                default:
                    result = 00;
                    break;
            }

            var resultOutro = new Outro();

            if (result == 00)
            {
                return BadRequest("Invalid operation");
            }

            resultOutro.slackUsername = "Temitope_X";
            resultOutro.result = result;
            resultOutro.operation_type = operation_type;

            return Ok(resultOutro);
        }
    }
}


