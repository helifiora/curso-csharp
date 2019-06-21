using System;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            Console.WriteLine(x);

            SByte y = SByte.MinValue;
            Console.WriteLine(y);

            byte n2 = 254;
            n2++;
            n2++;
            Console.WriteLine(n2);
            
            int n3 = 1000;
            Console.WriteLine(n3);

            int n4 = Int32.MaxValue;
            Console.WriteLine(n4);

            long n5 = 2147483648L;
            Console.WriteLine(n5);
        }
    }
}