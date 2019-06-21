using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green!";
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);

            nome = "John Lennon!";
            Console.WriteLine(nome);

            object obj1 = "Alex Brown";
            Console.WriteLine(obj1);

            object obj2 = 4.5f;
            Console.WriteLine(obj2);

            int nIntMin = int.MinValue;
            int nIntMax = int.MaxValue;
            Console.WriteLine(nIntMin + " " + nIntMax);

            sbyte nByteMax = sbyte.MaxValue;
            Console.WriteLine(nByteMax);

            decimal nDecimal = decimal.MaxValue;
            Console.WriteLine(nDecimal);
        }
    }
}