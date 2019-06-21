using System;
using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5;
            Console.WriteLine(c2);

            bool c3 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c3);

            Console.WriteLine("---------------------------------------");

            bool c4 = 10 < 5;
            bool c5 = c2 || c3 && c4;
            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }
    }
}