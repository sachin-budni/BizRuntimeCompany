using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class StudentController : ApiController
    {
        //[Route("api/student/names")]
        //public IEnumerable<string> Get(int i,string name)
        //{
        //    return new string[] { "student1", "student2" };
        //}

        //[Route("api/student/names")]
        //public IEnumerable<string> Get(int id, string name)
        //{
        //    return new string[] { "student1", "student2" };
        //}
        [Route("api/stuent/names")]
        public Student Post(Student std)
        {
            return std;
        }
    }
}
