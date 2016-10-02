using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FormControls_MVC5.Models
{
    public class FormsDbContext : DbContext
    {
        public FormsDbContext() : base("FormsConnection")
        {
        }
        public static FormsDbContext Create()
        {
            return new FormsDbContext();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<UserCountry> UserCountries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<UserDescription> UserDescriptions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}