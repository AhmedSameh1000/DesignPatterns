namespace CommandPattern.Core
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public double StockBalance { get; private set; }

        public Product(int id, string name, decimal price, double stockBalance)
        {
            Id = id;
            Name = name;
            Price = price;
            StockBalance = stockBalance;
        }

        public void AddStock(double QuantityBalance)
        {
            StockBalance += QuantityBalance;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Name} Stock Changed To {StockBalance}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}