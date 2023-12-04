using StartegyPattern.Models;
using StartegyPattern.Solution.PaymentStrategy;
using StatePattern.Payment;
using StatePattern.State;

namespace StatePattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var Order = new Order { Id = 1, Title = "My Order", Products = SeedData.GetProducts(), PaymentType = PaymentType.Pypal };

            Order.Shiped();

            if (Order.State.CurrentState == OrderState.Shiped)
            {
                IPaymentStrategy paymentStrategy = new PaymentTypeStartegyFactory().CreatePaymentStrategy(Order.PaymentType);

                paymentStrategy.StartPaymentMyOrder(Order.TotalPrice);
                Order.State.Delivred();

                Console.WriteLine("If You Need to return this Order Type 1 ");

                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                    Order.Returned();

                var Stat = Order.State.CurrentState;
            }
        }
    }
}