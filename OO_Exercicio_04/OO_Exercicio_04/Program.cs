using System;

namespace OO_Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("DADOS DO FUNCIONÁRIO:");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            f.SalarioLiquido();

            Console.WriteLine();
            Console.Write("Funcionário: " + f);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double p = double.Parse(Console.ReadLine());

            f.AumentarSalario(p);

            Console.WriteLine();
            Console.Write("Funcionário: " + f);
            Console.WriteLine();
        }
    }
}
