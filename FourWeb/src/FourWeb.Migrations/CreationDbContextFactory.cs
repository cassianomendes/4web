using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Migrations
{
    public class CreationDbContextFactory : IDbContextFactory<CreationDbContext>
    {
        public CreationDbContext Create(DbContextFactoryOptions options)
        {
            //var builder = new DbContextOptionsBuilder<CreationDbContext>();
            //builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=fourweb;Trusted_Connection=True;MultipleActiveResultSets=true");            
            return new CreationDbContext();
        }        
    }
}
