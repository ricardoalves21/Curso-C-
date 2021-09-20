using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsOut
{
    class Calculadora
    {
        public static void Triplicar(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
