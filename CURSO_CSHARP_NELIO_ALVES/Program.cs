using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            
            Console.WriteLine("Bom dia!");
            
            if(x > 5)
                Console.WriteLine("Boa tarde!");

            Console.WriteLine("Boa noite!");

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Entre com o número inteiro: ");
            int v = int.Parse(Console.ReadLine());
            
            if(v % 2 == 0)
                Console.WriteLine($"Valor {v} é par!");
            else
                Console.WriteLine($"Valor {v} é ímpar!");

            Console.WriteLine("--------------------------------------------");

            Console.Write("Qual a Hora Atual? ");
            int hora = int.Parse(Console.ReadLine());
            
            if(hora < 12)
                Console.WriteLine("Bom Dia!");
            else if(hora < 18)
                Console.WriteLine("Boa Tarde!");
            else
                Console.WriteLine("Boa Noite!");
        }
    }
}