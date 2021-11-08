using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBHelper;
using WebApplication1.EntityModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QueryHelper _queryHelper = null;
        public HomeController(ILogger<HomeController> logger, QueryHelper queryHelper)
        {
            _logger = logger;
            _queryHelper = queryHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        // on logout.
        public ActionResult Login()
        {
            HttpContext.Session.Clear();
            return View("Views/Home/Index.cshtml");
        }

        public ViewResult Homepage()
        {
            int id = Convert.ToInt32((HttpContext.Session.GetString("UserId")));
            var user = _queryHelper.getUser(id);
            if (user != null)
            {
                ViewBag.isSuccess = true;
                return View("Views/Homepage.cshtml", user);
            }
            else
            {
                ViewBag.isSuccess = false;
                return View("Views/Homepage.cshtml", user);
            }          
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
