using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\elvis7.txt";
            string targetPath = @"c:\temp\elvio.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); // Escrevendo todo o Conteúdo em Letras MAIÚSCULAS
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
