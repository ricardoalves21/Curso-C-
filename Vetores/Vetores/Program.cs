using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números irá digitar? ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com o número na posição " + i + ": ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vet[i];
            }

            double media = sum / n;
            Console.WriteLine("A média dos valores do vetor é " + media.ToString("F2"));
        }
    }
}
