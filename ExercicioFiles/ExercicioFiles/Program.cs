using System;
using System.IO;
using System.Globalization;

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

                string[] lines = File.ReadAllLines(sourceFile); // 'lines' é um vetor
                string[,] produtos = new string[lines.Length, lines.Length - 1]; // 'produtos' é uma matriz
                int linha = 0;


                foreach (string s in lines) // 's' lerá linha por linha do vetor 'lines'
                {
                    string[] valor = s.Split(','); // 'valor' é um vetor que lerá 's' e separá o conteúdo em cada índice
                    

                    for (int cont = 0; cont < lines.Length-1; cont++) // 'cont' será responsável por contar em qual índice o vetor 'valor' estará
                    {                        
                        produtos[linha, cont] = valor[cont]; // a matriz 'produtos' receberá os valores que estarão armazenados em 'linha' e 'cont'
                    }

                    double total = double.Parse(valor[1], CultureInfo.InvariantCulture) * double.Parse(valor[2], CultureInfo.InvariantCulture); // 'total' será responsável por multiplicar o preço pela quantidade os quais estão registrados em 'valor' nos índices [1] e [2]

                    using (StreamWriter sw = File.AppendText(outFile)) // usando o 'using' para que o fechamento do 'File' seja automático // instanciando o objeto 'sw' da classe StreamWrites para escrever no final do arquivo que está referenciado em 'outFile'
                    {
                                               
                        sw.WriteLine(valor[0] + "  |  " + total.ToString("F2", CultureInfo.InvariantCulture)); // escrevendo linha por linha no objeto 'sw' os vetores 'valor[0]' e a variável 'total'
                        
                    }

                    linha++; // pulando para a próxima linha
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
