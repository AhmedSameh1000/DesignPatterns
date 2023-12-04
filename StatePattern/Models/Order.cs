using StatePattern.State;
using StatePattern.State.AllState;

namespace StartegyPattern.Models
{
    public class Order
    {
        public Order()
        {
            State = new ConfirmedState(this);
        }

        public IOrderState State;

        public int Id { get; set; }
        public string Title { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public decimal TotalPrice => Products.Select(c => c.Price * c.quantity).Sum();

        public PaymentType PaymentType { get; set; }

        public void Canceld()
        {
            State.Canceld();
        }

        public void Confirmed()
        {
            State.Confirmed();
        }

        public void Delivred()
        {
            State.Delivred();
        }

        public void Returned()
        {
            State.Returned();
        }

        public void Shiped()
        {
            State.Shiped();
        }
    }
}