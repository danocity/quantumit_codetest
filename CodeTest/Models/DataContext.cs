using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeTest.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Class> Classes { get; set; }

        public DbSet<Student> Students { get; set; }

        public DataContext() : base("DefaultConnection")
        { }
    }
}