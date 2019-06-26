using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] {"Maria", "Alex", "Bob"};

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("----------------------------------");

            foreach (var nomes in vetor)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}