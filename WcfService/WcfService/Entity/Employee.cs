using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}