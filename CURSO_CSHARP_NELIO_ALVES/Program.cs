using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine();
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            Console.WriteLine();
            
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            
            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            Console.WriteLine();
            Console.WriteLine();
            
            double? a = null;
            double? b = 10.0;

            double c = a ?? 5.0;
            double d = b ?? 5.0;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}