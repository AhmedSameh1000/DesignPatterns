namespace SingleTon
{
    public class ExChangeRate
    {
        public ExChangeRate(string baseCurrency, string target, decimal rate)
        {
            BaseCurrency = baseCurrency;
            this.target = target;
            Rate = rate;
        }

        public string BaseCurrency { get; set; }
        public string target { get; set; }
        public decimal Rate { get; set; }
    }
}