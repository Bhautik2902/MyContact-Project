using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AddContactController : Controller
    {
        // GET: AddContact
        public ActionResult AddContact()
        {
            return View("Views/AddContact.cshtml");
        }

        // GET: AddContact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddContact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddContact/Create
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

        // GET: AddContact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddContact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: AddContact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddContact/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
