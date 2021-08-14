using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();  // instanciando o objeto x que será originado da classe Triangulo
            Triangulo y = new Triangulo();  // instanciando o objeto y que será originado da classe Triangulo

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());  // dando ao objeto x o atributo A
            x.B = double.Parse(Console.ReadLine());  // dando ao objeto x o atributo B
            x.C = double.Parse(Console.ReadLine());  // dando ao objeto x o atributo C

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());  // dando ao objeto y o atributo A
            y.B = double.Parse(Console.ReadLine());  // dando ao objeto y o atributo B
            y.C = double.Parse(Console.ReadLine());  // dando ao objeto y o atributo C

            double areaX = x.Area();  // dando ao objeto x o método Area()
            double areaY = y.Area();  // dando ao objeto y o método Area()

            Console.WriteLine("Área de X = " + areaX.ToString("F4"));  // apresentando a variável areaX no formato com 4 casas decimais
            Console.WriteLine("Área de x = " + areaY.ToString("F4"));  // apresentando a variável areaY no formato com 4 casas decimais

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            } 
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
