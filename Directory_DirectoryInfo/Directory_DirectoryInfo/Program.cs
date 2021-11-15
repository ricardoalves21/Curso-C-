using System;
using System.IO;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            * Directory e DirectoryInfo servem para oferecer operações com pastas (criar pastas, listar arquivos e diretórios, etc. 
            * Iremos listar as pastas
            */

            #region Listando pastas

            string path = @"c:\temp\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // criando a variável 'folders' e atribuindo a ela um comando para listar/enumerar todas as subpastas do diretório apontado em 'path'
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion Listando pastas


            /* 
            * Agora iremos listar os arquivos 
            */

            #region Listando arquivos
            try
            {
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // criando a variável 'files' e atribuindo a ela um comando para listar/enumerar todos os arquivos da pasta/diretório apontado em 'path'
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion


            /* 
            * Agora iremos listar os arquivos 
            */

            #region Criando pastas
            try
            {
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}
