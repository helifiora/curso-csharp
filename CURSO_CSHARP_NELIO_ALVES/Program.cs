using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Números Inteiros Você Vai Digitar? ");
            int qtd = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= qtd; i++)
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"Soma: {soma}");
        }
    }
}