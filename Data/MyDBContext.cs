using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WADTest.Models;

namespace WADTest.Data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext() : base("name = MyDbContext")
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}