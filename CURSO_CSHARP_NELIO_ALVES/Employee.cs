using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    public class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] values = csvEmployee.Split(',');
            Name = values[0];
            Salary = double.Parse(values[1], CultureInfo.InvariantCulture);
        }
        
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Employee) obj).Name);
        }
    }
}