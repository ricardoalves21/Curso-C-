using ExercicioFixacaoInterface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoInterface.Entities
{
    class Installment
    {

        // atributos
        private DateTime DueDate { get; set; }
        private double Amount { get; set; }


        // construtor
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

    }
}
