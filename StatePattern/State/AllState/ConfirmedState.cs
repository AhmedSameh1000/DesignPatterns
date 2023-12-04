using StartegyPattern.Models;

namespace StatePattern.State.AllState
{
    public class ConfirmedState : IOrderState
    {
        private readonly Order _order;
        public OrderState CurrentState => OrderState.Confirmed;

        public ConfirmedState(Order order)
        {
            _order = order;
        }

        public void Canceld()
        {
            _order.State = new CanceldState(_order);
            //CurrentState = OrderState.Canceld;
            //other logic
        }

        public void Confirmed()
        {
            throw new NotImplementedException();
        }

        public void Delivred()
        {
            throw new InvalidOperationException("Can not Move To this State");
        }

        public void Returned()
        {
            throw new NotImplementedException();
        }

        public void Shiped()
        {
            _order.State = new ShipedState(_order);

            //other logic
        }
    }
}