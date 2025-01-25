using Microsoft.EntityFrameworkCore;
using Review_Projects_Methods.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects.Infrastructure.DataContext
{
    public class DbReviewProjectsContext : DbContext
    {
        public DbReviewProjectsContext(DbContextOptions options) : base(options) { }

        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Mentoring> Mentorings { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

    }
}
