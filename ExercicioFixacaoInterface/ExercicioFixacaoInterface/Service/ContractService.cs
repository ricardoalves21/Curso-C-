using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacaoInterface.Entities;
using ExercicioFixacaoInterface.Service;

namespace ExercicioFixacaoInterface.Service
{
    class ContractService
    {

        // injeção de dependência (para acessar todas as classes que implementam a interface)
        public IOnlinePaymentService onlinePaymentService;

        
        //  métodos
        public void processContract(Contract contract, int months)
        {
            onlinePaymentService.interest(contract.va)
        }
        
    }
}
