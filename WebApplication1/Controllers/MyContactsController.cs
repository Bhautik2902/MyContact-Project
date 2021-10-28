using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class MyContactsController : Controller
    {
        private readonly QueryHelper _queryHelper = null;
        public MyContactsController(QueryHelper queryHelper)
        {
            _queryHelper = queryHelper;
        }
        // GET: MyContactsController
        public async Task<ViewResult> MyContacts(int id)
        {
            ViewBag.id = id;
            var allContacts = await _queryHelper.getAllContacts(id); 
            return View("Views/MyContacts.cshtml", allContacts);
        }

        [HttpPost]
        public async Task<int> deleteSelectedContacts(string selectedIds)
        {
            string selectedIds_str = selectedIds.Substring(1, selectedIds.Length - 2);
            string[] ids = selectedIds_str.Split(',');
            
            string status = await _queryHelper.deleteSelected(ids);   
            
            TempData["error_msg"] = status;
            return 1;
        }

        [HttpPost]
        public async Task<int> DeleteThisOne(int c_id, int u_id)
        {
            string status = await _queryHelper.deleteIndividual(c_id);
            if (status == "Success")
            {
                return 1;  // success
            }
            else if (status == "Not found")
            {
                TempData["error_msg"] = status;
                return 0;  // not found
            }
            else
            {
                TempData["error_msg"] = status;
                return -1;  // error occured
            }
        }

        // GET: MyContactsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyContactsController/Edit/5
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

        // GET: MyContactsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyContactsController/Delete/5
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
