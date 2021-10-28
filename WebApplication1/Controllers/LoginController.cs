using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBHelper;
using WebApplication1.EntityModels;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private readonly QueryHelper _queryHelper = null;
        public LoginController(QueryHelper queryHelper)
        {
            _queryHelper = queryHelper;
        }

        public ActionResult Login()
        {
            return View("Views/Login.cshtml");
        }

        // get credentials from login form and varify details.
        public async Task<RedirectToActionResult> Details(string email, string password)
        {
            if (email == null || password == null)
            {
                TempData["errormsg"] = "Both field required!";
            }
            else
            {
                string hashedpass = _queryHelper.getHash(password);
                var userid = _queryHelper.getUserId(email, hashedpass);
                if (userid > 0)
                {
                    HttpContext.Session.SetString("Email", email);
                    HttpContext.Session.SetString("Password", hashedpass);

                    return RedirectToAction("Homepage", "Home", new { id = userid });
                }
                else
                {
                    TempData["errormsg"] = "Credentials were incorrect. Try again!";
                }
            }
            return RedirectToAction("Login", "Login");
        }

    } 
}
