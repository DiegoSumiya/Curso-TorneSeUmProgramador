using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Tabuada
    {
        public static void Calcular(int numero)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }
    }
}
