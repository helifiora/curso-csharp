using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream fs = new FileStream("data.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        List<Employee> list = new List<Employee>(50);
                        while (!sr.EndOfStream)
                        {
                            list.Add(new Employee(sr.ReadLine()));
                        }
                        
                        list.Sort();
                        foreach (Employee s in list)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}