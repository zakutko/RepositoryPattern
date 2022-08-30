using System.Collections.Generic;

namespace RepositoryPattern.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public int? OrderId { get; set; }
        public IList<Order> Orders { get; set; }

        public Person()
        {
            Orders = new List<Order>();
        }
    }
}
