using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            int n4 = 10 / 8;
            Console.WriteLine(n4);

            double n5 = 10.0 / 8.0;
            Console.WriteLine(n5);
            Console.WriteLine("-----------------------------------");

            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double delta = Math.Pow(b, 2.0) - (4.0 * a * c);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"X1: {x1:F2} - X2: {x2:F2}");
        }
    }
}