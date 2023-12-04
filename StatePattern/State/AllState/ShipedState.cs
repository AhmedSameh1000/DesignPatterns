using StartegyPattern.Models;

namespace StatePattern.State.AllState
{
    public class ShipedState : IOrderState
    {
        private readonly Order _order;
        public OrderState CurrentState => OrderState.Shiped;

        public ShipedState(Order order)
        {
            _order = order;
        }

        public void Canceld()
        {
            throw new NotImplementedException();
        }

        public void Confirmed()
        {
            throw new NotImplementedException();
        }

        public void Delivred()
        {
            _order.State = new DelivredState(_order);

            //other logic
        }

        public void Returned()
        {
            throw new NotImplementedException();
        }

        public void Shiped()
        {
            throw new NotImplementedException();
        }
    }
}