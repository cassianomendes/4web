using FourWeb.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FourWeb.Business.Shop.Data.Contexts
{
    public class ShopContext : DbContext
    {
        private readonly string _connectionString;

        public ShopContext(IConfigurationRoot configuration)
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

            //modelBuilder.Entity<Category>(b =>
            //{
            //    b.Property<int>("Id").ValueGeneratedOnAdd();
            //    b.HasKey("Id");
            //    b.ToTable("Category");
            //});

            base.OnModelCreating(modelBuilder);
        }
    }
}
