using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourWeb.Migrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var createContext = new CreationDbContextFactory();

            createContext.Create(new DbContextFactoryOptions());
        }
    }
}
