using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void exercicio()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            uint codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1:C}");
            Console.WriteLine($"{produto2}, cujo preço é {preco2:C}");
            Console.WriteLine();

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();

            Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separar decimal invariant culture: " +
                              medida.ToString("F3", CultureInfo.InvariantCulture));
        }

        static void Main(string[] args)
        {
            Console.Write("Bom Dia!");
            Console.WriteLine(" Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("---------------------------");

            char genero = 'F';
            int idade = 17;
            double saldo = 10.35784;
            string nome = "Marina Llase";
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------");

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:C} reais", nome, idade, saldo);
            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:C} reais");
            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("C") + " reais");

            Console.WriteLine("-----------------------------");
            exercicio();
        }
    }
}