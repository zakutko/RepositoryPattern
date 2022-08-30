using RepositoryPattern.Models;
using System.Collections.Generic;

namespace RepositoryPattern.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> MostExpensiveProduct(int count);
    }
}
