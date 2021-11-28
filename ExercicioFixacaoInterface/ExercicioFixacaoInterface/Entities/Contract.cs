using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacaoInterface.Entities;
using ExercicioFixacaoInterface.Service;

namespace ExercicioFixacaoInterface.Entities
{
    class Contract
    {

        // atributos simples
        private int Number { get; set; } // número do contrato
        private DateTime Date { get; set; } // data do contrato
        private double TotalValue { get; set; } // valor do contrato



        // composição simples
        public ContractService contractService { get; set; } // ligando as classes 'Contract' e 'ContractService'



        // composição lista (atributo)
        public List<Installment> installments { get; set; } = new List<Installment>(); // composição lista ( para guardar as parcelas do contrato)



        // construtor
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }   
        



    }
}
