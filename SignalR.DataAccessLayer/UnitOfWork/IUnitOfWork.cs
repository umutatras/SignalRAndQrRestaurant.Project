using SignalR.DataAccessLayer.Abstraction;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.UnitOfWork
{
    internal interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
