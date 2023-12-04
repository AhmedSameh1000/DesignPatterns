namespace DecoratorPattern.FirstExmple
{
    public class FirstOrder : IOrder
    {
        public void Process(int num)
        {
            if (num == 1)
            {
                throw new InvalidOperationException("Not allowed to be 1");
            }
            Console.WriteLine($"{GetType().Name} with number {num}");
        }
    }

    public class SecondOrder : IOrder
    {
        private readonly IOrder _order;

        public SecondOrder(IOrder order)
        {
            _order = order;
        }

        public void Process(int num)
        {
            _order.Process(num);
            Console.WriteLine($"{GetType().Name} with number {num}");
        }
    }

    public class ThirdOrder : IOrder
    {
        private readonly IOrder _order;

        public ThirdOrder(IOrder order)
        {
            _order = order;
        }

        public void Process(int num)
        {
            _order.Process(num);
            Console.WriteLine($"{GetType().Name} with number {num}");
        }
    }

    public class ForthOrder : IOrder
    {
        private readonly IOrder _order;

        public ForthOrder(IOrder order)
        {
            _order = order;
        }

        public void Process(int num)
        {
            try
            {
                _order.Process(num);
                Console.WriteLine($"{GetType().Name} with number {num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}