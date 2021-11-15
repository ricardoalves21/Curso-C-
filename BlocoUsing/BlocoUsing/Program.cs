using System;
using System.IO;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt"; // criando a variável que contem o caminho do arquivo que será lido

            try
            {                
                using (StreamReader sr = File.OpenText(path)) // criando o bloco 'using' onde tudo que for instanciado nele, ao final será automaticamente fechado
                {
                    while (!sr.EndOfStream) // fazendo a leitura da variável 'sr' linha por linha até o final e apresentando cada linha na tela do usuário
                    {
                        string line = sr.ReadLine(); // criando a variável 'line' que receberá a variável 'sr' seguida do comando de leitura por linha
                        Console.WriteLine(line); // apresentando a variável 'line' na tela do usuário
                    }
                }
            }
            catch (IOException e) // chamando a classe IOException
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message); // apresentando uma mensagem de exceção, caso seja encontrada essa mensagem dentro da classe IOException
            }

        }
    }
}
