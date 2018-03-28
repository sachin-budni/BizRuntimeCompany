using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWorkMVC.Model;

namespace EntityFrameWorkMVC.Controllers
{
    public class HomeController:Controller
    {
        //public string Index()
        //{
        //    return "<h1>I am From the Home Controller Class </h1>";
        //}
        //public ObjectResult Index()
        //{
        //    var emp = new Model.Employee() { Id = 1, Name = "Ramu", Age = 25 };
        //    return new ObjectResult(emp);
        //}
        //public ViewResult Abouts()
        //{
        //    var emp = new Employee() { Id = 2, Name = "shiva", Age = 26 };
        //    return View(emp);
        //}
        public ActionResult contact()
        {
            return View();
        }
        public ViewResult Index()
        {
            var emp = new Employee() { Id = 1, Name = "ramu", Age = 25 };
            return View(emp);
        }
    }
}
