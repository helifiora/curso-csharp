using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            
            return sum;
        }

        public static void Triple(ref int value)
        {
            value *= 3;
        }

        public static void Triple(int valor, out int resultado)
        {
            resultado = valor * 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(10, 20, 30, 40, 50, 60, 70, 80, 90, 100));
            int valor = 5;
            Calculator.Triple(ref valor); /// REF exige que a variável seja iniciada
            Console.WriteLine(valor);
            int resultado;
            Calculator.Triple(valor, out resultado);
            Console.WriteLine(resultado);
        }
    }
}