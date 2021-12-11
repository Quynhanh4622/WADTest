using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WADTest.Data;
using WADTest.Models;

namespace WADTest.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            
            return View();
        }

        public ActionResult Store(string name)
        {

            var student = new Student()
            {
                Name = name
            };
            myDBContext.Students.Add(student);
            myDBContext.SaveChanges();
            return View();
        }
    }
}