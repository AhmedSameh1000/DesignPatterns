using CommandPattern.Core;

namespace CommandPattern.Commands
{
    public class AddProductCommand : ICommand
    {
        private readonly Order _order;
        private readonly Product _product;
        private readonly double _quantity;

        public AddProductCommand(Order order, Product product, double Quantity)
        {
            _order = order;
            _product = product;
            _quantity = Quantity;
        }

        public void Execute()
        {
            _order.AddProduct(_product, _quantity);
        }
    }
}