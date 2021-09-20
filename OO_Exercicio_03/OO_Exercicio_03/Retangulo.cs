using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Exercicio_03
{
    class Retangulo
    {
        // ATRIBUTOS
        public double Largura;
        public double Altura;

        // MÉTODOS
        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return
                "AREA = "
                + Area().ToString("F2")
                + "\n"
                + "PERÍMETRO = "
                + Perimetro().ToString("F2")
                + "\n"
                + "DIAGONAL = "
                + Diagonal().ToString("F2")
                +"\n";
        }
    }
}
