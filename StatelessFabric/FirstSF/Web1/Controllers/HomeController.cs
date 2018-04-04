using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Web1.Controllers
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    [Route("api/[Controller]")]
    public class HomeController : Controller
    {
        List<Employee> emp = new List<Employee>();
        public IActionResult Index()
        {
            emp.Add(new Employee() {Id=1,Name="ramu",Age=32,Address="BTM" });
            emp.Add(new Employee() {Id=2,Name="Shiva",Age=22,Address="HSR" });
            emp.Add(new Employee() {Id=3,Name="Ranga",Age=31,Address="SKB" });
            emp.Add(new Employee() {Id=4,Name="Mallu",Age=65,Address="HRS" });
            return new JsonResult(emp);
        }
    }
}
