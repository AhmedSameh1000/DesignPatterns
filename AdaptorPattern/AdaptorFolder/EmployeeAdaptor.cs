using AdaptorPattern.Models;

namespace AdaptorPattern.AdaptorFolder
{
    internal class EmployeeAdaptor
    {
        private readonly Employee _employee;

        public EmployeeAdaptor(Employee employee)
        {
            _employee = employee;
        }

        public int Id => _employee.Id;
        public string FullName => _employee.FirstName + " " + _employee.LastName;
        public decimal Salary => CalcSalary(_employee);

        private decimal CalcSalary(Employee employee)
        {
            decimal BaseSalary = 1000;

            if (employee.isPerfectEmployee)
                BaseSalary += 100;

            if (employee.Age > 45)
                BaseSalary += 100;

            BaseSalary -= employee.Tax;

            return BaseSalary;
        }
    }
}