using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    struct Vetor
    {
        public double X;
        public double Y;

        public Vetor(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"vetor(x: {X:F2}, y: {Y:F2})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vetor v = new Vetor(50.0, 60.0);
            Vetor v2 = v;
            v2.X = 100;
            Console.WriteLine(v);
            Console.WriteLine(v2);
        }
    }
}