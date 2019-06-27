using System;
using System.Globalization;
using System.Collections.Generic;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("Main Diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }

            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0)
                        count++;
                }
            }

            Console.WriteLine("Negative Numbers: " + count);
        }
    }
}