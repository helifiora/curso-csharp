using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Calculadora
    {
        public static double Circunferencia(double raio)
        {
            return 2 * Math.PI * raio;
        }

        public static double Volume(double raio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
        }
    }
}