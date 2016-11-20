using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;                           //

namespace WebApplication2.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Teacher(TeacherModel obj)
        {
            ViewBag.Blerb = "The Teacher is: " + obj.Name + " from Class :" + obj.Class + " accounted.";
            return View();
        }
    }
}