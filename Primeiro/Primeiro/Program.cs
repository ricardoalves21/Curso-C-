using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Qual frase irá digitar? ");
            // string s = Console.ReadLine();
            // string[] vet = Console.ReadLine().Split(' ');
            // string p1 = vet[0];
            // string p2 = vet[1];
            // string p3 = vet[2];
            // Console.WriteLine("As palavras digitadas foram: " + p1 + " e " + p2 + " e " + p3);

            Console.WriteLine("Qual frase irá digitar? ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
 