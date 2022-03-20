using Microsoft.AspNetCore.Mvc;

namespace DesafioSoftplan.Api2.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {

        [HttpGet(Name = "showmethecode")]
        public IActionResult Get()
        {
            return Ok("https://github.com/dguaragni/desafiosoftplan");
        }
    }
}