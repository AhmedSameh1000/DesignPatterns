namespace CommandPattern.Core
{
    public class Order
    {
        public int Id { get; } = Random.Shared.Next(1, 1000);
        private List<OrderLine> _lines = new();
        public IEnumerable<OrderLine> Lines => _lines.AsReadOnly();

        public void AddProduct(Product product, double quantity)
        {
            _lines.Add(new OrderLine { ProductId = product.Id, Price = product.Price, Quantity = quantity });
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Product {product.Name} Added ,Order new Contains {_lines.Count()} Products");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}