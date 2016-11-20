using System.Web.Mvc;
using WebApplication2.Models;                           

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
           // var name = "Hey folks!";
            return View();
        }

        public ActionResult Student()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Student(StudentModel obj)
        {
            ViewBag.Output = "The Student is: " + obj.Name + " from Class :" + obj.Class + " accounted.";
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