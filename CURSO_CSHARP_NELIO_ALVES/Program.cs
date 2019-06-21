using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 3;
            Console.WriteLine(a);

            a *= 4;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("--------------------------");

            int v = 10;
            v++;
            Console.WriteLine(v);
            v--;
            Console.WriteLine(v);

            int y = ++v;
            Console.WriteLine(" " + v + " " + y);
        }
    }
}