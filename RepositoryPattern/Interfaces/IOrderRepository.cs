using RepositoryPattern.Models;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        [Obsolete("GetTopPrice is deprecated")]
        IEnumerable<Order> GetTopPrice(int count);
        Order GetOrderById(int id);
        IList<Order> GetOrdersFromDate(DateTime dateTime);
    }
}
