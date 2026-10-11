
using Microsoft.EntityFrameworkCore;
using Model.DomainModels.Pipeline;
using System;

namespace Model
{
    public class ProjectDbContext : DbContext
    {
        

        public DbSet<Product> Product => Set<Product>();
        public DbSet<Person> Person => Set<Person>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=FinalProject;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
