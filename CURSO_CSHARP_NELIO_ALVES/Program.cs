using System;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division Error: Division by zero is not allowed!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Error: Input string was not in a correct number");
            }
        }
    }
}