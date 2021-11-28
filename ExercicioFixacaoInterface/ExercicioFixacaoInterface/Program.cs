using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacaoInterface.Entities;

namespace ExercicioFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            
            // número do contrato
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            
            // data do contrato
            Console.Write("Date (dd//MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            // valor do contrato
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // quantidade de parcelas do contrato
            Console.Write("Enter number of installments: ");
            int qtdInstallments = int.Parse(Console.ReadLine());

            // instanciando o objeto contrato
            Contract contract = new Contract(number, date, value);


            // instanciando a lista de parcelas
            List<Installment> installments = new List<Installment>();





        }
    }
}
