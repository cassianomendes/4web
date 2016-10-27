using FourWeb.Abstraction.Domain.Entities;

namespace FourWeb.Abstraction.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        void Save();
    }
}
