using System;
using System.IO;

namespace TeoriaPath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Path é uma classe que realiza operações com strings que contém informações de arquivos ou pastas.
             * Seguem os exemplos abaixo:
             */

            string path = @"c\temp\myfolder\file1.txt";

            #region Alguns exemplos de uso da classe Path
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // apresenta qual é o caractere de separação dos diretórios
            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // apresenta qual é o caractere que separa diferentes pastas
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // pega o caminho do arquivo referente à pasta que o arquivo se encontra
            Console.WriteLine("GetFileName: " + Path.GetFileName(path)); // esta função serve para pegar o nome do arquivo
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)); // pega o nome do arquivo sem a extensão
            Console.WriteLine("GetExtension: " + Path.GetExtension(path)); // esta função pega apenas a extensão do arquivo especificado no caminho
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)); // função que pega todo o caminho do arquivo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); // função que pega qual é a pasta temporária do meu sistema
            #endregion
        }
    }
}
