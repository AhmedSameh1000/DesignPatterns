namespace BuilderPattern
{
    public class EmployeeBuilder
    {
        private int Id;
        private string Name;
        private int tall;
        private double Weight;

        public EmployeeBuilder WithId(int id)
        {
            Id = id;
            return this;
        }

        public EmployeeBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public EmployeeBuilder WithTall(int tall)
        {
            this.tall = tall;

            return this;
        }

        public EmployeeBuilder WithWeight(double weight)
        {
            this.Weight = weight;
            return this;
        }

        public Emplooyee Build()
        {
            return new Emplooyee(Id, Name, tall, Weight);
        }
    }
}