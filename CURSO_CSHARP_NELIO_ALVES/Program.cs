using System;
using CURSO_CSHARP_NELIO_ALVES.Entities;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010,"Bob Brown",100.0,500.0);
            Console.WriteLine(account.Balance);
        }
    }
}