using System.Text;
using ExercicioFixacaoExcecoes.Entities.Exceptions;

namespace ExercicioFixacaoExcecoes.Entities
{
    class Account
    {
        //atributos
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        //contrutores
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public Account()
        {
        }

        //métodos
        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount) // A exceção foi criada neste método
        {
            if (amount > Balance)
            {
                throw new DomainException("Saldo insuficiente!"); // aqui estamos lançando uma exceção na classe DomainException                
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Limite insuficiente!"); // aqui estamos lançando outra exceção na classe DomainException
            } 

            Balance -= amount;
        }

        //to string com StringBuilder
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("New balance: " + Balance);

            return sb.ToString();
        }
    }
}
