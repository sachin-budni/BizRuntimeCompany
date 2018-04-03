using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_net_WebApi.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }
}