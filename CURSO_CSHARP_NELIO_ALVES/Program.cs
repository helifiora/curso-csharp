using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            
            bool c1 = a < 10;
            Console.WriteLine(c1);
            
            bool c2 = a < 20;
            Console.WriteLine(c2);

            bool c3 = a > 10;
            Console.WriteLine(c3);

            bool c4 = a > 5;
            Console.WriteLine(c4);
            Console.WriteLine("-----------------------------------");
            
            bool c5 = a <= 10;
            Console.WriteLine(c5);
            bool c6 = a >= 10;
            Console.WriteLine(c6);
            bool c7 = a == 10;
            Console.WriteLine(c7);
            bool c8 = a != 10;
            Console.WriteLine(c8);
        }
    }
}