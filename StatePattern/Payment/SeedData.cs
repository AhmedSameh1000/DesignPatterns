using StartegyPattern.Models;

namespace StatePattern.Payment
{
    public class SeedData
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1,Name="Bag",Price=2000,quantity=1},
                new Product{Id=2,Name="kap",Price=3000,quantity=2},
            };
        }
    }
}