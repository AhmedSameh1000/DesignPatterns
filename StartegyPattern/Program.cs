using StartegyPattern.Models;
using StartegyPattern.Problem.Services;

namespace StartegyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region BadWay

            var Orders = new Order { Id = 1, Products = SeedData.GetProducts(), Title = "Good pershice", PaymentType = PaymentType.Pypal };

            var PaymentService = new paimentServices();

            if (Orders.PaymentType == PaymentType.Pypal)
                PaymentService.PaymentWithPaypal(Orders.TotalPrice);
            else if (Orders.PaymentType == PaymentType.Visa)
                PaymentService.PaymentWithVisa(Orders.TotalPrice);
            else if (Orders.PaymentType == PaymentType.Creadit)
                PaymentService.PaymentWithCreadit(Orders.TotalPrice);
            else if (Orders.PaymentType == PaymentType.Debit)
                PaymentService.PaymentWithDebit(Orders.TotalPrice);
            else if (Orders.PaymentType == PaymentType.Fawry)
                PaymentService.PaymentWithFawry(Orders.TotalPrice);

            #endregion BadWay

            #region GoodWay

            //var Orders = new Order { Id = 1, Title = "My Order", Products = SeedData.GetProducts(), PaymentType = PaymentType.Creadit };
            //IPaymentStrategy paymentStrategy = null;

            //if (Orders.PaymentType == PaymentType.Pypal)
            //    paymentStrategy = new PaymentStrategyWithPaypal();
            //else if (Orders.PaymentType == PaymentType.Debit)
            //    paymentStrategy = new PaymentStrategyWithDebit();
            //else if (Orders.PaymentType == PaymentType.Creadit)
            //    paymentStrategy = new PaymentStrategyWithCreated();
            //else if (Orders.PaymentType == PaymentType.Visa)
            //    paymentStrategy = new PaymentStrategyWithVisa();
            //else if (Orders.PaymentType == PaymentType.Fawry)
            //    paymentStrategy = new PaymentStrategyWithFawry();

            //paymentStrategy.StartPaymentMyOrder(Orders.TotalPrice);

            #endregion GoodWay
        }
    }
}