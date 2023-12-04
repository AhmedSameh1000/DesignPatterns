namespace StartegyPattern.Problem.Services
{
    public class paimentServices
    {
        public void PaymentWithPaypal(decimal price)
        {
            Console.WriteLine($"Paypal Pay Done {price}");
        }

        public void PaymentWithVisa(decimal price)
        {
            Console.WriteLine($"Visa Pay Done {price}");
        }

        public void PaymentWithCreadit(decimal price)
        {
            Console.WriteLine($"Cridet Pay Done {price}");
        }

        public void PaymentWithDebit(decimal price)
        {
            Console.WriteLine($"Debit Pay Done {price}");
        }

        public void PaymentWithFawry(decimal price)
        {
            Console.WriteLine($"Debit Pay Done {price}");
        }
    }
}