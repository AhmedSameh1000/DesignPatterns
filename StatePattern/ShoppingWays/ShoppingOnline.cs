using StartegyPattern.Models;
using StartegyPattern.Solution.PaymentStrategy;
using StatePattern.Payment;

namespace TemplateMethod.ShoopingTypes
{
    public class ShoppingOnline : ShoppingWays
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public ShoppingOnline(PaymentType paymentType)
        {
            _paymentStrategy = new PaymentTypeStartegyFactory().CreatePaymentStrategy(paymentType); ;
        }

        public override void StartProcessPayment(decimal Price)
        {
            Console.WriteLine($"{nameof(StartProcessPayment)} in {GetType().Name}");
            _paymentStrategy.StartPaymentMyOrder(Price);
        }
    }

    public class ShoppingOnStore : ShoppingWays
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public ShoppingOnStore(PaymentType paymentType)
        {
            _paymentStrategy = new PaymentTypeStartegyFactory().CreatePaymentStrategy(paymentType); ;
        }

        public override void StartProcessPayment(decimal Price)
        {
            Console.WriteLine($"{nameof(StartProcessPayment)} in {GetType().Name}");
            _paymentStrategy.StartPaymentMyOrder(Price);
        }
    }
}