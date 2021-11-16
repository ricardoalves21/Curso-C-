using System;
using System.IO;

namespace ExercicioFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\temp\sourceFile\file1.csv"; // arquivo de origem
            string outFile = @"C:\temp\out\summary1.csv"; // arquivo de destino

            try
            {
                string[] lines = File.ReadAllLines(sourceFile);

                using (StreamWriter sw = File.AppendText(outFile))
                {
                    foreach (string conteudo in lines)
                    {
                        sw.WriteLine(conteudo);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
