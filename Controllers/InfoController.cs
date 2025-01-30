using Microsoft.AspNetCore.Mvc;

namespace HNGStage0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class InfoController : Controller
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new
            {
                email = "kennedyokpala12@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                github_url = "https://github.com/Ralphkenny"

            };

            return Ok(response);
        }
    }
}
