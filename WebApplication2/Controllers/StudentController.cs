﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;                           //

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Student(StudentModel obj)
        {
            return View();
        }
    }
}