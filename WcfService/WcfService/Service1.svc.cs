using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Data;
using WcfService.Entity;

namespace WcfService
{
    public class Service : IService
    {
        public MyDbContext db = new MyDbContext();
        public Employee Save(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }
        public List<Employee> SearchEmployee(string keyword)
        {
            if (keyword != null)
            {
                var employee = from em in db.Employees
                         .Where(e => e.Department.Equals(keyword))
                               select em;
                return employee.ToList();
            }
            else
            {
                return db.Employees.ToList();
            }

        }
    }
}
