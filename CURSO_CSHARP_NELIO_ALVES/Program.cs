using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">>> ");
            string frase = Console.ReadLine();

            Console.Write(">>> ");
            string x = Console.ReadLine();

            Console.Write(">>> ");
            string y = Console.ReadLine();

            Console.Write(">>> ");
            string z = Console.ReadLine();

            Console.Write(">>> ");
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            
            Console.WriteLine("Você digitou:");
            Console.WriteLine(" " + frase);
            Console.WriteLine(" " + x);
            Console.WriteLine(" " + y);
            Console.WriteLine(" " + z);
            Console.WriteLine(" " + p1);
            Console.WriteLine(" " + p2);
            Console.WriteLine(" " + p3);
            
        }
    }
}