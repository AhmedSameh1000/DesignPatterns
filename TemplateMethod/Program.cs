using StartegyPattern;
using StartegyPattern.Models;
using TemplateMethod.ShoopingTypes;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Product = SeedData.GetProducts();
            var Order = new Order() { Id = 1, PaymentType = PaymentType.Visa, Products = Product, Title = "Good Order" };

            //ShoppingWays shoppingWays = null!;

            if (Order.PaymentType == PaymentType.Cash)
            {
                //shoppingWays = new ShoppingOnStore(Order.PaymentType);
                ShoppingOnStore shoppingOnStore = new ShoppingOnStore(Order.PaymentType);
                shoppingOnStore.StartProcessPayment(Order.TotalPrice);
            }
            else
            {
                //shoppingWays = new ShoppingOnline(Order.PaymentType);
                ShoppingOnline shoppingOnline = new ShoppingOnline(Order.PaymentType);
                shoppingOnline.StartProcessPayment(Order.TotalPrice);
            }

            //shoppingWays.StartProcessPayment(Order.TotalPrice);
        }
    }
}