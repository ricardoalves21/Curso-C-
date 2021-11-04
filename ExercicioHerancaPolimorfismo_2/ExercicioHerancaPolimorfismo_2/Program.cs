using ExercicioHerancaPolimorfismo_2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>(); // lista que guardará todos os dados das três classes
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) // looping para incluir todos os contribuintes
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // este if é para sabermos na lista de qual classe incluiremos o contribuinte
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();

            // este foreach é para varrermos a lista por completo a fim de apresentarmos todos os contribuintes que foram incluídos na lista
            foreach (TaxPayer tp in list)
            {
                Console.WriteLine(tp.Name + ": $ " + tp.tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0; // variável global para acumular os valores dos impostos de todos os contribuintes

            // este foreach é para varrer a lista inteira a fim de somar todos os impostos inseridos nela
            foreach (TaxPayer tp in list)
            {
                sum += tp.tax();
            }

            // apresentar o total de impostos pagos por todos os contribuintes
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
