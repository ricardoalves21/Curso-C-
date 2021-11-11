using System;
using ExercicioFixacaoExcecoes.Entities;
using System.Globalization;
using ExercicioFixacaoExcecoes.Entities.Exceptions;

namespace ExercicioFixacaoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {        
            // incluir o bloco try-catch para vincular o programa à exceção criada na classe Account

            try //tentar
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.withdraw(amount);

                Console.WriteLine();
                Console.WriteLine(account.ToString(), CultureInfo.InvariantCulture);
            }
            catch(DomainException e) //é aqui no catch que estamos vinculando o erro do programa à exceção criada na classe Account
            {
                Console.WriteLine("Error in account: " + e.Message); 
            }
            
        }
    }
}
