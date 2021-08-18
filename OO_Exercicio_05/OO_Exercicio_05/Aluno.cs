using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercicio_05
{
    class Aluno
    {
        // ATRIBUTOS
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        // MÉTODOS
        public double NotaFinal()
        {
            double total = Nota1 + Nota2 + Nota3;
            return total;
        }
    }
}
