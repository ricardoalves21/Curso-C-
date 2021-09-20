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

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Colaborador #" + (i+1)+ ": ");
                Console.Write("Qual será o ID do colaborador? ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                col.Add(new Colaborador(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Entre com o ID do colaborador que terá o salário aumentado: ");
            int idAum = int.Parse(Console.ReadLine());

            Console.Write("Entre com o percentual de aumento: ");
            double percAum = double.Parse(Console.ReadLine());



            foreach (Colaborador x in col)
            {
                Console.WriteLine(x);
            }



        }
    }
}
