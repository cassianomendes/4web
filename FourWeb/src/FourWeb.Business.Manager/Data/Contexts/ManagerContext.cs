using FourWeb.Business.Manager.Domain.Entities;
using FourWeb.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Manager.Data.Contexts
{
    public class ManagerContext : DbContext
    {
        private readonly string _connectionString;
        public ManagerContext(IConfigurationRoot configuration)
        {
            _connectionString = configuration[DatabaseConstants.ConnectionStringKey];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>(b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd();
                b.HasKey("Id");                
                b.ToTable("Category");                
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
