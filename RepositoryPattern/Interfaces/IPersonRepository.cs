using RepositoryPattern.Models;

namespace RepositoryPattern.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetPersonWithOrders(int id);
    }
}
