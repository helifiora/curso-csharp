using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qtd Produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product()
                {
                    Name = name,
                    Price = price
                };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"AVERAGE PRICE: {avg:F2}");
        }
    }
}