using System;
using System.Collections.Generic;

namespace ExercicioFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Colaborador> col = new List<Colaborador>();
            Colaborador colab = new Colaborador();

            Console.Write("Quantos colaboradores você irá registrar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Colaborador #" + i + ": ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Entre com o ID do colaborador que terá o salário aumentado: ");
                int idAum = int.Parse(Console.ReadLine());

                Console.Write("Entre com o percentual de aumento: ");
                double percAum = double.Parse(Console.ReadLine());

                colab.aumentoSalario(idAum, percAum);

                
                

            }


        }
    }
}
