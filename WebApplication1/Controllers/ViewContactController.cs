using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBHelper;

namespace WebApplication1.Controllers
{
    public class ViewContactController : Controller
    {
        private readonly QueryHelper _queryHelper = null;
        public ViewContactController(QueryHelper queryHelper)
        {
            _queryHelper = queryHelper;
        }
        // GET: ViewContactController
        public ActionResult ViewContact(int contactid, int userid)
        {
            var contact = _queryHelper.getContact(contactid);
            ViewBag.user_id = userid;
            ViewBag.contact_id = contactid;
            return View("Views/ViewContact.cshtml", contact);
        }

        // GET: ViewContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViewContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViewContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViewContactController/Edit/5
        [HttpPost]
        public async Task<string> updateContact(int userid, string fname, string lname, string email, string gender, string phone, string fax)
        {
            string status = await _queryHelper.updateContactDetails(userid, fname, lname, email, gender, phone, fax);
            return status;
        }
    }
}
