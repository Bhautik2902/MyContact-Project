using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBHelper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AddContactController : Controller
    {
        private readonly QueryHelper _queryHelper = null;
        public AddContactController(QueryHelper queryHelper)
        {
            _queryHelper = queryHelper;
        }
        // GET: AddContact
        public ActionResult AddContact()
        {
            int id = Convert.ToInt32((HttpContext.Session.GetString("UserId")));
            ViewBag.id = id;
            return View("Views/AddContact.cshtml");
        }
        
    
        // POST: AddContact/Create
        [HttpPost]
        public async Task<ActionResult> CreateContact(ContactModel contact)
        {
            int Id = Convert.ToInt32((HttpContext.Session.GetString("UserId")));
            ViewBag.id = Id;
            if (ModelState.IsValid)
            {
                int id = await _queryHelper.addContact(contact, Id);
                // if positive id, query successful.
                if (id > 0)
                {
                    ViewBag.isSuccess = 1;
                    ViewBag.message = "Success";
                    return View("Views/AddContact.cshtml");
                }
                else 
                {
                    ViewBag.isSuccess = 0;
                    ViewBag.message = "Something went wrong at server. Please try again later!";
                    return View("Views/AddContact.cshtml");
                }
            }
            return View("Views/AddContact.cshtml");
        }

    }
}
