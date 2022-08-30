using System;
using System.Linq;

namespace RepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                var person = unitOfWork.People.GetPersonWithOrders(1);

                var orderForm = unitOfWork.Orders.GetOrdersFromDate(new DateTime(2022, 08, 30, 12, 39, 0));

                var order = unitOfWork.Orders.GetOrderById(1);

                var whoMadeOrder = unitOfWork.People.GetPersonWithOrders(order.PersonId);

                var topProducts = unitOfWork.Products.MostExpensiveProduct(10);

                Console.WriteLine($"Persone with id 1: {person.FirstName} {person.LastName}");
                Console.WriteLine("");
                Console.WriteLine($"Date order with id 1: : {order.DateTime}");
                Console.WriteLine($"And this order did {whoMadeOrder.FirstName} {whoMadeOrder.LastName}");
                Console.WriteLine("");
                Console.WriteLine("Top 10 buyer products:");
                topProducts.ToList().ForEach(w => { Console.WriteLine($" - {w.Name}"); });

                Console.ReadLine();
            }
        }
    }
}
