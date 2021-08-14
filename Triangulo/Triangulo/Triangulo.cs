
using System;  // Importação de dependências

namespace Triangulo  // Namespace da classe
{
    class Triangulo  // Nome da classe
    {
        // ATRIBUTOS
        public double A;
        public double B;
        public double C;

        public double Area()  // se o método não retorna nada, usa-se a palavra "void"
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
