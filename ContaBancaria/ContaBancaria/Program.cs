using System;
using System.Collections.Generic;


namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? ");
            char resp = char.Parse(Console.ReadLine());



            if (resp == 's' || resp == 'S')
            {
                Console.Write("Valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, deposito);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("DADOS DA CONTA");
            Console.WriteLine(conta);

        }
    }
}
