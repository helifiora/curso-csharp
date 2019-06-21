using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void exercicio()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            byte nQuartos = byte.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] line = Console.ReadLine().Split(' ');

            string ultimoNome = line[0];
            int idade = int.Parse(line[1]);
            double altura = double.Parse(line[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(nQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string[] line = Console.ReadLine().Split(' ');
            string nome = line[0];
            char sexo = char.Parse(line[1]);
            int idade = int.Parse(line[2]);
            double altura = double.Parse(line[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            
            exercicio();
        }
    }
}