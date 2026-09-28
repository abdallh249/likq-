using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leve_4
{
    class Order
    {


        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            
          var orders = new List<Order>
          {
            new() { Id = 1, CustomerId = 101, Date = new DateTime(2026, 9, 1),  Total = 120.50m },
            new() { Id = 2, CustomerId = 102, Date = new DateTime(2026, 9, 2),  Total = 75.00m },
            new() { Id = 3, CustomerId = 101, Date = new DateTime(2026, 9, 3),  Total = 250.00m },
            new() { Id = 4, CustomerId = 103, Date = new DateTime(2026, 9, 4),  Total = 40.00m },
            new() { Id = 5, CustomerId = 102, Date = new DateTime(2026, 9, 5),  Total = 310.75m },
            new() { Id = 6, CustomerId = 104, Date = new DateTime(2026, 9, 6),  Total = 99.99m },
            new() { Id = 7, CustomerId = 101, Date = new DateTime(2026, 9, 7),  Total = 180.00m },
            new() { Id = 8, CustomerId = 103, Date = new DateTime(2026, 9, 8),  Total = 500.00m },
            new() { Id = 9, CustomerId = 104, Date = new DateTime(2026, 9, 9),  Total = 60.00m },
            new() { Id = 10, CustomerId = 102, Date = new DateTime(2026, 9, 10), Total = 145.25m }
          }; 

 

            var topThreeCustomers = orders.GroupBy(o => o.CustomerId)
                                          .OrderByDescending(group => group
                                          .Sum(x => x.Total))
                                          .Take(3);

            foreach (var customer in topThreeCustomers)
            {
                Console.WriteLine($"CustomerId: {customer.Key}, Total Amount: {customer.Sum(x => x.Total)}");
            }
           
            Console.WriteLine("****************************************************************************************");

            var dateyrey = orders.Where(o =>  o.Date.Year == DateTime.Now.Year).GroupBy(o => o.CustomerId);
            
               
            foreach (var item in dateyrey)
            {
                Console.WriteLine($"CustomerId: {item.Key}, Number of Orders:{ item.Count()} ");

            }


        }
    }
}
