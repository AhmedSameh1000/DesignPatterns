namespace StatePattern.State
{
    public interface IOrderState
    {
        OrderState CurrentState { get; }

        void Confirmed();

        void Canceld();

        void Shiped();

        void Delivred();

        void Returned();
    }
}