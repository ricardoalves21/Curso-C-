using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt"; // apontando o caminho do arquivo existente
            StreamReader sr = null; // variável que fará a leitura do arquivo

            try
            {
                sr = File.OpenText(path); // a variável criada 'sr' está recebendo o comando 'File' para ler o arquivo que está no caminho apontado pela variável 'path'

                while (!sr.EndOfStream) // percorrer o arquivo que está sendo lido pela variável 'sr' e enquanto não chegar ao final da 'stream' continuar lendo
                {
                    string line = sr.ReadLine(); // criando a variável 'line' que recebe a variável 'sr' com comando para ler uma linha
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
