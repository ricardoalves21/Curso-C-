using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacaoInterface.Entities;
using ExercicioFixacaoInterface.Service;

namespace ExercicioFixacaoInterface.Entities
{
    class Contract
    {

        // ATRIBUTOS
        private int Number { get; set; } // número do contrato
        private DateTime Date { get; set; } // data do contrato
        private double TotalValue { get; set; } // valor do contrato
        public ContractService contractService { get; set; } // ligando as classes 'Contract' e 'ContractService'
        public List<Installment> installments { get; set; } = new List<Installment>(); // ligando as classes 'Contract' e 'Installment' por composição lista (para guardar as parcelas do contrato)


        // CONSTRUTOR
        public Contract(int number, DateTime date, double totalValue, ContractService contractService)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            this.contractService = contractService;
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public Contract()
        {
        }








        // to string
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(installments);

            return sb.ToString();
        }


    }
}
