﻿using System;

namespace OO_Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double salarioMedio = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário médio: " + salarioMedio.ToString("f2"));
        }
    }
}
