using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoInterface.Service
{
    interface IOnlinePaymentService // interface do programa
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);
    }
}
