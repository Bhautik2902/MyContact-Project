using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBHelper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SignupController : Controller
    {
        private readonly QueryHelper _queryHelper = null;

        public SignupController(QueryHelper queryHelper)
        {
            _queryHelper = queryHelper;
        }
        public IActionResult Signup()
        {
            return View("Views/Signup.cshtml");
        }

        [HttpPost]
        public async Task<ViewResult> CreateUser(UserModel user)
        {
            // if pass server side validation.
            if (ModelState.IsValid)
            {
                int id = await _queryHelper.addUser(user);
                // if positive id, query successful.
                if (id > 0)
                {
                    ViewBag.isSuccess = 1;
                    ViewBag.message = "Success";
                    return View("Views/Login.cshtml");
                }
                else if (id == 0)
                {
                    ViewBag.isSuccess = 0;
                    ViewBag.message = "Something went wront at server. Please try again later";
                    return View("Views/signup.cshtml");
                }
                else    // negative id, user already exist.
                {
                    ViewBag.isSuccess = 0;
                    ViewBag.message = "Email already exists! Please try another one.";
                    return View("Views/signup.cshtml");
                }
                
            }
            return View("Views/Signup.cshtml");
        }
    }
}
