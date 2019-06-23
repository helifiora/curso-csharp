using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }

        public double ValorTotalEstoque()
        {
            return Preco * Qtde;
        }
        public override string ToString()
        {
            return $"{Nome}, R$ {Preco:F2}, {Qtde} unidades, Total: R$ {ValorTotalEstoque():F2}";
        }

        public void AdicionaProdutos(int qtde)
        {
            Qtde += qtde;
        }

        public void RemoverProdutos(int qtde)
        {
            Qtde -= qtde;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Qtde = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");

            Console.Write("Digite o número de produtos para serem removidos: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");
        }
    }
}