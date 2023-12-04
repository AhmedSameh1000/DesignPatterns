using DecoratorPattern.ThirdExample;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IOrder order = new FirstOrder();
            //order = new SecondOrder(order);
            //order = new ThirdOrder(order);
            //order = new ForthOrder(order);

            //order.Process(1);

            //IIceCream iceCream = new SimpleIceCreame();
            //iceCream = new SimpleIceCreameWithApple(iceCream);
            //iceCream = new SimpleIceCreameWithPanana(iceCream);
            //Console.WriteLine(iceCream.GetIceCreame());

            IceCreame Order = new BasicIceCreame();
            Order = new Sprikels(Order);
            Order = new Chocolate(Order);
            Order = new Froute(Order);

            Console.WriteLine(Order);
        }
    }
}