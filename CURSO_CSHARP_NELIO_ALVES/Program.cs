using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a = 5.1;
            float b = (float) a;

            Console.WriteLine(b);

            double p = 5.3;
            int q = (int) p;

            Console.WriteLine(q);

            int v1 = 5;
            int v2 = 2;
            double resultado = (double) v1 / v2;
            Console.WriteLine(resultado);
        }
    }
}