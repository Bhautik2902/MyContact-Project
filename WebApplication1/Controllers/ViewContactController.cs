using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ViewContactController : Controller
    {
        // GET: ViewContactController
        public ActionResult ViewContact()
        {
            return View("Views/ViewContact.cshtml");
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

        // GET: ViewContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViewContactController/Delete/5
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
