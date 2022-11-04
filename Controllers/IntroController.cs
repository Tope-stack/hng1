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

        public IActionResult Index([Required] int x, [Required] int y, [Required] operation_type operation)
        {
           var operationType = operation.ToString();
            int result = 0;
            switch(operation)
            {
                case operation_type.addition:
                    result = x + y;
                    break;

                case operation_type.subtraction:
                    result = x - y;
                    break;

                case operation_type.multiplication:
                    result = x * y;
                    break;

                default:
                    break;
            }

            var resultOutro = new Outro
            {
                slackUsername = "Temitope_X",
                result = result,
            };

            return Ok(resultOutro);
        }
    }
}


