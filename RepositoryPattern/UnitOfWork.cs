using RepositoryPattern.Interfaces;
using RepositoryPattern.Repositories;

namespace RepositoryPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            People = new PersonRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IPersonRepository People { get; }
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
