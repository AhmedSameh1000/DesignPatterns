using CommandPattern.Commands;
using CommandPattern.Core;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Laptop = new Product(1, "Laptop", 20_000, 10);
            var KeyBourd = new Product(2, "KeyBourd", 300, 50);
            var Mouse = new Product(3, "Mouse", 150, 70);

            while (true)
            {
                var Order = new Order();
                var Invoker = new CommandInvoker();
                while (true)
                {
                    Console.WriteLine("Select One Of The Below Commands");
                    Console.WriteLine("1 Add laptop");
                    Console.WriteLine("2 Add KeyBourd");
                    Console.WriteLine("3 Add Mouse");
                    Console.WriteLine("0 Exist");

                    var CommandId = int.Parse(Console.ReadLine());

                    if (CommandId == 1)
                    {
                        Invoker.AddCommand(new AddProductCommand(Order, Laptop, 1));
                        Invoker.AddCommand(new AddStockCommand(Laptop, -1));
                    }
                    else if (CommandId == 2)
                    {
                        Invoker.AddCommand(new AddProductCommand(Order, KeyBourd, 1));
                        Invoker.AddCommand(new AddStockCommand(KeyBourd, -1));
                    }
                    else if (CommandId == 3)
                    {
                        Invoker.AddCommand(new AddProductCommand(Order, Mouse, 1));
                        Invoker.AddCommand(new AddStockCommand(Mouse, -1));
                    }
                    else if (CommandId == 0)
                    {
                        Invoker.ExicuteCommand();
                        var TotalQuantity = Order.Lines.Sum(c => c.Quantity);
                        var TotalPrice = Order.Lines.Sum(c => c.Price);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Order {Order.Id} Created :  TotalQuantity{TotalQuantity} TotalPrice {TotalPrice}");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }
    }
}

/*

 using CommandPattern.Commands;
using CommandPattern.Core;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Laptop = new Product(1, "Laptop", 20_000, 10);
            var KeyBourd = new Product(2, "KeyBourd", 300, 50);
            var Mouse = new Product(3, "Mouse", 150, 70);

            while (true)
            {
                var Order = new Order();
                var Invoker = new CommandInvoker();
                while (true)
                {
                    Console.WriteLine("Select One Of The Below Commands");
                    Console.WriteLine("1 Add laptop");
                    Console.WriteLine("2 Add KeyBourd");
                    Console.WriteLine("3 Add Mouse");
                    Console.WriteLine("0 Exist");

                    var CommandId = int.Parse(Console.ReadLine());

                    if (CommandId == 1)
                    {
                        Invoker.AddCommand(new AddProductCommand(Order, Laptop, 1));
                        Invoker.AddCommand(new AddStockCommand(Laptop, -1));
                    }
                    else if (CommandId == 2)
                    {
                        Invoker.AddCommand(new AddProductCommand(Order, KeyBourd, 1));
                        Invoker.AddCommand(new AddStockCommand(KeyBourd, -1));
                    }
                    else if (CommandId == 3)
                    {
                        Invoker.AddCommand(new AddProductCommand(Order, Mouse, 1));
                        Invoker.AddCommand(new AddStockCommand(Mouse, -1));
                    }
                    else if (CommandId == 0)
                    {
                        Invoker.ExicuteCommand();
                        var TotalQuantity = Order.Lines.Sum(c => c.Quantity);
                        var TotalPrice = Order.Lines.Sum(c => c.Price);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Order {Order.Id} Created :  TotalQuantity{TotalQuantity} TotalPrice {TotalPrice}");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }
    }
}

 */

/*

 using CommandPattern.Core;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Laptop = new Product(1, "Laptop", 20_000, 10);
            var KeyBourd = new Product(2, "KeyBourd", 300, 50);
            var Mouse = new Product(3, "Mouse", 150, 70);

            while (true)
            {
                var Order = new Order();
                while (true)
                {
                    Console.WriteLine("Select One Of The Below Commands");
                    Console.WriteLine("1 Add laptop");
                    Console.WriteLine("2 Add KeyBourd");
                    Console.WriteLine("3 Add Mouse");
                    Console.WriteLine("0 Exist");

                    var CommandId = int.Parse(Console.ReadLine());
                    Product SelectedProduct = null;

                    if (CommandId == 1)
                    {
                        SelectedProduct = Laptop;
                    }
                    else if (CommandId == 2)
                    {
                        SelectedProduct = KeyBourd;
                    }
                    else if (CommandId == 3)
                    {
                        SelectedProduct = Mouse;
                    }
                    else if (CommandId == 0)
                    {
                        var TotalQuantity = Order.Lines.Sum(c => c.Quantity);
                        var TotalPrice = Order.Lines.Sum(c => c.Price);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Order {Order.Id} Created :  TotalQuantity{TotalQuantity} TotalPrice {TotalPrice}");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    Order.AddProduct(SelectedProduct, 1);
                    SelectedProduct.AddStock(-1);
                }
            }
        }
    }
}
 */