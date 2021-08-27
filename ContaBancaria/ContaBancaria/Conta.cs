using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        // ATRIBUTOS
        private int Numero { get; set; }
        private int Titular { get; set; }
        private int _saldo;

        // CONSTRUTOR
        public Conta(int numero, int titular, int saldo)
        {
            Numero = numero;
            Titular = titular;
            _saldo = saldo;
        }

        public Conta()
        {
        }

        // MÉTODOS
        public int Saldo
        {
            get { return _saldo; }
            set
            {
                _saldo += Saldo;
            }
        }

        override
        public string ToString()
        {
            return
                "Conta número: "
                + Numero
                + "\n"
                + "Titular: "
                + Titular
                + "\n"
                + "Saldo: "
                + _saldo.ToString("F2")
                + "\n";
        }
        

    }
}
