using StartegyPattern.Models;

namespace StatePattern.State.AllState
{
    public class DelivredState : IOrderState
    {
        private readonly Order _order;
        public OrderState CurrentState => OrderState.Delivred;

        public DelivredState(Order order)
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
            throw new NotImplementedException();
        }

        public void Returned()
        {
            _order.State = new ReturnedState(_order);

            //other logic
        }

        public void Shiped()
        {
            throw new NotImplementedException();
        }
    }
}