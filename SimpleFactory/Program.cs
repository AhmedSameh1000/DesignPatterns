using SimpleFactory;
using StartegyPattern.Models;
using StartegyPattern.Solution.PaymentStrategy;

namespace StartegyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region GoodWay

            var Orders = new Order { Id = 1, Title = "My Order", Products = SeedData.GetProducts(), PaymentType = PaymentType.None };

            IPaymentStrategy paymentStrategy = new PaymentTypeStartegyFactory().CreatePaymentStrategy(Orders);

            paymentStrategy.StartPaymentMyOrder(Orders.TotalPrice);

            #endregion GoodWay
        }
    }
}