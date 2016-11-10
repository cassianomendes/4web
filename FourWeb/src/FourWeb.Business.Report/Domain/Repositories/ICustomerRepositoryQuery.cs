using FourWeb.Abstraction.Domain.Interfaces.Repositories;
using FourWeb.Business.Report.Domain.Entities;

namespace FourWeb.Business.Report.Domain.Repositories
{
    public interface ICustomerRepositoryQuery : IRepositoryQueryBase<Customer>
    {
        Customer GetByEmail(string email);
    }
}
