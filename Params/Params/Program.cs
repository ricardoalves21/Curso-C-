﻿using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(2, 3);
            int s2 = Calculadora.Soma(5, 5, 5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
