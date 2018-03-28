using EntityFrameWorkMVC.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkMVC.Controllers
{
    public class NewsController:Controller
    {
        //public ObjectResult Index()
        //{
        //    var emp = new Employee() { Id = 1, Name = "shiva", Age = 24 };

        //    return new ObjectResult(emp);
        //}
        //public ObjectResult Index()
        //{
        //    var emp = new Employee() { Id = 1, Name = "shiva", Age = 24 };
        //    var emp1 = new Employee() { Id = 2, Name = "sham", Age = 43 };
        //    var emp2 = new Employee() { Id = 3, Name = "ragu", Age = 73 };
        //    var emp3 = new Employee() { Id = 4, Name = "rajiv", Age = 42 };
        //    var emp4 = new Employee() { Id = 5, Name = "ranga", Age = 13 };
        //    var emp5 = new Employee() { Id = 6, Name = "abhi", Age = 74 };
        //    List<Employee> list = new List<Employee>();
        //    list.Add(emp);
        //    list.Add(emp1);
        //    list.Add(emp2);
        //    list.Add(emp3);
        //    list.Add(emp4);
        //    list.Add(emp5);
        //    return new ObjectResult(list);
        //}
        public ViewResult Index()
        {
            var emp = new Employee() { Id = 1, Name = "shiva", Age = 24 };
            var emp1 = new Employee() { Id = 2, Name = "sham", Age = 43 };
            var emp2 = new Employee() { Id = 3, Name = "ragu", Age = 73 };
            var emp3 = new Employee() { Id = 4, Name = "rajiv", Age = 42 };
            var emp4 = new Employee() { Id = 5, Name = "ranga", Age = 13 };
            var emp5 = new Employee() { Id = 6, Name = "abhi", Age = 74 };
            List<Employee> list = new List<Employee>();
            list.Add(emp);
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            list.Add(emp5);
            return View(list);
        }
    }
}
