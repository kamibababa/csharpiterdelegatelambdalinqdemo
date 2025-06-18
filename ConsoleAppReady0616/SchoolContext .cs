using ConsoleAppReady0616.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Class> Classes => Set<Class>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "Server=localhost;Port=3306;Database=ef_school;User=root;Password=root;";
            optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
        }
    }
}
