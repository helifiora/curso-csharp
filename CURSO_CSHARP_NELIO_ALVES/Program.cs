using System;
using System.IO;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "data.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if(sr != null)
                    sr.Close();
            }
        }
    }
}