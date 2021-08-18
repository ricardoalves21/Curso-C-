using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercicio_04
{
    class Funcionario
    {
        // ATRIBUTOS
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        // MÉTODOS
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario (double porcentagem)
        {
            porcentagem = porcentagem / 100;
            SalarioBruto += SalarioBruto * porcentagem; 
        }
        public override string ToString()
        {
            return
                Nome
                + ", $ "
                + SalarioLiquido().ToString("F2");
        }
    }
}
