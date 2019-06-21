using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz);
                
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo!");
        }
    }
}