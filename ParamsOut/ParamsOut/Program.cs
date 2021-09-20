using System;

namespace ParamsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int triplicar;
            Calculadora.Triplicar(a, out triplicar);
            Console.WriteLine(triplicar);
        }
    }
}
