using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        // ATRIBUTOS
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }



        // CONSTRUTOR COM SOBRECARGA
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        // CONSTRUTOR COMPLETO
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        // CONSTRUTOR VAZIO
        public Conta() {}



        // MÉTODOS CALCULADOS
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        // MÉTODO TOSTRING
        public override string ToString()
        {
            return "Conta número: "
                + Numero
                + "\n"
                + "Titular: "
                + Titular
                + "\n"
                + "Saldo: "
                + Saldo.ToString("F2")
                + "\n";
        }
    }
}
