using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using CURSO_CSHARP_NELIO_ALVES.Entities;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            StringBuilder sb = new StringBuilder();

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            employees.ForEach((employee) =>
            {
                sb.Clear();
                sb.Append("Name: ");
                sb.Append(employee.Name.PadLeft(5));
                sb.Append(" - $");
                sb.AppendLine(employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(sb.ToString());
            });
        }
    }
}