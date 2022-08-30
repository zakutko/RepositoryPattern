using RepositoryPattern.Interfaces;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryPattern.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private PlutoContext PlutoContext => Context as PlutoContext;
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Order> GetTopPrice(int count)
        {
            return PlutoContext.Orders
                .Include(q => q.Product)
                .OrderByDescending(q => q.Product.Price)
                .Take(count)
                .ToList();
        }

        public Order GetOrderById(int id)
        {
            return PlutoContext.Orders.SingleOrDefault(q => q.Id == id);
        }

        public IList<Order> GetOrdersFromDate(DateTime dateTime)
        {
            return PlutoContext.Orders.Where(x => x.DateTime >= dateTime).ToList();
        }
    }
}
