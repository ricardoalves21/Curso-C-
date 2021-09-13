using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsRef
{
    class Calculadora
    {
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }
    }
}
