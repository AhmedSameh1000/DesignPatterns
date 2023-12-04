namespace AdaptorPattern.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }

        public decimal Tax { get; set; }
        public bool isPerfectEmployee { get; set; }
        public bool Gender { get; set; }

        public int Age { get; set; }
    }
}