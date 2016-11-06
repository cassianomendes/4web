using FourWeb.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FourWeb.Business.Report.Data.Contexts
{
    public class ReportContext : DbContext
    {
        private readonly string _connectionString;

        public ReportContext(IConfigurationRoot configuration)
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
            base.OnModelCreating(modelBuilder);
        }
    }
}
