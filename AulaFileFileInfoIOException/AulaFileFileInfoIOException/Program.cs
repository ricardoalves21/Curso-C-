using System;
using System.IO;

namespace AulaFileFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // criando variável que guarda o caminho de um arquivo
            string targetPath = @"c:\temp\file2.txt"; // criando variável que guarda o caminho de um arquivo novo (que ainda será criado)


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // instanciando um novo objeto do tipo FileInfo
                fileInfo.CopyTo(targetPath); // a partir do objeto criado, estou chamando o método 'copiar para' o caminho que está gravado na variável 'targetPath'
                string[] lines = File.ReadAllLines(sourcePath); // criando um vetor de string com o nome 'lines' e chamando uma função da classe File que lê todas as linhas do arquivo que está no caminho gravado na variável sourcePath
                foreach (string x in lines) // função foreach usada para ler todas as linhas do vetor 'lines'
                {
                    Console.WriteLine(x); // apresentação na tela das linhas que foram lidas no vetor 'lines'
                }
            }
            catch (IOException e) // criando o elemento 'e' referente à classe IOException
            {
                Console.WriteLine("An error occured"); // aviso de erro
                Console.WriteLine(e.Message); // o elemento 'e' está invocando a mensagem encontrada na classe IOException
            }
        }
    }
}
