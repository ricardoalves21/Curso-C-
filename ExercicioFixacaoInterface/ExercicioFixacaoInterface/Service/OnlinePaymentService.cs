using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoInterface.Service
{
    interface IOnlinePaymentService // interface do programa
    {
        double interest(double amount, int months);
        double paymentFee(double amount);
    }
}
