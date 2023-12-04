namespace StartegyPattern.Solution.PaymentStrategy
{
    public class PaymentStrategyWithPaypal : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            decimal Amount = 0.05m;
            var TotalAmount = TotalPrice + (TotalPrice * Amount);
            Console.WriteLine($"Payment With Paypal with Total Parice is {TotalAmount}");
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
            if (TotalPrice < 10_000)
            {
                decimal Amount = 0.02m;
                TotalPrice = TotalPrice + (TotalPrice * Amount);
            }
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

    public class PaymentStrategyCash : IPaymentStrategy
    {
        public void StartPaymentMyOrder(decimal TotalPrice)
        {
            Console.WriteLine($"Payment Cash Total Parice is {TotalPrice}");
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