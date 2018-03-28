using EntityFrameWorkMVC.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkMVC.Controllers
{
    public class AboutController:Controller
    {
        public string First()
        {
            return "<h1>I Am From The First Method</h1>";
        }
        public ViewResult Index()
        {
            var emp = new Employee() { Id = 2, Name = "shiva", Age = 24 };
            return View(emp);
        }
        //public string Index()
        //{
        //    return "<h1>I am From the Home Controller Class </h1>";
        //}
    }
}
