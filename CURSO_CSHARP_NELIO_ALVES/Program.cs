using System;
using System.Globalization;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            Console.WriteLine(d1);
            
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d2);
            
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            Console.WriteLine(d3);
            
            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);
            
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
            
            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);
            
            DateTime d9 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d10);
            
            DateTime d11 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }
    }
}