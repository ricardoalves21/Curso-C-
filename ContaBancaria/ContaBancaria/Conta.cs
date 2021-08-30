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



        // CONSTRUTOR
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
    
        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public Conta() {}



        // MÉTODOS
        public void Deposito(double valor)
        {
            Saldo += valor;
        }


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
