using System;

namespace ExercicioFixacaoExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException // nossa classe DomainException está herdando da super classe ApplicationExceçtion
    {
        public DomainException(string message) : base(message) //estamos herdando as mensagens do construtor da super classe ApplicationExceçtion
        {
        }
    }
}
