﻿using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            // atribuir à variável resultado a função Maior
            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior: " + resultado);  // apresentar o conteúdo da variável resultado

            // criar a função
            static int Maior(int a, int b, int c)
            {
                int m;

                if (a > b && a > c)
                {
                    m = a;
                }
                else if (b > c)
                {
                    m = b;
                }
                else
                {
                    m = c;
                }

                return m;
            }
        }
    }
}
