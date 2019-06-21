using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static int Maior(int n1, int n2, int n3)
        {
            if (n1 >= n2 && n1 >= n3)
            {
                return n1;
            }
            else if (n2 >= n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite Três Números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine($"Maior: {resultado}");
        }
    }
}