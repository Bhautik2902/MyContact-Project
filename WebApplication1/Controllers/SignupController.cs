using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SignupController : Controller
    {
        public IActionResult Signup()
        {
            return View("Views/Signup.cshtml");
        }

        [HttpPost]
        public string CreateUser([FromForm] User user)
        {
            return user.password;
        }
    }
}
