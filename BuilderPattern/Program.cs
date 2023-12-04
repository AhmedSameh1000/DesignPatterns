namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Builder = new EmployeeBuilder();
            Builder.WithId(1).WithName("Ahmed").WithTall(170).WithWeight(120);

            var Employee = Builder.Build();
            Console.WriteLine(Employee);
        }
    }
}