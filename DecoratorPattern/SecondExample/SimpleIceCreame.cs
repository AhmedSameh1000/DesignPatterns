namespace DecoratorPattern.SecondExample
{
    internal class SimpleIceCreame : IIceCream
    {
        public decimal GetIceCreame()
        {
            Console.WriteLine(GetType().Name);
            return 3.50m;
        }
    }

    internal class SimpleIceCreameWithPanana : IIceCream
    {
        private readonly IIceCream _iceCream;

        private decimal price => 1m;

        public SimpleIceCreameWithPanana(IIceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public decimal GetIceCreame()
        {
            Console.WriteLine(GetType().Name);
            return price + _iceCream.GetIceCreame();
        }
    }

    internal class SimpleIceCreameWithApple : IIceCream
    {
        private readonly IIceCream _iceCream;

        private decimal price => 2m;

        public SimpleIceCreameWithApple(IIceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public decimal GetIceCreame()
        {
            Console.WriteLine(GetType().Name);
            return price + _iceCream.GetIceCreame();
        }
    }
}