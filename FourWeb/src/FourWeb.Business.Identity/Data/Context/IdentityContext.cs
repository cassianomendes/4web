using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Business.Identity.Data.Context
{
    public class IdentityContext : DbContext
    {
        private readonly string _connectionString;
        public IdentityContext(IConfigurationRoot configuration)
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
            modelBuilder.Entity<User>().HasDiscriminator<bool>("IsCustomer").HasValue(false);   

            base.OnModelCreating(modelBuilder);
        }
    }
}
