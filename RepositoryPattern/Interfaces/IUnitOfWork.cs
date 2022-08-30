using System;

namespace RepositoryPattern.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository People { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        int Complete();
    }
}
