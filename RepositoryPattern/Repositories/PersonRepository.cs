using RepositoryPattern.Interfaces;
using RepositoryPattern.Models;
using System.Data.Entity;
using System.Linq;

namespace RepositoryPattern.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private PlutoContext PlutoContext => Context as PlutoContext;
        public PersonRepository(DbContext context) : base(context) { }

        public Person GetPersonWithOrders(int id)
        {
            return PlutoContext.People.Include(o => o.Orders).Include("Orders.Product").SingleOrDefault(a => a.Id == id);
        }
    }
}
