using StartegyPattern.Models;

namespace StatePattern.State.AllState
{
    public class ReturnedState : IOrderState
    {
        private readonly Order _order;
        public OrderState CurrentState => OrderState.Returned;

        public ReturnedState(Order order)
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
            throw new NotImplementedException();
        }

        public void Shiped()
        {
            throw new NotImplementedException();
        }
    }
}