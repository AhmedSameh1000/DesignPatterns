using StartegyPattern.Models;

namespace StartegyPattern
{
    public class SeedData
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1,Name="Bag",Price=50,quantity=3},
                new Product{Id=2,Name="kap",Price=10,quantity=2},
            };
        }
    }
}