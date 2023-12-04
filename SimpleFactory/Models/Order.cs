namespace StartegyPattern.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public decimal TotalPrice => Products.Select(c => c.Price * c.quantity).Sum();

        public PaymentType PaymentType { get; set; }
    }
}