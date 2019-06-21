using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            
            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}