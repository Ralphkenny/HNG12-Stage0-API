﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace HNGApi__0_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var response = new InforResponse
            {
                email = "Kennedyokpala12@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/Ralphkenny"

            };

            return Ok(response);
        }
    }
}
