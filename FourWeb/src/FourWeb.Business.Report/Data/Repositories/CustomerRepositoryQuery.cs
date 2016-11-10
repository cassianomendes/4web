using FourWeb.Abstraction.Data.Repositories;
using FourWeb.Business.Report.Data.Contexts;
using FourWeb.Business.Report.Domain.Entities;
using FourWeb.Business.Report.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FourWeb.Business.Report.Data.Repositories
{
    public class CustomerRepositoryQuery : RepositoryQueryBase<Customer>, ICustomerRepositoryQuery
    {
        public CustomerRepositoryQuery(ReportContext context)
            : base(context)
        {
        }

        public Customer GetByEmail(string email)
        {
            return Entity.AsNoTracking().FirstOrDefault(x => x.Email == email);
        }
    }
}
