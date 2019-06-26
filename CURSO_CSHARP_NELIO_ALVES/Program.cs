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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(10, 20, 30, 40, 50, 60, 70, 80, 90, 100));
        }
    }
}