using System.Web.Mvc;
using WebApplication2.Models;                   //                 

namespace WebApplication2.Controllers
{
    public class TeacherController : Controller
    {

//        public ActionResult Index()
//        {
//            return View();
//        }

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