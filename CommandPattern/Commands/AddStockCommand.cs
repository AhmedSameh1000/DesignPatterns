using CommandPattern.Core;

namespace CommandPattern.Commands
{
    public class AddStockCommand : ICommand
    {
        private readonly Product _product;
        private readonly double _quantity;

        public AddStockCommand(Product product, double Quantity)
        {
            _product = product;
            _quantity = Quantity;
        }

        public void Execute()
        {
            _product.AddStock(_quantity);
        }
    }
}