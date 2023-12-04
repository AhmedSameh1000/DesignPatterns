using StartegyPattern.Models;
using StartegyPattern.Solution.PaymentStrategy;

namespace SimpleFactory
{
    internal class PaymentTypeStartegyFactory
    {
        public IPaymentStrategy CreatePaymentStrategy(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.Pypal:
                    return new PaymentStrategyWithPaypal();

                case PaymentType.Debit:
                    return new PaymentStrategyWithDebit();

                case PaymentType.Creadit:
                    return new PaymentStrategyWithCreated();

                case PaymentType.Visa:
                    return new PaymentStrategyWithVisa();

                case PaymentType.Fawry:
                    return new PaymentStrategyWithFawry();

                case PaymentType.Cash:
                    return new PaymentStrategyCash();

                default:
                    return new NonePaymentStrategy();
            }
        }
    }
}