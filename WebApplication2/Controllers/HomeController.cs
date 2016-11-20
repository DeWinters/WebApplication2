using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var player = "Frank Herbert";
            ViewBag.Player = "Don johnson";

            return View();
        }

//        public ActionResult AddPlayer(string playerName)
//        {
//            ViewBag.PlayerName = playerName;
//            return View("Index", ViewBag.PlayerName);
//        }


        [HttpPost]
        public ActionResult Index(HomeModel obj)
        {
            //var model = new WebApplication2.Models.HomeModel();
            // model.PlayerName = playerName;
            //return View("Index",model);

            //ViewBag.PlayerName = playerName;
            //return View();

           // HomeModel(obj.PlayerName);
             ViewBag.Result = obj.PlayerName;
             return View();
        }
    }
}