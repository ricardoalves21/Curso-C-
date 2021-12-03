using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacaoInterface.Entities;
using ExercicioFixacaoInterface.Service;

namespace ExercicioFixacaoInterface.Service
{
    class ContractService
    {

        // composição simples
        public IOnlinePaymentService onlinePaymentService { get; set; } // ligando as classes 'ContractService' e 'OnlinePaymentService'

        
        //  métodos
        public void processContract(Contract contract, int months)
        {
        }
        
    }
}
