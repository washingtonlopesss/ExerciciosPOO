using System;
using System.Globalization;

namespace Lista
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public void increaseSalary(double percentage)
        {
            Salary += (Salary / 100) * percentage;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
