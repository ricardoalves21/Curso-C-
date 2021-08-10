using System;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(dados[0]);
            Console.WriteLine(dados[1]);
            Console.WriteLine(dados[2]);

        }
    }
}
