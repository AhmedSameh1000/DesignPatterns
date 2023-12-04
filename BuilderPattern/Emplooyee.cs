namespace BuilderPattern
{
    public class Emplooyee
    {
        public Emplooyee(int id = 1, string name = "NoName", int tall = 150, double weight = 80)
        {
            Id = id;
            Name = name;
            this.tall = tall;
            Weight = weight;
        }

        public int Id { get; }
        public string Name { get; }
        public int tall { get; }
        public double Weight { get; }

        public override string ToString()
        {
            return $"{Id} || {Name} || {tall} || {Weight}";
        }
    }
}