namespace q5
{

    class porduct
    {

        public int Id { get; set; }
        public string Name { get; set ;}
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }



    internal class Program
    {
        static void Main(string[] args)
        {

            var products = new List<porduct>
            {
                new porduct { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200.00m, Stock = 10 },
                new porduct { Id = 2, Name = "Smartphone", Category = "Electronics", Price = 800.00m, Stock = 20 },
                new porduct { Id = 3, Name = "Headphones", Category = "Electronics", Price = 150.00m, Stock = 15 },
                new porduct { Id = 4, Name = "Shoes", Category = "Fashion", Price = 100.00m, Stock = 30 },
                new porduct { Id = 5, Name = "T-shirt", Category = "Fashion", Price = 25.00m, Stock = 50 }
            };


            var expensiveProductsMostThree = products.Where(p => p.Stock > 0)
                                                     .OrderByDescending(p => p.Price)
                                                     .Take(3)
                                                     .ToList();

            foreach (var product in expensiveProductsMostThree)
            {
                Console.WriteLine($" Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            var categoryGroups = products.GroupBy(p => p.Category)
                                         .Select(g => new
            { 


                Category = g.Key,
                Count = g.Count(),
                AveragePrice = g.Average(p => p.Price),
                MostExpensive = g.OrderByDescending(p => p.Price).FirstOrDefault()

            });

            foreach (var group in categoryGroups)
            {
                Console.WriteLine($"Category: {group.Category}, Number of products: {group.Count}, Average Price: {group.AveragePrice}, Most Expensive Product: {group.MostExpensive.Name} ({group.MostExpensive.Price})");








            }




        }       
    }
}
