using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositories
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>,int>   {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCalendar> CourseCalendars { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<Day> Days { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
