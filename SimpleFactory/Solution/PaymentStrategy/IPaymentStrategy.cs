namespace StartegyPattern.Solution.PaymentStrategy
{
    public interface IPaymentStrategy
    {
        void StartPaymentMyOrder(decimal TotalPrice);
    }
}