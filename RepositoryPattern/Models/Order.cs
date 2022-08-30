using System;

namespace RepositoryPattern.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime DateTime { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
