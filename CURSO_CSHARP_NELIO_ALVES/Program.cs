using System;
using System.Globalization;
using System.Collections.Generic;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();

            a.Add(3);
            a.Add(5);
            a.Add(8);
            a.Add(9);

            b.Add(3);
            b.Add(4);
            b.Add(5);

            foreach (var valor in a)
            {
                Console.WriteLine(valor);
            }

            foreach (var valor in b)
            {
                Console.WriteLine(valor);
            }
        }
    }
}