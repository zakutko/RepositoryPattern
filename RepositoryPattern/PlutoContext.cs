using RepositoryPattern.Models;
using System.Data.Entity;

namespace RepositoryPattern
{
    public class PlutoContext : DbContext
    {
        public PlutoContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}
