using System;
using System.Globalization;
using System.Collections.Generic;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (var nomes in list)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("Tamanho: " + list.Count);

            string s1 = list.Find((nome) => nome.StartsWith('A'));
            Console.WriteLine("Ocorrencia: " + s1);

            string s2 = list.FindLast((nome) => nome.StartsWith('A'));
            Console.WriteLine("Ultima Ocorrencia: " + s2);

            int pos1 = list.FindIndex((nome) => nome.StartsWith('A'));
            Console.WriteLine("Primeira Posição: " + pos1);

            int pos2 = list.FindLastIndex((nome) => nome.StartsWith('A'));
            Console.WriteLine("Ultima Posição: " + pos2);

            List<string> novaLista = list.FindAll((nome) => nome.Length == 5);
            novaLista.ForEach((nome) => Console.WriteLine(nome));

            Console.WriteLine();
            list.Remove("Alex");
            list.ForEach((nome) => Console.WriteLine(nome));

            Console.WriteLine();
            list.RemoveAll((nome) => nome.StartsWith('M'));
            list.ForEach((nome) => Console.WriteLine(nome));

            Console.WriteLine();
            list.RemoveAt(1);
            list.ForEach((nome) => Console.WriteLine(nome));

            Console.WriteLine();
            list.Add("Helielton Fioramonte");
            list.Add("Marina Llase Rossi");
            list.Add("Carla Chiari");
            list.Add("Caroline Zuckovski");
            list.RemoveRange(0, 3);
            list.ForEach((nome) => Console.WriteLine(nome));
        }
    }
}