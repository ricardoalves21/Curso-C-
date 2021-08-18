using System;

namespace OO_Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("ENTRE COM A LARGURA E ALTURA DO RETÂNGULO");
            r.Largura = double.Parse(Console.ReadLine());

            r.Altura = double.Parse(Console.ReadLine());

            r.Area();
            r.Perimetro();
            r.Diagonal();
            Console.WriteLine(r);
        }
    }
}
