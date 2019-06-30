using System.Collections.Generic;
using System.Linq;
using CURSO_CSHARP_NELIO_ALVES.Entities.Enums;

namespace CURSO_CSHARP_NELIO_ALVES.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public List<HourContract> HourContracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            HourContracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            HourContracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double value = 0.0;
            HourContracts.ForEach((contract) =>
            {
                if (month == contract.Date.Month && year == contract.Date.Year)
                    value += contract.TotalValue();
            });
            return value;
        }
    }
}