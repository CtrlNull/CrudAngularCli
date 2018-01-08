using System;
using Microsoft.AspNetCore.Mvc;

namespace CrudAngularCli
{
    [Route("api/[Controller]")]
    public class CrudController : Controller
    {
        [HttpGet]
        public IActionResult Greetings() {
            return Ok("Hello from ASP.NET Core Web API.");
        }
    }
}