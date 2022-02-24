using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfService.Entity;

namespace WcfService.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=ConnectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}