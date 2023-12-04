namespace SingleTon
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter base Currency : ");
                var BaseCurrency = Console.ReadLine();
                Console.Write("Enter Target Currency : ");
                var TargetCurrency = Console.ReadLine();

                Console.WriteLine("Enter Amount : ");

                var Amount = decimal.Parse(Console.ReadLine());

                var Converter = CurrencyConverter.Instance;

                Converter.Convert(BaseCurrency, TargetCurrency, Amount);

                Console.WriteLine($"{Amount} {BaseCurrency} = {Converter} {TargetCurrency}");
                Console.WriteLine("-----------------------------------------------");
                var Converter2 = CurrencyConverter.Instance.Convert(BaseCurrency, TargetCurrency, Amount);

                Console.WriteLine($"{Amount} {BaseCurrency} = {Converter2} {TargetCurrency}");
            }
        }
    }

    public class CurrencyConverter
    {
        private IEnumerable<ExChangeRate> _exchanges;
        private static Object _lock = new();

        private CurrencyConverter()
        {
            LoadExChanges();
        }

        private static CurrencyConverter _Instance;

        public static CurrencyConverter Instance
        {
            get
            {
                if (_Instance is null)
                {
                    lock (_lock)
                    {
                        if (_Instance is null)
                        {
                            _Instance = new CurrencyConverter();
                        }
                    }
                }
                return _Instance;
            }
        }

        private void LoadExChanges()
        {
            Thread.Sleep(3000);
            _exchanges = new[]
            {
                new ExChangeRate("USD","EGP",30.60m),
                new ExChangeRate("EGP","USD",0.023m),
            };
        }

        public decimal Convert(string BaseCurrency, string TargetCurrency, decimal Amount)
        {
            var Exchange = _exchanges.FirstOrDefault(c => c.BaseCurrency == BaseCurrency && c.target == TargetCurrency);

            return Exchange.Rate * Amount;
        }
    }

    //public static class ahed
    //{
    //}

    //public class a : ahed
    //{ }
}