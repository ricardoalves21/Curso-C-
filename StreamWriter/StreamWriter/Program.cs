using System;
using System.IO;

namespace TeoriaStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Neste programa iremos ler tudo que está no arquivo file1 e salvar em letras maiúsculas no arquivo file2 */

            string sourcePath = @"c:\temp\file1.txt"; // variável que chama o arquivo de origem
            string targetPath = @"c:\temp\file2.txt"; // variável que chama o arquivo de destino

            try
            {
                string[] lines = File.ReadAllLines(sourcePath); // criando a variável 'lines' do tipo vetor para ler todas as linhas do arquivo que existe no caminho descrito pela variável 'sourcePath'

                using (StreamWriter sw = File.AppendText(targetPath)) // instanciando no bloco 'using' a variável 'sw' que fará a inclusão de conteúdo de texto no arquivo que está no caminho descrito pela variável 'targetPath' 
                {
                    foreach (string x in lines) // criando a variável 'x' que será criada a partir do vetor 'lines'
                    {
                        sw.WriteLine(x.ToUpper()); // a variável 'sw' está chamando o comando 'writeline' para escrever em letras maiúsculas dentro do arquivo 'x' 
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
