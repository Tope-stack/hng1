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

        public IActionResult Index([FromBody] Input inputRequest)
        {
            int result;
            switch(inputRequest.operation_type)
            {
                case "addition":
                    result = inputRequest.x + inputRequest.y;
                    break;

                case "subtraction":
                    result = inputRequest.x - inputRequest.y;
                    break;

                case "multiplication":
                    result = inputRequest.x * inputRequest.y;
                    break;

                default:
                    result = 00;
                    break;
            }

            if (result == 00)
            {
                return BadRequest("Invalid operation");
            }

            var resultOutro = new Outro();

            resultOutro.slackUsername = "Temitope_X";
            resultOutro.result = result;
            resultOutro.operation_type = inputRequest.operation_type;

            return Ok(resultOutro);
        }
    }
}


