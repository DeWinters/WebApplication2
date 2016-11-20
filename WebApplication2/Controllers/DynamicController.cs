using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DynamicController : Controller
    {
        // GET: Dynamic
        public ActionResult Dynamic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dynamic(DynamicModel obj)
        {

            ViewBag.Result = obj.PlayerName;
            return View();
        }
    }
}