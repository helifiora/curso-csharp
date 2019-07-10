using System;
using System.IO;
using System.Linq;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = "data.txt";
            string targetPath = "copy.txt";

            try
            {
                FileInfo file = new FileInfo(sourcePath);
                Console.WriteLine(file.Directory.Name);
                file.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                Console.WriteLine(string.Join('\n', lines));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}