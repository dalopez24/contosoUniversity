using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContonsoUniversity.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace ContonsoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
            Database.SetInitializer<SchoolContext>(new SchoolInitializer());
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }



    }
}