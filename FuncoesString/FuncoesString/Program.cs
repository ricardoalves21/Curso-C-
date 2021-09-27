using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper(); // transforma tudo em maiúscula
            string s2 = original.ToLower(); // transforma tudo em minúscula
            string s3 = original.Trim(); // retira os espaços antes e depois da string
            int n1 = original.IndexOf("bc"); // busca a primeira ocorrência de "bc" dentro da string
            int n2 = original.LastIndexOf("bc"); // busca a última ocorrência de "bc" dentro da string
            string s4 = original.Substring(6, 2); // recorta uma string a partir de um índice e da quantidade de posições a serem recortadas dessa string
            string s5 = original.Replace('a', 'x'); // substitui a letra 'a' pela letra 'x' em uma string
            string s6 = original.Replace("bcd", "kw"); // substitui a letra 'a' pela letra 'x' em uma string
            bool b1 = String.IsNullOrEmpty(original); // avalia se a variável é nula (NULL) ou vazia (EMPTY);
            bool b2 = String.IsNullOrWhiteSpace(original); // avalia se a variável é nula ou é espaço em branco


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring('bc'): " + s4 + "-");
            Console.WriteLine("Replace('a', 'x'): " + s5 + "-");
            Console.WriteLine("Replace('bcd', 'xy'): " + s6 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
