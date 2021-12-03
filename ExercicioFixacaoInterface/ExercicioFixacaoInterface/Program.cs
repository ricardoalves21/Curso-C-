using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacaoInterface.Entities;
using ExercicioFixacaoInterface.Service;

namespace ExercicioFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");


            /////// GUARDAR AS VARIÁVEIS ///////
            
            // número do contrato
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            
            // data do contrato
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // valor do contrato
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // quantidade de parcelas do contrato
            Console.Write("Enter number of installments: ");
            int qtdInstallments = int.Parse(Console.ReadLine());




            /////// INSTANCIAR OBJETOS ///////

            // instanciando o objeto contrato
            Contract contract = new Contract(number, date, value);

            ContractService contractService1 = new ContractService();
            contract.contractService.processContract(contract, qtdInstallments);

            // instanciando as prestações em lista
            List<Installment> installments = new List<Installment>();

            // preparando valor do contrato e datas para inserir na classe 'Installment'
            double parcelaSemTaxaEjuros = value / qtdInstallments;

            // preparar parcelas para as dadas
            DateTime parcela;

            for (int i = 1; i <= qtdInstallments; i++)
            {

                parcela = date.AddMonths(i);
                installments.Add(new Installment(parcela, parcelaSemTaxaEjuros));               

            }

            ContractService contractService = new ContractService();
            contractService.processContract(contract, qtdInstallments);


            Console.WriteLine(contract.ToString());


        }
    }
}
