using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacaoInterface.Service;

namespace ExercicioFixacaoInterface.Service
{
    class PaypalService : IOnlinePaymentService
    {

        public double interest(double amount, int months)
        {
            // parcela sem juros
            // parcela sem juros * 1% da parcela sem juros * o número da parcela
            // return juros simples
        }

        public double paymentFee(double amount)
        {
            // parcela com juros
            // parcela com juros * 2% da parcela com juros
            // return parcela final
        }
    }
}
