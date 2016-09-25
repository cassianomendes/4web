using FourWeb.Abstraction.Domain.Entities;
using FourWeb.Migrations.DatabaseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Migrations
{
    public class CreationDbContext : DbContext
    {
        private readonly string _connectionString;
        public CreationDbContext()
            : base()
        {
            _connectionString = "Server=(localdb)\\mssqllocaldb;Database=fourweb;Trusted_Connection=True;MultipleActiveResultSets=true";
            Database.Migrate();            
        }       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Category>();            
            modelBuilder.Entity<TechnicalDetail>();            
            modelBuilder.Entity<FeaturedShowCase>();
            modelBuilder.Entity<PaymentMethod>();
            modelBuilder.Entity<SpecialOffer>();
            modelBuilder.Entity<SpecialOfferProduct>();
            modelBuilder.Entity<Address>();
            modelBuilder.Entity<BankSlip>();
            modelBuilder.Entity<CreditCard>();
            modelBuilder.Entity<User>().HasDiscriminator<bool>("IsCustomer").HasValue(false).HasValue<Customer>(true);
            modelBuilder.Entity<Customer>().HasBaseType<User>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderItem>();
            modelBuilder.Entity<Payment>();
            modelBuilder.Entity<Shipping>();
            modelBuilder.Entity<ShoppingCart>();
            modelBuilder.Entity<ShoppingCartItem>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
