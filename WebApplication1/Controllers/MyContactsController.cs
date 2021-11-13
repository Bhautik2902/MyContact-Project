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
        public async Task<ViewResult> MyContacts(int pageNumber=1)
        {
            HttpContext.Session.SetString("lastquery", "");

            int id = Convert.ToInt32((HttpContext.Session.GetString("UserId")));
            ViewBag.id = id;
            var allContacts = await _queryHelper.getAllContacts(id);
           
            const int pageSize = 7;
           
            int totalRecords = allContacts.Count();
            
            var pager = new Pager(totalRecords, pageNumber, pageSize);

            int skipped = (pageNumber - 1) * pageSize;
            var currentPageRecords = allContacts.Skip(skipped).Take(pager.pageSize).ToList();

            this.ViewBag.PagerInfo = pager;         // send pager details to the view.
            return View("Views/MyContacts.cshtml", currentPageRecords);
        }

        public async Task<ViewResult> SearchContact(string query, int pageNumber = 1)
        {   
            if (!string.IsNullOrEmpty(query))
            {
                HttpContext.Session.SetString("lastquery", query);
            }
          
            int id = Convert.ToInt32((HttpContext.Session.GetString("UserId")));
            ViewBag.id = id;
            var MatchedContacts = await _queryHelper.searchContacts(query, id);
            
            const int pageSize = 7;
            int totalRecords = MatchedContacts.Count();

            var pager = new Pager(totalRecords, pageNumber, pageSize);

            int skipped = (pageNumber - 1) * pageSize;
            var currentPageRecords = MatchedContacts.Skip(skipped).Take(pager.pageSize).ToList();

            this.ViewBag.PagerInfo = pager;         // send pager details to the view.
            return View("Views/MyContacts.cshtml", currentPageRecords);
        }

        public async Task<ViewResult> PagelinkResponse(int pageNumber = 1)
        {
            int id = Convert.ToInt32((HttpContext.Session.GetString("UserId")));
            ViewBag.id = id;

            string lastquery = HttpContext.Session.GetString("lastquery");
            if ( lastquery == "")
            {
                return await MyContacts(pageNumber);
            }
            else
            {
                return await SearchContact(lastquery, pageNumber);
            }
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
        public async Task<int> DeleteThisOne(int c_id)
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
    }
}
