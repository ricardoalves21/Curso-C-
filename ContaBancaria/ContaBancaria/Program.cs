using System;
using System.Collections.Generic;


namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando o objeto conta sem passar parâmetros
            Conta conta;  

            // criando e armazenando na variável numero
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            // criando e armazenando na variável titular
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();

            // criando e armazenando na variável resp
            Console.Write("Haverá depósito inicial [s/n]? ");
            char resp = char.Parse(Console.ReadLine());

            // criando e armazenando na variável depósito
            // armazenando no objeto conta passando os parâmetros para o construtor completo
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, deposito);
            }
            // armazenando no objeto conta passando os parâmetros para o construtor com sobrecarga
            else
            {
                conta = new Conta(numero, titular);
            }

            // apresentando a saída de dados através do ToString da classe
            Console.WriteLine();
            Console.WriteLine("DADOS DA CONTA");
            Console.WriteLine(conta);

            Console.Write("Haverá saque nesta conta [s/n]? ");
            resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);
            }

            Console.WriteLine();
            Console.WriteLine("DADOS DA CONTA");
            Console.WriteLine(conta);

        }
    }
}
