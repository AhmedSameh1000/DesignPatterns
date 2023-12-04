namespace StartegyPattern.Solution.PaymentStrategy
{
    public class PaymentStrategyWithPaypal : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            Console.WriteLine($"Payment With Paypal with Total Parice is {TotalPrice}");
        }
    }

    public class PaymentStrategyWithCreated : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            Console.WriteLine($"Payment With Created with Total Parice is {TotalPrice}");
        }
    }

    public class PaymentStrategyWithDebit : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            Console.WriteLine($"Payment With Debit with Total Parice is {TotalPrice}");
        }
    }

    public class PaymentStrategyWithVisa : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            Console.WriteLine($"Payment With Visa with Total Parice is {TotalPrice}");
        }
    }

    public class PaymentStrategyWithFawry : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            Console.WriteLine($"Payment With Fawry with Total Parice is {TotalPrice}");
        }
    }

    public class NonePaymentStrategy : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            return;
        }
    }
}