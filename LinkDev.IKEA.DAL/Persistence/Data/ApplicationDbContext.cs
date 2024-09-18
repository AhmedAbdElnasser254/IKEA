using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LinkDev.IKEA.DAL.Models.Departments;

namespace LinkDev.IKEA.DAL.Persistence.Data
{
    internal class ApplicationDbContext : DbContext
    {
        //second
        public ApplicationDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Server = .; Database = IKEA; Trusted_COnnection = True; TrustServerCertificate = True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> Departments { get; set; }


    }

}
