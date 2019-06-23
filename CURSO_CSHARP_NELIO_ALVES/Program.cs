using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {
            
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoveEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }
        
        public override string ToString()
        {
            return $"{Nome}, R$ {Preco:F2} - {Quantidade} unidades. Valor Total: R$ {ValorTotalEstoque():F2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            int qtde;
            Console.WriteLine($"Dados do Produto: {p}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            qtde = int.Parse(Console.ReadLine());
            
            p.AdicionaEstoque(qtde);
            Console.WriteLine($"Dados Atualizados: {p}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos no estoque: ");
            qtde = int.Parse(Console.ReadLine());
            
            p.RemoveEstoque(qtde);
            Console.WriteLine($"Dados Atualizados: {p}");
        }
    }
}